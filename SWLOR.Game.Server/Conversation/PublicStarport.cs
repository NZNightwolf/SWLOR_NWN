﻿using System;
using System.Linq;
using NWN;
using SWLOR.Game.Server.Data.Entity;
using SWLOR.Game.Server.GameObject;
using SWLOR.Game.Server.Service;

using SWLOR.Game.Server.ValueObject.Dialog;
using Object = NWN.Object;

namespace SWLOR.Game.Server.Conversation
{
    public class PublicStarport : ConversationBase
    {
        public override PlayerDialog SetUp(NWPlayer player)
        {
            PlayerDialog dialog = new PlayerDialog("MainPage");

            DialogPage mainPage = new DialogPage("Please select which ship you would like to enter from the list below. Ships must be built on a base, but once built they can be berthed here for a fee.");

            dialog.AddPage("MainPage", mainPage);
            return dialog;
        }

        public override void Initialize()
        {
            LoadMainPage();
        }

        public override void DoAction(NWPlayer player, string pageName, int responseID)
        {
            MainPageResponses(responseID);
        }

        public override void Back(NWPlayer player, string previousPageName, string currentPageName)
        {
        }


        private void LoadMainPage()
        {
            NWPlaceable door = Object.OBJECT_SELF;
            string starportID = door.GetLocalString("STARPORT_ID");

            if (string.IsNullOrWhiteSpace(starportID))
            {
                _.SpeakString("STARPORT_ID is not set. Please inform an admin.");
                return;
            }

            ClearPageResponses("MainPage");

            var player = GetPC();

            // Get starships owned by player and docked at this starport.
            var ships = DataService.GetAll<PCBase>().Where(x => x.PlayerID == player.GlobalID &&
                                                         x.ShipLocation == starportID.ToLower() &&
                                                         x.DateRentDue > DateTime.UtcNow)
                                             .OrderBy(o => o.DateInitialPurchase)
                                             .ToList();

            // Get starships owned by other players and the current player currently has access to.
            var permissions = DataService.GetAll<PCBaseStructurePermission>().Where(x => x.PlayerID == player.GlobalID);
            var permissionedShips = DataService.Where<PCBase>(x =>
            {
                if (x.ShipLocation != starportID.ToLower() ||
                    x.DateRentDue <= DateTime.UtcNow ||
                    x.PlayerID == player.GlobalID) return false;

                PCBaseStructure ship = DataService.Single<PCBaseStructure>(s => s.PCBaseID == x.ID && s.ExteriorStyleID > 0);
                var permission = permissions.SingleOrDefault(p => p.PCBaseStructureID == ship.ID);
                return permission != null && permission.CanEnterBuilding;
            })
                .ToList();

            int count = 1;
            foreach (var ship in ships)
            {
                string name = "Starship #" + count;

                if (!string.IsNullOrWhiteSpace(ship.CustomName))
                {
                    // Custom names are probably set at the base structure level, so this likely needs reworking.
                    name = ship.CustomName;
                }

                AddResponseToPage("MainPage", name, true, ship.ID);

                count++;
            }

            foreach (var ship in permissionedShips)
            {
                var owner = DataService.Get<Player>(ship.PlayerID);
                string name = owner.CharacterName + "'s Starship [" + owner.CharacterName + "]";

                if (!string.IsNullOrWhiteSpace(ship.CustomName))
                {
                    name = ship.CustomName + " [" + owner.CharacterName + "]";
                }

                AddResponseToPage("MainPage", name, true, ship.ID);
            }

        }

        private void MainPageResponses(int responseID)
        {
            var response = GetResponseByID("MainPage", responseID);
            Guid pcApartmentID = (Guid)response.CustomData;
            EnterShip(pcApartmentID);
        }

        private void EnterShip(Guid pcBaseID)
        {
            NWPlayer oPC = GetPC();

            var shipBase = DataService.Get<PCBase>(pcBaseID);
            var ship = DataService.SingleOrDefault<PCBaseStructure>(x => x.PCBaseID == shipBase.ID && x.InteriorStyleID != null);

            NWArea instance = BaseService.GetAreaInstance(ship.ID, false);

            if (instance == null)
            {
                instance = BaseService.CreateAreaInstance(oPC, ship.ID, false);
            }

            BaseService.JumpPCToBuildingInterior(oPC, instance);
        }

        public override void EndDialog()
        {
        }
    }
}
