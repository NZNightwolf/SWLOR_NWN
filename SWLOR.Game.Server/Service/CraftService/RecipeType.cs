﻿namespace SWLOR.Game.Server.Service.CraftService
{
    public enum RecipeType
    {
        Invalid = 0,

        // Smithery: 1-1000

        BasicGreatSword = 1,
        BasicSpear = 2,
        BasicKnife = 3,
        BasicPistol = 4,
        BasicStaff = 5,
        BasicLongsword = 6,
        BasicKatar = 7,
        BasicShuriken = 8,
        BasicRifle = 9,
        BasicTwinBlade = 10,
        BattlemasterShield = 11,
        BattlemasterCloak = 12,
        BattlemasterBelt = 13,
        BattlemasterRing = 14,
        BattlemasterNecklace = 15,
        BattlemasterBreastplate = 16,
        BattlemasterHelmet = 17,
        BattlemasterBracer = 18,
        BattlemasterLeggings = 19,
        SpiritmasterCloak = 20,
        SpiritmasterBelt = 21,
        SpiritmasterRing = 22,
        SpiritmasterNecklace = 23,
        SpiritmasterTunic = 24,
        SpiritmasterCap = 25,
        SpiritmasterGloves = 26,
        SpiritmasterBoots = 27,
        CombatCloak = 28,
        CombatBelt = 29,
        CombatRing = 30,
        CombatNecklace = 31,
        CombatTunic = 32,
        CombatCap = 33,
        CombatGloves = 34,
        CombatBoots = 35,

        TitanGreatSword = 36,
        TitanSpear = 37,
        TitanKnife = 38,
        TitanPistol = 39,
        TitanStaff = 40,
        TitanLongsword = 41,
        TitanKatar = 42,
        TitanShuriken = 43,
        TitanRifle = 44,
        TitanTwinBlade = 45,
        TitanShield = 46,
        TitanCloak = 47,
        TitanBelt = 48,
        TitanRing = 49,
        TitanNecklace = 50,
        TitanBreastplate = 51,
        TitanHelmet = 52,
        TitanBracer = 53,
        TitanLeggings = 54,
        VividCloak = 55,
        VividBelt = 56,
        VividRing = 57,
        VividNecklace = 58,
        VividTunic = 59,
        VividCap = 60,
        VividGloves = 61,
        VividBoots = 62,
        ValorCloak = 63,
        ValorBelt = 64,
        ValorRing = 65,
        ValorNecklace = 66,
        ValorTunic = 67,
        ValorCap = 68,
        ValorGloves = 69,
        ValorBoots = 70,

        DeltaGreatSword = 71,
        DeltaSpear = 72,
        DeltaKnife = 73,
        DeltaPistol = 74,
        DeltaStaff = 75,
        DeltaLongsword = 76,
        DeltaKatar = 77,
        DeltaShuriken = 78,
        DeltaRifle = 79,
        DeltaTwinBlade = 80,
        QuarkShield = 81,
        QuarkCloak = 82,
        QuarkBelt = 83,
        QuarkRing = 84,
        QuarkNecklace = 85,
        QuarkBreastplate = 86,
        QuarkHelmet = 87,
        QuarkBracer = 88,
        QuarkLeggings = 89,
        ReginalCloak = 90,
        ReginalBelt = 91,
        ReginalRing = 92,
        ReginalNecklace = 93,
        ReginalTunic = 94,
        ReginalCap = 95,
        ReginalGloves = 96,
        ReginalBoots = 97,
        ForzaCloak = 98,
        ForzaBelt = 99,
        ForzaRing = 100,
        ForzaNecklace = 101,
        ForzaTunic = 102,
        ForzaCap = 103,
        ForzaGloves = 104,
        ForzaBoots = 105,

        ProtoGreatSword = 106,
        ProtoSpear = 107,
        ProtoKnife = 108,
        ProtoPistol = 109,
        ProtoStaff = 110,
        ProtoLongsword = 111,
        ProtoKatar = 112,
        ProtoShuriken = 113,
        ProtoRifle = 114,
        ProtoTwinBlade = 115,
        ArgosShield = 116,
        ArgosCloak = 117,
        ArgosBelt = 118,
        ArgosRing = 119,
        ArgosNecklace = 120,
        ArgosBreastplate = 121,
        ArgosHelmet = 122,
        ArgosBracer = 123,
        ArgosLeggings = 124,
        GrenadaCloak = 125,
        GrenadaBelt = 126,
        GrenadaRing = 127,
        GrenadaNecklace = 128,
        GrenadaTunic = 129,
        GrenadaCap = 130,
        GrenadaGloves = 131,
        GrenadaBoots = 132,
        SurvivalCloak = 133,
        SurvivalBelt = 134,
        SurvivalRing = 135,
        SurvivalNecklace = 136,
        SurvivalTunic = 137,
        SurvivalCap = 138,
        SurvivalGloves = 139,
        SurvivalBoots = 140,

        OphidianGreatSword = 141,
        OphidianSpear = 142,
        OphidianKnife = 143,
        OphidianPistol = 144,
        OphidianStaff = 145,
        OphidianLongsword = 146,
        OphidianKatar = 147,
        OphidianShuriken = 148,
        OphidianRifle = 149,
        OphidianTwinBlade = 150,
        EclipseShield = 151,
        EclipseCloak = 152,
        EclipseBelt = 153,
        EclipseRing = 154,
        EclipseNecklace = 155,
        EclipseBreastplate = 156,
        EclipseHelmet = 157,
        EclipseBracer = 158,
        EclipseLeggings = 159,
        TranscendentCloak = 160,
        TranscendentBelt = 161,
        TranscendentRing = 162,
        TranscendentNecklace = 163,
        TranscendentTunic = 164,
        TranscendentCap = 165,
        TranscendentGloves = 166,
        TranscendentBoots = 167,
        SupremeCloak = 168,
        SupremeBelt = 169,
        SupremeRing = 170,
        SupremeNecklace = 171,
        SupremeTunic = 172,
        SupremeCap = 173,
        SupremeGloves = 174,
        SupremeBoots = 175,

        Electroblade1 = 176,
        Electroblade2 = 177,
        Electroblade3 = 178,
        Electroblade4 = 179,
        Electroblade5 = 180,
        TrainingSaber1 = 181,
        TrainingSaber2 = 182,
        TrainingSaber3 = 183,
        TrainingSaber4 = 184,
        TrainingSaber5 = 185,

        SithLongsword = 186,
        SithKnife = 187,
        SithGreatSword = 188,
        SithSpear = 189,
        SithKatar = 190,
        SithStaff = 191,
        SithPistol = 192,
        SithTwinBlade = 193,
        SithRifle = 194,
        SithShuriken = 195,
        SithElectroblade = 196,

        // Fabrication:  1001-2000
        BedRoll = 1001,
        Easel = 1002,
        Candle = 1003,
        Carpet = 1004,
        Cot = 1005,
        Keg = 1006,
        ChairWoodSmall = 1007,
        RopeCoil = 1008,
        ThrowRug = 1009,
        ChairWood = 1010,
        Cushions = 1011,
        TableWood = 1012,
        BenchWoodSmall = 1013,
        TableWoodWithFish = 1014,
        AltarHand = 1015,
        Footstool = 1016,
        Pedestal = 1017,
        Tome = 1018,
        PottedPlant = 1019,
        Net = 1020,
        Gong = 1021,
        DoorwayMetal = 1022,
        BirdCage = 1023,
        TorchBracket = 1024,
        ObeliskSmall = 1025,
        TableWoodLarge = 1026,
        FridgeWorn = 1027,
        LadderLight = 1028,
        Birdbath = 1029,
        BenchWood = 1030,
        LadderDark = 1031,
        PillarWoodDark = 1032,
        Window = 1033,
        PedestalEvil = 1034,
        BrazierRound = 1035,
        VaseTall = 1036,
        BrazierStone = 1037,
        Ottoman = 1038,
        StatueGuardian = 1039,
        LampPost = 1040,
        FlamingStatue = 1041,
        PillarRounded = 1042,
        Jukebox = 1043,
        Painting1 = 1044,
        DoorwayStone = 1045,
        PillarWood = 1046,
        StatueMonster = 1047,
        Candelabra = 1048,
        FridgeDark = 1049,
        ObeliskLarge = 1050,
        GnomishContraption = 1051,
        FemaleStatue = 1052,
        VaseRounded = 1053,
        PedestalSword = 1054,
        BedWoodYellow = 1055,
        Urn = 1056,
        PillarStone = 1057,
        Cage = 1058,
        OvergrownPillar = 1059,
        FloorAnchoredShackles = 1060,
        StatueWyvern = 1061,
        BunkBed = 1062,
        Fountain = 1063,
        RoundWoodenTable = 1064,
        AltarStone = 1065,
        StatueOfLathander = 1066,
        BearSkinRug = 1067,
        CarpetFancy = 1068,
        AltarEvil = 1069,
        IllithidTable = 1070,
        FridgeStainless = 1071,
        TableStoneSmall = 1072,
        BedLarge = 1073,
        StatueWizard = 1074,
        BenchLarge = 1075,
        TableStoneLarge = 1076,
        CarpetRoundBlue = 1077,
        Chandelier = 1078,
        ChairWoodMedium = 1079,
        StatueHuge = 1080,
        BenchStoneDwarven = 1081,
        PillarFlame = 1082,
        DrowTable = 1083,
        MiningWellPlatform = 1084,
        MiningWell = 1085,
        BedStoneYellow = 1086,
        Mirror = 1087,
        BedExtraLarge = 1088,
        RunePillar = 1089,
        StatueCyric = 1090,

        SphinxStatue = 1092,
        Dartboard = 1093,
        DranStatue = 1094,
        Map = 1095,
        SeaIdol = 1096,
        Painting2 = 1097,
        ChairStone = 1098,
        DrowAltar = 1099,
        ThroneWood = 1100,
        IllithidChair = 1101,
        MonsterStatue = 1102,
        ShrineOfUmberlee = 1103,
        CarpetFancySmaller = 1104,
        DrowChair = 1105,
        BenchWoodSmall2 = 1106,
        DrowBar = 1107,
        ChairShell = 1108,
        BenchWoodLarge = 1109,
        CouchWoodYellow = 1110,

        WeaponRackWallMounted = 1111,
        StatueTwilek = 1112,
        ChairChancellor = 1113,
        StatueRobedWoman = 1114,
        ArmchairHighBackOrange = 1115,
        ArmchairHighBackBlue = 1116,
        Bench = 1117,
        BannerWallLizard = 1118,
        Bathtub = 1119,
        BedHighBackBlackGrey = 1120,
        BedHighBackBlue = 1121,
        BedMedicalExam = 1122,
        BookshelfPedestalWhite = 1123,
        CabinetCurvedGreyWhite = 1124,
        BedSideTable = 1125,
        BedLow = 1126,
        BannerStanding = 1127,
        ChairCrewGrey = 1128,
        ChairOpenFrameBrown = 1129,
        ChairPedestalWithArms = 1130,
        ChairPedestalPaddedRed = 1131,
        ChairPedestalPanel = 1132,
        ConsoleFloorMountedBlueScreens = 1133,
        ConsoleFloorMountedGreenScreens = 1134,
        CotWithTable = 1135,
        DeskControlBoardInlay = 1136,
        DeskControlCenter = 1137,
        DeskControlCenterLargeScreen = 1138,
        DeskControlCenterWide = 1139,
        DeskCornerWithTerminal = 1140,
        DeskInformationControlCenter = 1141,
        DeskWallTerminalWide = 1142,
        WorkStationDroidRepair = 1143,
        FootlockerModernKeyedEntry = 1144,
        FountainOval = 1145,
        HoloDisplay = 1146,
        HoloDisplay2 = 1147,
        HoloDisplay4 = 1148,
        HoloDisplay5 = 1149,
        HoloProjector1 = 1150,
        HoloProjector2 = 1151,
        InstrumentPanelLargeMonitorTechnicalData = 1152,
        KoltoTankEmpty = 1153,
        LampEggsPink = 1154,
        LampOnPoles = 1155,
        LanternPostMarble = 1156,
        LockerMetalTrapezoid = 1157,
        MirrorSmall = 1158,
        MonitorWallLogoDisplayBlue = 1159,
        OrnamentSolarSystem = 1160,
        OttomanDecoratedBlack = 1161,
        PipesConduitWithPowerControls = 1162,
        CylinderCrossTop = 1163,
        PotBushClipped = 1164,
        PotBushFlowers = 1165,
        PotBushTall = 1166,
        PotClayUrn = 1167,
        PotFlowerDaisy = 1168,
        PotFlowerYellow = 1169,
        PotLongLeaf1 = 1170,
        PotPlantAloa = 1171,
        PotPlantTropical = 1172,
        PotUrnGrecian = 1173,
        SkeletonMedicalDisplay = 1174,
        ChestTrapezoidWhite = 1175,
        SpaceSuitTan = 1176,
        SpecimenTubeAlien = 1177,
        SpecimenTubeEmpty = 1178,
        SpecimenTubeTall = 1179,
        StatueBustOnColumn = 1180,
        StatueKneelingMan = 1181,
        StatueRobedFigureWithStaff = 1182,
        StatueSenator = 1183,
        StorageTankHemisphereWithMonitor = 1184,
        StuffedToyBantha = 1185,
        TableCoffeeElegantWhite = 1186,
        TableConferenceCentreCloth = 1187,
        TableOvalCentreLegDark = 1188,
        TableOvalLowBlue = 1189,
        TableRoundLowBlue = 1190,
        TableStoneBlue = 1191,
        TableStoneBrown = 1192,
        TableWallOval = 1193,
        ToiletWhiteWithCistern = 1194,
        WallLightCurved = 1195,
        WallLightOctagon = 1196,
        WardrobeCurvedWhite = 1197,
        WashbasinLeverFaucet = 1198,
        WeaponRack = 1190,
        DeskWallTerminal = 1191,
        Cookpot = 1192,
        EngineeringTerminal = 1193,
        FabricationTerminal = 1194,
        Refinery = 1195,
        SmitheryBench = 1196,


        ReinforcedConstructionParts = 1496,
        ReinforcedPowerSupplyUnit = 1497,
        ConstructionParts = 1498,
        PowerSupplyUnit = 1499,
        CityHallStyle1 = 1500,
        BankStyle1 = 1501,
        MedicalCenterStyle1 = 1502,
        StarportStyle1 = 1503,
        CantinaStyle1 = 1504,
        SmallHouseStyle1 = 1505,
        SmallHouseStyle2 = 1506,
        SmallHouseStyle3 = 1507,
        SmallHouseStyle4 = 1508,
        MediumHouseStyle1 = 1509,
        MediumHouseStyle2 = 1510,
        MediumHouseStyle3 = 1511,
        MediumHouseStyle4 = 1512,
        LargeHouseStyle1 = 1513,
        LargeHouseStyle2 = 1514,
        LargeHouseStyle3 = 1515,
        LargeHouseStyle4 = 1516,


        // Cooking: 2001-3000
        MynockMeatBall = 2001,
        WarocasPotPie = 2002,
        SugarCookies = 2003,
        OrangeJuice = 2004,
        PebbleSoup = 2005,
        MynockBroth = 2006,
        Noodles = 2007,
        KathSandwich = 2008,
        KinrathMeatBall = 2009,
        LemonCookies = 2010,
        ViscaranHerbSoup = 2011,
        RedCurry = 2012,
        OrangeAuLait = 2013,
        KathBloodBroth = 2014, 
        GimpassaSandwich = 2015,
        GimpassaStew = 2016,

        RaivorMeatBall = 2017,
        CairnmogPotPie = 2018,
        ChocolateCookies = 2019,
        AppleJuice = 2020,
        PeaSoup = 2021,
        RaivorBroth = 2022,
        SobaNoodles = 2023,
        CairnmogSandwich = 2024,
        NashtahMeatBall = 2025,
        MysteryCookies = 2026,
        MandoHerbSoup = 2027,
        GreenCurry = 2028,
        AppleAuLait = 2029,
        RaivorBloodBroth = 2030,
        NashtahSandwich = 2031,
        NashtahStew = 2032,

        AradileMeatBall = 2033,
        TigerPotPie = 2034,
        AcornCookies = 2035,
        PineappleJuice = 2036,
        VegetableSoup = 2037,
        AradileBroth = 2038,
        RamenNoodles = 2039,
        AradileSandwich = 2040,
        ByyskMeatBall = 2041,
        CinnaCookies = 2042,
        MonCalaHerbSoup = 2043,
        OrangeCurry = 2044,
        PineappleAuLait = 2045,
        AmphiHydrusBloodBroth = 2046,
        SnakeSandwich = 2047,
        SnakeStew = 2048,

        WompRatMeatBall = 2049,
        SandDemonPotPie = 2050,
        GingerCookies = 2051,
        MelonJuice = 2052,
        MushroomSoup = 2053,
        WompRatBroth = 2054, 
        SoyRamen = 2055,
        SurpriseSandwich = 2056,
        TuskenMeatBall = 2057,
        WalnutCookies = 2058,
        DesertHerbSoup = 2059,
        YellowCurry = 2060,
        MelonAuLait = 2061,
        TuskenBloodBroth = 2062,
        SandDemonSandwich = 2063,
        SandDemonStew = 2064,
        WildMeatBall = 2065,
        WildPotPie = 2066,
        WildCookies = 2067,
        TomatoJuice = 2068,
        MisoSoup = 2069,
        WildBroth = 2070,
        MisoRamen = 2071,
        WildSandwich = 2072,
        GrandioseMeatBall = 2073,
        WizardCookies = 2074,
        DathHerbSoup = 2075,
        WildCurry = 2076,
        TomatoAuLait = 2077,
        WildBloodBroth = 2078,
        GrandioseSandwich = 2079,
        WildStew = 2080,
        HssissSurprise = 2081,


        // Engineering: 3001-4000
        BasicCapacitorBooster = 3001,
        BasicCombatLaser = 3002,
        BasicEMAmplifier = 3003,
        BasicThermalAmplifier = 3004,
        BasicExplosiveAmplifier = 3005,
        BasicEvasionBooster = 3006,
        BasicHullBooster = 3007,
        BasicHullRepairer = 3008,
        BasicIonCannon = 3009,
        BasicMiningLaser = 3010,
        BasicMissileLauncher = 3011,
        BasicShieldBooster = 3012,
        BasicShieldRepairer = 3013,
        BasicTargetingSystem = 3014,

        CapacitorBooster1 = 3015,
        CombatLaser1 = 3016,
        EMAmplifier1 = 3017,
        ThermalAmplifier1 = 3018,
        ExplosiveAmplifier1 = 3019,
        EvasionBooster1 = 3020,
        HullBooster1 = 3021,
        HullRepairer1 = 3022,
        IonCannon1 = 3023,
        MiningLaser1 = 3024,
        MissileLauncher1 = 3025,
        ShieldBooster1 = 3026,
        ShieldRepairer1 = 3027,
        TargetingSystem1 = 3028,

        CapacitorBooster2 = 3029,
        CombatLaser2 = 3030,
        EMAmplifier2 = 3031,
        ThermalAmplifier2 = 3032,
        ExplosiveAmplifier2 = 3033,
        EvasionBooster2 = 3034,
        HullBooster2 = 3035,
        HullRepairer2 = 3036,
        IonCannon2 = 3037,
        MiningLaser2 = 3038,
        MissileLauncher2 = 3039,
        ShieldBooster2 = 3040,
        ShieldRepairer2 = 3041,
        TargetingSystem2 = 3042,

        CapacitorBooster3 = 3043,
        CombatLaser3 = 3044,
        EMAmplifier3 = 3045,
        ThermalAmplifier3 = 3046,
        ExplosiveAmplifier3 = 3047,
        EvasionBooster3 = 3048,
        HullBooster3 = 3049,
        HullRepairer3 = 3050,
        IonCannon3 = 3051,
        MiningLaser3 = 3052,
        MissileLauncher3 = 3053,
        ShieldBooster3 = 3054,
        ShieldRepairer3 = 3055,
        TargetingSystem3 = 3056,

        CapacitorBooster4 = 3057,
        CombatLaser4 = 3058,
        EMAmplifier4 = 3059,
        ThermalAmplifier4 = 3060,
        ExplosiveAmplifier4 = 3061,
        EvasionBooster4 = 3062,
        HullBooster4 = 3063,
        HullRepairer4 = 3064,
        IonCannon4 = 3065,
        MiningLaser4 = 3066,
        MissileLauncher4 = 3067,
        ShieldBooster4 = 3068,
        ShieldRepairer4 = 3069,
        TargetingSystem4 = 3070,

        Striker = 3071,
        Condor = 3072,
        Hound = 3073,
        Panther = 3074,
        Saber = 3075,
        Falchion = 3076,
        Mule = 3077,
        Merchant = 3078,
        Throne = 3079,
        Consular = 3080,

        ArmorEnhancementControlSmithery1 = 3081,
        ArmorEnhancementControlEngineering1 = 3082,
        ArmorEnhancementControlFabrication1 = 3083,
        ArmorEnhancementControlAgriculture1 = 3084,
        ArmorEnhancementCraftsmanshipSmithery1 = 3085,
        ArmorEnhancementCraftsmanshipEngineering1 = 3086,
        ArmorEnhancementCraftsmanshipFabrication1 = 3087,
        ArmorEnhancementCraftsmanshipAgriculture1 = 3088,
        ArmorEnhancementDefensePhysical1 = 3089,
        ArmorEnhancementDefenseForce1 = 3090,
        ArmorEnhancementDefensePoison1 = 3091,
        ArmorEnhancementDefenseFire1 = 3092,
        ArmorEnhancementDefenseIce1 = 3093,
        ArmorEnhancementDefenseElectrical1 = 3094,
        ArmorEnhancementEvasion1 = 3095,
        ArmorEnhancementFP1 = 3096,
        ArmorEnhancementHP1 = 3097,
        ArmorEnhancementRecastReduction1 = 3098,
        ArmorEnhancementSTM1 = 3099,
        WeaponEnhancementAttackBonus1 = 3100,
        WeaponEnhancementControlSmithery1 = 3101,
        WeaponEnhancementControlEngineering1 = 3102,
        WeaponEnhancementControlFabrication1 = 3103,
        WeaponEnhancementControlAgriculture1 = 3104,
        WeaponEnhancementCraftsmanshipSmithery1 = 3105,
        WeaponEnhancementCraftsmanshipEngineering1 = 3106,
        WeaponEnhancementCraftsmanshipFabrication1 = 3107,
        WeaponEnhancementCraftsmanshipAgriculture1 = 3108,
        WeaponEnhancementDMGPhysical1 = 3109,
        WeaponEnhancementDMGForce1 = 3110,
        WeaponEnhancementDMGPoison1 = 3111,
        WeaponEnhancementDMGFire1 = 3112,
        WeaponEnhancementDMGIce1 = 3113,
        WeaponEnhancementElectrical1 = 3114,
        WeaponEnhancementEvasion1 = 3115,
        WeaponEnhancementFP1 = 3116,
        WeaponEnhancementHP1 = 3117,
        WeaponEnhancementSTM1 = 3118,
        StructureEnhancementStructureBonus1 = 3119,
        CookingEnhancementDuration1 = 3120,
        CookingEnhancementFP1 = 3121,
        CookingEnhancementFPRegen1 = 3122,
        CookingEnhancementHP1 = 3123,
        CookingEnhancementHPRegen1 = 3124,
        CookingEnhancementRecastReduction1 = 3125,
        CookingEnhancementRestRegen1 = 3126,
        CookingEnhancementSTM1 = 3127,
        CookingEnhancementSTMRegen1 = 3128,
        CookingEnhancementXPBonus1 = 3129,
        StarshipEnhancementAccuracy1 = 3130,
        StarshipEnhancementArmor1 = 3131,
        StarshipEnhancementCapacitor1 = 3132,
        StarshipEnhancementEMDamage1 = 3133,
        StarshipEnhancementEMDefense1 = 3134,
        StarshipEnhancementEvasion1 = 3135,
        StarshipEnhancementExplosiveDamage1 = 3136,
        StarshipEnhancementDefense1 = 3137,
        StarshipEnhancementShield1 = 3138,
        StarshipEnhancementShieldRechargeRate1 = 3139,
        StarshipEnhancementThermalDamage1 = 3140,
        StarshipEnhancementThermalDefense1 = 3141,
        ModuleEnhancementModuleBonus1 = 3142,

        ArmorEnhancementControlSmithery2 = 3143,
        ArmorEnhancementControlEngineering2 = 3144,
        ArmorEnhancementControlFabrication2 = 3145,
        ArmorEnhancementControlAgriculture2 = 3146,
        ArmorEnhancementCraftsmanshipSmithery2 = 3147,
        ArmorEnhancementCraftsmanshipEngineering2 = 3148,
        ArmorEnhancementCraftsmanshipFabrication2 = 3149,
        ArmorEnhancementCraftsmanshipAgriculture2 = 3150,
        ArmorEnhancementDefensePhysical2 = 3151,
        ArmorEnhancementDefenseForce2 = 3152,
        ArmorEnhancementDefensePoison2 = 3153,
        ArmorEnhancementDefenseFire2 = 3154,
        ArmorEnhancementDefenseIce2 = 3155,
        ArmorEnhancementDefenseElectrical2 = 3156,
        ArmorEnhancementEvasion2 = 3157,
        ArmorEnhancementFP2 = 3158,
        ArmorEnhancementHP2 = 3159,
        ArmorEnhancementRecastReduction2 = 3160,
        ArmorEnhancementSTM2 = 3161,
        WeaponEnhancementAttackBonus2 = 3162,
        WeaponEnhancementControlSmithery2 = 3163,
        WeaponEnhancementControlEngineering2 = 3164,
        WeaponEnhancementControlFabrication2 = 3165,
        WeaponEnhancementControlAgriculture2 = 3166,
        WeaponEnhancementCraftsmanshipSmithery2 = 3167,
        WeaponEnhancementCraftsmanshipEngineering2 = 3168,
        WeaponEnhancementCraftsmanshipFabrication2 = 3169,
        WeaponEnhancementCraftsmanshipAgriculture2 = 3170,
        WeaponEnhancementDMGPhysical2 = 3171,
        WeaponEnhancementDMGForce2 = 3172,
        WeaponEnhancementDMGPoison2 = 3173,
        WeaponEnhancementDMGFire2 = 3174,
        WeaponEnhancementDMGIce2 = 3175,
        WeaponEnhancementElectrical2 = 3176,
        WeaponEnhancementEvasion2 = 3177,
        WeaponEnhancementFP2 = 3178,
        WeaponEnhancementHP2 = 3179,
        WeaponEnhancementSTM2 = 3180,
        StructureEnhancementStructureBonus2 = 3181,
        CookingEnhancementDuration2 = 3182,
        CookingEnhancementFP2 = 3183,
        CookingEnhancementFPRegen2 = 3184,
        CookingEnhancementHP2 = 3185,
        CookingEnhancementHPRegen2 = 3186,
        CookingEnhancementRecastReduction2 = 3187,
        CookingEnhancementRestRegen2 = 3188,
        CookingEnhancementSTM2 = 3189,
        CookingEnhancementSTMRegen2 = 3190,
        CookingEnhancementXPBonus2 = 3191,
        StarshipEnhancementAccuracy2 = 3192,
        StarshipEnhancementArmor2 = 3193,
        StarshipEnhancementCapacitor2 = 3194,
        StarshipEnhancementEMDamage2 = 3195,
        StarshipEnhancementEMDefense2 = 3196,
        StarshipEnhancementEvasion2 = 3197,
        StarshipEnhancementExplosiveDamage2 = 3198,
        StarshipEnhancementDefense2 = 3199,
        StarshipEnhancementShield2 = 3200,
        StarshipEnhancementShieldRechargeRate2 = 3201,
        StarshipEnhancementThermalDamage2 = 3202,
        StarshipEnhancementThermalDefense2 = 3203,
        ModuleEnhancementModuleBonus2 = 3204,

        ArmorEnhancementControlSmithery3 = 3205,
        ArmorEnhancementControlEngineering3 = 3206,
        ArmorEnhancementControlFabrication3 = 3207,
        ArmorEnhancementControlAgriculture3 = 3208,
        ArmorEnhancementCraftsmanshipSmithery3 = 3209,
        ArmorEnhancementCraftsmanshipEngineering3 = 3210,
        ArmorEnhancementCraftsmanshipFabrication3 = 3211,
        ArmorEnhancementCraftsmanshipAgriculture3 = 3212,
        ArmorEnhancementDefensePhysical3 = 3213,
        ArmorEnhancementDefenseForce3 = 3214,
        ArmorEnhancementDefensePoison3 = 3215,
        ArmorEnhancementDefenseFire3 = 3216,
        ArmorEnhancementDefenseIce3 = 3217,
        ArmorEnhancementDefenseElectrical3 = 3218,
        ArmorEnhancementEvasion3 = 3219,
        ArmorEnhancementFP3 = 3220,
        ArmorEnhancementHP3 = 3221,
        ArmorEnhancementRecastReduction3 = 3222,
        ArmorEnhancementSTM3 = 3223,
        WeaponEnhancementAttackBonus3 = 3224,
        WeaponEnhancementControlSmithery3 = 3225,
        WeaponEnhancementControlEngineering3 = 3226,
        WeaponEnhancementControlFabrication3 = 3227,
        WeaponEnhancementControlAgriculture3 = 3228,
        WeaponEnhancementCraftsmanshipSmithery3 = 3229,
        WeaponEnhancementCraftsmanshipEngineering3 = 3230,
        WeaponEnhancementCraftsmanshipFabrication3 = 3231,
        WeaponEnhancementCraftsmanshipAgriculture3 = 3232,
        WeaponEnhancementDMGPhysical3 = 3233,
        WeaponEnhancementDMGForce3 = 3234,
        WeaponEnhancementDMGPoison3 = 3235,
        WeaponEnhancementDMGFire3 = 3236,
        WeaponEnhancementDMGIce3 = 3237,
        WeaponEnhancementElectrical3 = 3238,
        WeaponEnhancementEvasion3 = 3239,
        WeaponEnhancementFP3 = 3240,
        WeaponEnhancementHP3 = 3241,
        WeaponEnhancementSTM3 = 3242,
        StructureEnhancementStructureBonus3 = 3243,
        CookingEnhancementDuration3 = 3244,
        CookingEnhancementFP3 = 3245,
        CookingEnhancementFPRegen3 = 3246,
        CookingEnhancementHP3 = 3247,
        CookingEnhancementHPRegen3 = 3248,
        CookingEnhancementRecastReduction3 = 3249,
        CookingEnhancementRestRegen3 = 3250,
        CookingEnhancementSTM3 = 3251,
        CookingEnhancementSTMRegen3 = 3252,
        CookingEnhancementXPBonus3 = 3253,
        StarshipEnhancementAccuracy3 = 3254,
        StarshipEnhancementArmor3 = 3255,
        StarshipEnhancementCapacitor3 = 3256,
        StarshipEnhancementEMDamage3 = 3257,
        StarshipEnhancementEMDefense3 = 3258,
        StarshipEnhancementEvasion3 = 3259,
        StarshipEnhancementExplosiveDamage3 = 3260,
        StarshipEnhancementDefense3 = 3261,
        StarshipEnhancementShield3 = 3262,
        StarshipEnhancementShieldRechargeRate3 = 3263,
        StarshipEnhancementThermalDamage3 = 3264,
        StarshipEnhancementThermalDefense3 = 3265,
        ModuleEnhancementModuleBonus3 = 3266,

        ArmorEnhancementControlSmithery4 = 3267,
        ArmorEnhancementControlEngineering4 = 3268,
        ArmorEnhancementControlFabrication4 = 3269,
        ArmorEnhancementControlAgriculture4 = 3270,
        ArmorEnhancementCraftsmanshipSmithery4 = 3271,
        ArmorEnhancementCraftsmanshipEngineering4 = 3272,
        ArmorEnhancementCraftsmanshipFabrication4 = 3273,
        ArmorEnhancementCraftsmanshipAgriculture4 = 3274,
        ArmorEnhancementDefensePhysical4 = 3275,
        ArmorEnhancementDefenseForce4 = 3276,
        ArmorEnhancementDefensePoison4 = 3277,
        ArmorEnhancementDefenseFire4 = 3278,
        ArmorEnhancementDefenseIce4 = 3279,
        ArmorEnhancementDefenseElectrical4 = 3280,
        ArmorEnhancementEvasion4 = 3281,
        ArmorEnhancementFP4 = 3282,
        ArmorEnhancementHP4 = 3283,
        ArmorEnhancementRecastReduction4 = 3284,
        ArmorEnhancementSTM4 = 3285,
        WeaponEnhancementAttackBonus4 = 3286,
        WeaponEnhancementControlSmithery4 = 3287,
        WeaponEnhancementControlEngineering4 = 3288,
        WeaponEnhancementControlFabrication4 = 3289,
        WeaponEnhancementControlAgriculture4 = 3290,
        WeaponEnhancementCraftsmanshipSmithery4 = 3291,
        WeaponEnhancementCraftsmanshipEngineering4 = 3292,
        WeaponEnhancementCraftsmanshipFabrication4 = 3293,
        WeaponEnhancementCraftsmanshipAgriculture4 = 3294,
        WeaponEnhancementDMGPhysical4 = 3295,
        WeaponEnhancementDMGForce4 = 3296,
        WeaponEnhancementDMGPoison4 = 3297,
        WeaponEnhancementDMGFire4 = 3298,
        WeaponEnhancementDMGIce4 = 3299,
        WeaponEnhancementElectrical4 = 3300,
        WeaponEnhancementEvasion4 = 3301,
        WeaponEnhancementFP4 = 3302,
        WeaponEnhancementHP4 = 3303,
        WeaponEnhancementSTM4 = 3304,
        StructureEnhancementStructureBonus4 = 3305,
        CookingEnhancementDuration4 = 3306,
        CookingEnhancementFP4 = 3307,
        CookingEnhancementFPRegen4 = 3308,
        CookingEnhancementHP4 = 3309,
        CookingEnhancementHPRegen4 = 3310,
        CookingEnhancementRecastReduction4 = 3311,
        CookingEnhancementRestRegen4 = 3312,
        CookingEnhancementSTM4 = 3313,
        CookingEnhancementSTMRegen4 = 3314,
        CookingEnhancementXPBonus4 = 3315,
        StarshipEnhancementAccuracy4 = 3316,
        StarshipEnhancementArmor4 = 3317,
        StarshipEnhancementCapacitor4 = 3318,
        StarshipEnhancementEMDamage4 = 3319,
        StarshipEnhancementEMDefense4 = 3320,
        StarshipEnhancementEvasion4 = 3321,
        StarshipEnhancementExplosiveDamage4 = 3322,
        StarshipEnhancementDefense4 = 3323,
        StarshipEnhancementShield4 = 3323,
        StarshipEnhancementShieldRechargeRate4 = 3324,
        StarshipEnhancementThermalDamage4 = 3325,
        StarshipEnhancementThermalDefense4 = 3326,
        ModuleEnhancementModuleBonus4 = 3327,

        ArmorEnhancementControlSmithery5 = 3328,
        ArmorEnhancementControlEngineering5 = 3329,
        ArmorEnhancementControlFabrication5 = 3330,
        ArmorEnhancementControlAgriculture5 = 3331,
        ArmorEnhancementCraftsmanshipSmithery5 = 3332,
        ArmorEnhancementCraftsmanshipEngineering5 = 3333,
        ArmorEnhancementCraftsmanshipFabrication5 = 3334,
        ArmorEnhancementCraftsmanshipAgriculture5 = 3335,
        ArmorEnhancementDefensePhysical5 = 3336,
        ArmorEnhancementDefenseForce5 = 3337,
        ArmorEnhancementDefensePoison5 = 3338,
        ArmorEnhancementDefenseFire5 = 3339,
        ArmorEnhancementDefenseIce5 = 3340,
        ArmorEnhancementDefenseElectrical5 = 3341,
        ArmorEnhancementEvasion5 = 3342,
        ArmorEnhancementFP5 = 3343,
        ArmorEnhancementHP5 = 3344,
        ArmorEnhancementRecastReduction5 = 3345,
        ArmorEnhancementSTM5 = 3346,
        WeaponEnhancementAttackBonus5 = 3347,
        WeaponEnhancementControlSmithery5 = 3348,
        WeaponEnhancementControlEngineering5 = 3349,
        WeaponEnhancementControlFabrication5 = 3350,
        WeaponEnhancementControlAgriculture5 = 3351,
        WeaponEnhancementCraftsmanshipSmithery5 = 3352,
        WeaponEnhancementCraftsmanshipEngineering5 = 3353,
        WeaponEnhancementCraftsmanshipFabrication5 = 3354,
        WeaponEnhancementCraftsmanshipAgriculture5 = 3355,
        WeaponEnhancementDMGPhysical5 = 3356,
        WeaponEnhancementDMGForce5 = 3357,
        WeaponEnhancementDMGPoison5 = 3358,
        WeaponEnhancementDMGFire5 = 3359,
        WeaponEnhancementDMGIce5 = 3360,
        WeaponEnhancementElectrical5 = 3361,
        WeaponEnhancementEvasion5 = 3362,
        WeaponEnhancementFP5 = 3363,
        WeaponEnhancementHP5 = 3364,
        WeaponEnhancementSTM5 = 3365,
        StructureEnhancementStructureBonus5 = 3366,
        CookingEnhancementDuration5 = 3367,
        CookingEnhancementFP5 = 3368,
        CookingEnhancementFPRegen5 = 3369,
        CookingEnhancementHP5 = 3370,
        CookingEnhancementHPRegen5 = 3371,
        CookingEnhancementRecastReduction5 = 3372,
        CookingEnhancementRestRegen5 = 3373,
        CookingEnhancementSTM5 = 3374,
        CookingEnhancementSTMRegen5 = 3375,
        CookingEnhancementXPBonus5 = 3376,
        StarshipEnhancementAccuracy5 = 3377,
        StarshipEnhancementArmor5 = 3378,
        StarshipEnhancementCapacitor5 = 3379,
        StarshipEnhancementEMDamage5 = 3380,
        StarshipEnhancementEMDefense5 = 3381,
        StarshipEnhancementEvasion5 = 3382,
        StarshipEnhancementExplosiveDamage5 = 3383,
        StarshipEnhancementDefense5 = 3384,
        StarshipEnhancementShield5 = 3385,
        StarshipEnhancementShieldRechargeRate5 = 3386,
        StarshipEnhancementThermalDamage5 = 3387,
        StarshipEnhancementThermalDefense5 = 3388,
        ModuleEnhancementModuleBonus5 = 3389,
    }
}
