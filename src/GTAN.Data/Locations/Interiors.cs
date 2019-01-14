using GTANetworkAPI;
using System.Collections.Generic;

namespace GTAN.Data
{
    public static class Interiors
    {
        /// <summary>
        /// Standard IPL
        /// </summary>
        public static readonly Dictionary<string, Interior> InteriorsIPL = new Dictionary<string, Interior>()
            {
                {"Normal Cargo Ship", new Interior("cargoship", new Vector3(-163.3628, -2385.161, 5.999994), InteriorLocation.Special, InteriorType.CargoShip)},
                {"Sunken Cargo Ship", new Interior("sunkcargoship", new Vector3(-163.3628, -2385.161, 5.999994), InteriorLocation.Special, InteriorType.CargoShip)},
                {"Burning Cargo Ship", new Interior("SUNK_SHIP_FIRE", new Vector3(-163.3628, -2385.161, 5.999994), InteriorLocation.Special, InteriorType.CargoShip)},
                {"Red Carpet", new Interior("redCarpet", new Vector3(300.5927, 300.5927, 104.3776), InteriorLocation.Special, InteriorType.RedCarpet)},
                {"Rekt Stilthouse Destroyed ", new Interior("DES_StiltHouse_imapend", new Vector3(-1020.518, 663.27, 153.5167), InteriorLocation.Special, InteriorType.Stilthouse)},
                {"Rekt Stilthouse Rebuild", new Interior("DES_stilthouse_rebuild", new Vector3(-1020.518, 663.27, 153.5167), InteriorLocation.Special, InteriorType.Stilthouse)},
                {"Union Depository", new Interior("FINBANK", new Vector3(2.6968, -667.0166, 16.13061), InteriorLocation.Special, InteriorType.Bank)},
                {"Trevors Trailer Dirty", new Interior("TrevorsMP", new Vector3(1975.552, 3820.538, 33.44833), InteriorLocation.Special, InteriorType.Trevor)},
                {"Trevors Trailer Clean", new Interior("TrevorsTrailerTidy", new Vector3(1975.552, 3820.538, 33.44833), InteriorLocation.Special, InteriorType.Trevor)},
                {"Stadium", new Interior("SP1_10_real_interior", new Vector3(-248.6731, -2010.603, 30.14562), InteriorLocation.Special, InteriorType.Stadium)},
                {"Max Renda Shop", new Interior("refit_unload", new Vector3(-585.8247, -282.72, 35.45475), InteriorLocation.Special, InteriorType.Store)},
                {"Jewel Store", new Interior("post_hiest_unload", new Vector3(-630.07, -236.332, 38.05704), InteriorLocation.Special, InteriorType.Store)},
                {"FIB Lobby", new Interior("FIBlobby", new Vector3(110.4, -744.2, 45.7496), InteriorLocation.Special, InteriorType.FIB)},
                {"Executive Rich", new Interior("ex_dt1_02_office_02b", new Vector3(-141.1987, -620.913, 168.8205), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Executive Cool", new Interior("ex_dt1_02_office_02c", new Vector3(-141.5429, -620.9524, 168.8204), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Executive Contrast", new Interior("ex_dt1_02_office_02a", new Vector3(-141.2896, -620.9618, 168.8204), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Old Spice Warm", new Interior("ex_dt1_02_office_01a", new Vector3(-141.4966, -620.8292, 168.8204), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Old Spice Classical", new Interior("ex_dt1_02_office_01b", new Vector3(-141.3997, -620.9006, 168.8204), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Old Spice Vintage", new Interior("ex_dt1_02_office_01c", new Vector3(-141.5361, -620.9186, 168.8204), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Power Broker Ice", new Interior("ex_dt1_02_office_03a", new Vector3(-141.392, -621.0451, 168.8204), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Power Broker Conservative", new Interior("ex_dt1_02_office_03b", new Vector3(-141.1945, -620.8729, 168.8204), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Power Broker Polished", new Interior("ex_dt1_02_office_03c", new Vector3(-141.4924, -621.0035, 168.8205), InteriorLocation.ArcadiusBusinessCentre, InteriorType.Office)},
                {"Modern 1 Apartment", new Interior("apa_v_mp_h_01_a", new Vector3(-786.8663, 315.7642, 217.6385), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Modern 2 Apartment", new Interior("apa_v_mp_h_01_c", new Vector3(-786.9563, 315.6229, 187.9136), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Modern 3 Apartment", new Interior("apa_v_mp_h_01_b", new Vector3(-774.0126, 342.0428, 196.6864), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Mody 1 Apartment", new Interior("apa_v_mp_h_02_a", new Vector3(-787.0749, 315.8198, 217.6386), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Mody 2 Apartment", new Interior("apa_v_mp_h_02_c", new Vector3(-786.8195, 315.5634, 187.9137), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Mody 3 Apartment", new Interior("apa_v_mp_h_02_b", new Vector3(-774.1382, 342.0316, 196.6864), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Vibrant 1 Apartment", new Interior("apa_v_mp_h_03_a", new Vector3(-786.6245, 315.6175, 217.6385), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Vibrant 2 Apartment", new Interior("apa_v_mp_h_03_c", new Vector3(-786.9584, 315.7974, 187.9135), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Vibrant 3 Apartment", new Interior("apa_v_mp_h_03_b", new Vector3(-774.0223, 342.1718, 196.6863), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Sharp 1 Apartment", new Interior("apa_v_mp_h_04_a", new Vector3(-787.0902, 315.7039, 217.6384), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Sharp 2 Apartment", new Interior("apa_v_mp_h_04_c", new Vector3(-787.0155, 315.7071, 187.9135), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Sharp 3 Apartment", new Interior("apa_v_mp_h_04_b", new Vector3(-773.8976, 342.1525, 196.6863), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Monochrome 1 Apartment", new Interior("apa_v_mp_h_05_a", new Vector3(-786.9887, 315.7393, 217.6386), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Monochrome 2 Apartment", new Interior("apa_v_mp_h_05_c", new Vector3(-786.8809, 315.6634, 187.9136), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Monochrome 3 Apartment", new Interior("apa_v_mp_h_05_b", new Vector3(-774.0675, 342.0773, 196.6864), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Seductive 1 Apartment", new Interior("apa_v_mp_h_06_a", new Vector3(-787.1423, 315.6943, 217.6384), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Seductive 2 Apartment", new Interior("apa_v_mp_h_06_c", new Vector3(-787.0961, 315.815, 187.9135), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Seductive 3 Apartment", new Interior("apa_v_mp_h_06_b", new Vector3(-773.9552, 341.9892, 196.6862), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Regal 1 Apartment", new Interior("apa_v_mp_h_07_a", new Vector3(-787.029, 315.7113, 217.6385), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Regal 2 Apartment", new Interior("apa_v_mp_h_07_c", new Vector3(-787.0574, 315.6567, 187.9135), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Regal 3 Apartment", new Interior("apa_v_mp_h_07_b", new Vector3(-774.0109, 342.0965, 196.6863), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Aqua 1 Apartment", new Interior("apa_v_mp_h_08_a", new Vector3(-786.9469, 315.5655, 217.6383), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Aqua 2 Apartment", new Interior("apa_v_mp_h_08_c", new Vector3(-786.9756, 315.723, 187.9134), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"Aqua 3 Apartment", new Interior("apa_v_mp_h_08_b", new Vector3(-774.0349, 342.0296, 196.6862), InteriorLocation.OnlineApartments, InteriorType.Apartment)},
                {"DesertBunker", new Interior("gr_case0_bunkerclosed", new Vector3(848.6175, 2996.567, 45.81612), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"FarmhouseBunker", new Interior("gr_case6_bunkerclosed  ", new Vector3(1570.372, 2254.549, 78.89397), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"GrapeseedBunker", new Interior("gr_case5_bunkerclosed  ", new Vector3(1823.961, 4708.14, 42.4991), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"OilfieldsBunker", new Interior("gr_case3_bunkerclosed", new Vector3(481.0465, 2995.135, 43.96672), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"PalletoBunker", new Interior("gr_case7_bunkerclosed  ", new Vector3(-783.0755, 5934.686, 24.31475), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"RatonCanyonBunker", new Interior("gr_case4_bunkerclosed  ", new Vector3(-391.3216, 4363.728, 58.65862), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"Route1Bunker", new Interior("gr_case11_bunkerclosed ", new Vector3(-3180.466, 1374.192, 19.9597), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"Route68Bunker ", new Interior("gr_case9_bunkerclosed", new Vector3(24.43542, 2959.705, 58.35517), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"ScrapyardBunker", new Interior("gr_case2_bunkerclosed  ", new Vector3(2493.654, 3140.399, 51.28789), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"SmokeTreeBunker", new Interior("gr_case1_bunkerclosed", new Vector3(2126.785, 3335.04, 48.21422), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"ZancudoBunker", new Interior("gr_case10_bunkerclosed", new Vector3(-3058.714, 3329.19, 12.5844), InteriorLocation.OnlineBunkers, InteriorType.Bunker)},
                {"Clubhouse 1",new Interior("bkr_biker_interior_placement_interior_0_biker_dlc_int_01_milo",new Vector3(1107.04, -3157.399, -37.51859), InteriorLocation.ClubWareHouse, InteriorType.Clubhouse)},
                {"Clubhouse 2",new Interior("bkr_biker_interior_placement_interior_1_biker_dlc_int_02_milo",new Vector3(998.4809, -3164.711, -38.90733), InteriorLocation.ClubWareHouse, InteriorType.Clubhouse)},
                {"Warehouse 1",new Interior("bkr_biker_interior_placement_interior_2_biker_dlc_int_ware01_milo",new Vector3(1009.5, -3196.6, -38.99682), InteriorLocation.ClubWareHouse, InteriorType.Warehouse)},
                {"Warehouse 2",new Interior("bkr_biker_interior_placement_interior_3_biker_dlc_int_ware02_milo",new Vector3(1051.491, -3196.536, -39.14842), InteriorLocation.ClubWareHouse, InteriorType.Warehouse)},
                {"Warehouse 3",new Interior("bkr_biker_interior_placement_interior_4_biker_dlc_int_ware03_milo",new Vector3(1093.6, -3196.6, -38.99841), InteriorLocation.ClubWareHouse, InteriorType.Warehouse)},
                {"Warehouse 4",new Interior("bkr_biker_interior_placement_interior_5_biker_dlc_int_ware04_milo",new Vector3(1121.897, -3195.338, -40.4025), InteriorLocation.ClubWareHouse, InteriorType.Warehouse)},
                {"Warehouse 5",new Interior("bkr_biker_interior_placement_interior_6_biker_dlc_int_ware05_milo",new Vector3(1165, -3196.6, -39.01306), InteriorLocation.ClubWareHouse, InteriorType.Warehouse)},
                {"Warehouse Small",new Interior("ex_exec_warehouse_placement_interior_1_int_warehouse_s_dlc_milo",new Vector3(1094.988, -3101.776, -39.00363), InteriorLocation.ClubWareHouse, InteriorType.CompanyWarehouse)},
                {"Warehouse Medium",new Interior("ex_exec_warehouse_placement_interior_0_int_warehouse_m_dlc_milo",new Vector3(1056.486, -3105.724, -39.00439), InteriorLocation.ClubWareHouse, InteriorType.CompanyWarehouse)},
                {"Warehouse Large",new Interior("ex_exec_warehouse_placement_interior_2_int_warehouse_l_dlc_milo",new Vector3(1006.967, -3102.079, -39.0035), InteriorLocation.ClubWareHouse, InteriorType.CompanyWarehouse)},
                {"Cargarage",new Interior("imp_impexp_interior_placement_interior_1_impexp_intwaremed_milo_",new Vector3(994.5925, -3002.594, -39.64699), InteriorLocation.ClubWareHouse, InteriorType.DLCGarage)},
                {"Executive Rich2", new Interior("ex_dt1_11_office_02b",  new Vector3(-75.8466, -826.9893, 243.3859), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Executive Cool2", new Interior("ex_dt1_11_office_02c",  new Vector3(-75.49945, -827.05, 243.386), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Executive Contrast2", new Interior("ex_dt1_11_office_02a",  new Vector3(-75.49827, -827.1889, 243.386), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Old Spice Warm2", new Interior("ex_dt1_11_office_01a",  new Vector3(-75.44054, -827.1487, 243.3859), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Old Spice Classical2", new Interior("ex_dt1_11_office_01b",  new Vector3(-75.63942, -827.1022, 243.3859), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Old Spice Vintage2", new Interior("ex_dt1_11_office_01c",  new Vector3(-75.47446, -827.2621, 243.386), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Power Broker Ice2", new Interior("ex_dt1_11_office_03a",  new Vector3(-75.56978, -827.1152, 243.3859), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Power Broker Conservative2", new Interior("ex_dt1_11_office_03b",  new Vector3(-75.51953, -827.0786, 243.3859), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Power Broker Polished2", new Interior("ex_dt1_11_office_03c",  new Vector3(-75.41915, -827.1118, 243.3858), InteriorLocation.MazeBank, InteriorType.Office)},
                {"Executive Rich3", new Interior("ex_sm_13_office_02b",  new Vector3(-1579.756, -565.0661, 108.523), InteriorLocation.LomBank, InteriorType.Office)},
                {"Executive Cool3", new Interior("ex_sm_13_office_02c",  new Vector3(-1579.678, -565.0034, 108.5229), InteriorLocation.LomBank, InteriorType.Office)},
                {"Executive Contrast3", new Interior("ex_sm_13_office_02a",  new Vector3(-1579.583, -565.0399, 108.5229), InteriorLocation.LomBank, InteriorType.Office)},
                {"Old Spice Warm3", new Interior("ex_sm_13_office_01a",  new Vector3(-1579.702, -565.0366, 108.5229), InteriorLocation.LomBank, InteriorType.Office)},
                {"Old Spice Classical3", new Interior("ex_sm_13_office_01b",  new Vector3(-1579.643, -564.9685, 108.5229), InteriorLocation.LomBank, InteriorType.Office)},
                {"Old Spice Vintage3", new Interior("ex_sm_13_office_01c",  new Vector3(-1579.681, -565.0003, 108.523), InteriorLocation.LomBank, InteriorType.Office)},
                {"Power Broker Ice3", new Interior("ex_sm_13_office_03a",  new Vector3(-1579.677, -565.0689, 108.5229), InteriorLocation.LomBank, InteriorType.Office)},
                {"Power Broker Conservative3", new Interior("ex_sm_13_office_03b",  new Vector3(-1579.708, -564.9634, 108.5229), InteriorLocation.LomBank, InteriorType.Office)},
                {"Power Broker Polished3", new Interior("ex_sm_13_office_03c",  new Vector3(-1579.693, -564.8981, 108.5229), InteriorLocation.LomBank, InteriorType.Office)},
                {"Executive Rich4", new Interior("ex_sm_15_office_02b",  new Vector3(-1392.667, -480.4736, 72.04217), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"Executive Cool4", new Interior("ex_sm_15_office_02c",  new Vector3(-1392.542, -480.4011, 72.04211), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"Executive Contrast4", new Interior("ex_sm_15_office_02a",  new Vector3(-1392.626, -480.4856, 72.04212), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"Old Spice Warm4", new Interior("ex_sm_15_office_01a",  new Vector3(-1392.617, -480.6363, 72.04208), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"Old Spice Classical4", new Interior("ex_sm_15_office_01b",  new Vector3(-1392.532, -480.7649, 72.04207), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"Old Spice Vintage4", new Interior("ex_sm_15_office_01c",  new Vector3(-1392.611, -480.5562, 72.04214), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"Power Broker Ice4", new Interior("ex_sm_15_office_03a",  new Vector3(-1392.563, -480.549, 72.0421), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"Power Broker Convservative4", new Interior("ex_sm_15_office_03b",  new Vector3(-1392.528, -480.475, 72.04206), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"Power Broker Polished4", new Interior("ex_sm_15_office_03c",  new Vector3(-1392.416, -480.7485, 72.04207), InteriorLocation.MazeBankWest, InteriorType.Office)},
                {"XS Arena", new Interior("xs_arena_interior",  new Vector3(2800.000, -3800.000, 100.000), InteriorLocation.ArenaWar, InteriorType.Arena)},
                {"XS Arena Mod", new Interior("xs_arena_interior_mod",  new Vector3(205.000, 5180.000, -90.000), InteriorLocation.ArenaWar, InteriorType.Arena)},
                {"XS Arena Mod 2", new Interior("xs_arena_interior_mod_2",  new Vector3(205.000, 5180.000, -90.000), InteriorLocation.ArenaWar, InteriorType.Arena)},
                {"XS Arena VIP", new Interior("xs_arena_interior_vip",  new Vector3(2799.529, -3930.539, 184.000), InteriorLocation.ArenaWar, InteriorType.Arena)},
               
            };

        /// <summary>
        /// No iplName specified for these
        /// </summary>
        public static readonly Dictionary<string, Interior> InteriorsNoIPL = new Dictionary<string, Interior>()
            {
                {"Low End Apartment" , new Interior(null, new Vector3(261.4586, -998.8196, -99.00863), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"4 Integrity Way, Apt 28", new Interior(null,new Vector3(-18.07856, -583.6725, 79.46569), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"4 Integrity Way, Apt 30", new Interior(null,new Vector3(-35.31277, -580.4199, 88.71221), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"Dell Perro Heights, Apt 4", new Interior(null,new Vector3(-1468.14, -541.815, 73.4442), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"Dell Perro Heights, Apt 7", new Interior(null, new Vector3(-1477.14, -538.7499, 55.5264), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"Richard Majestic, Apt 2", new Interior(null,    new Vector3(-915.811, -379.432, 113.6748), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"Tinsel Towers, Apt 42", new Interior(null,       new Vector3(-614.86, 40.6783, 97.60007), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"EclipseTowers, Apt 3", new Interior(null,        new Vector3(-773.407, 341.766, 211.397), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"3655 Wild Oats Drive", new Interior(null,        new Vector3(-169.286, 486.4938, 137.4436), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"2044 North Conker Avenue", new Interior(null,     new Vector3(340.9412, 437.1798, 149.3925), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"2045 North Conker Avenue", new Interior(null,      new Vector3(373.023, 416.105, 145.7006), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"2862 Hillcrest Avenue", new Interior(null,        new Vector3(-676.127, 588.612, 145.1698), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"2868 Hillcrest Avenue", new Interior(null,       new Vector3(-763.107, 615.906, 144.1401), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"2874 Hillcrest Avenue", new Interior(null,     new Vector3(-857.798, 682.563, 152.6529), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"2677 Whispymound Drive", new Interior(null,   new Vector3(120.5, 549.952, 184.097), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"2133 Mad Wayne Thunder", new Interior(null, new Vector3(-1288, 440.748, 97.69459), InteriorLocation.Apartments, InteriorType.Apartment)},
                {"2 Car",   new Interior(null, new Vector3(173.2903, -1003.6, -99.65707),InteriorLocation.Garages, InteriorType.Garage)},
                {"6 Car",   new Interior(null, new Vector3(197.8153, -1002.293, -99.65749),InteriorLocation.Garages, InteriorType.Garage)},
                {"10 Car",  new Interior(null, new Vector3(229.9559, -981.7928, -99.66071),InteriorLocation.Garages, InteriorType.Garage)},


                {"Bunker Interior", new Interior(null, new Vector3(899.5518,-3246.038, -98.04907), InteriorLocation.Bunkers, InteriorType.Bunker)},
                {"CharCreator", new Interior(null, new Vector3(402.5164, -1002.847, -99.2587), InteriorLocation.CharCreator, InteriorType.Misc)},
                {"Mission Carpark", new Interior(null, new Vector3(405.9228, -954.1149, -99.6627), InteriorLocation.Mission, InteriorType.Misc)},
                {"Torture Room", new Interior(null, new Vector3(136.5146, -2203.149, 7.30914), InteriorLocation.Special, InteriorType.Misc)},
                {"Solomon's Office", new Interior(null, new Vector3(-1005.84, -478.92, 50.02733), InteriorLocation.Special, InteriorType.Misc)},
                {"Psychiatrist's Office", new Interior(null, new Vector3(-1908.024, -573.4244, 19.09722), InteriorLocation.Special, InteriorType.Misc)},
                {"Omega's Garage", new Interior(null, new Vector3(2331.344, 2574.073, 46.68137), InteriorLocation.Special, InteriorType.Garage)},
                {"Movie Theatre", new Interior(null, new Vector3(-1427.299, -245.1012, 16.8039), InteriorLocation.Apartments, InteriorType.Misc)},
                {"Motel", new Interior(null, new Vector3(152.2605, -1004.471, -98.99999), InteriorLocation.Special, InteriorType.Misc)},
                {"Mandrazos Ranch", new Interior(null, new Vector3(152.2605, 1146.954, 114.337), InteriorLocation.Special, InteriorType.Misc)},
                {"Life Invader Office", new Interior(null, new Vector3(-1044.193, -236.9535, 37.96496), InteriorLocation.Special, InteriorType.Misc)},
                {"Lester's House", new Interior(null, new Vector3(1273.9, -1719.305, 54.77141), InteriorLocation.Special, InteriorType.Misc)},
                {"FBI Top Floor", new Interior(null, new Vector3(134.5835, -749.339, 258.152), InteriorLocation.Special, InteriorType.FIB)},
                {"FBI Floor 47", new Interior(null, new Vector3(134.5835, -766.486, 234.152), InteriorLocation.Special, InteriorType.FIB)},
                {"FBI Floor 49", new Interior(null, new Vector3(134.635, -765.831, 242.152), InteriorLocation.Special, InteriorType.FIB)},
                {"IAA Office", new Interior(null, new Vector3(117.22, -620.938, 206.1398), InteriorLocation.Special, InteriorType.Misc)},
            };

        /// <summary>
        /// These IPL have multiple
        /// </summary>
        public static readonly Dictionary<string, MultiInterior> InteriorsMulti = new Dictionary<string, MultiInterior>()
            {
                {"Gunrunning Heist Yacht", new MultiInterior{
                    Position = new Vector3(-1418.21000000, 6749.81000000, 10.98968000),
                    Ipls = new string[] {
                        "gr_heist_yacht2",
                        "gr_heist_yacht2_bar",
                        "gr_heist_yacht2_bedrm",
                        "gr_heist_yacht2_bridge",
                        "gr_heist_yacht2_enginrm",
                        "gr_heist_yacht2_lounge",
                    }
}
                },
                {"Dignity Heist Yacht", new MultiInterior{
                    Position = new Vector3(-2027.946, -1036.695, 6.707587),
                    Ipls = new string[] {
                        "smboat",
                        "smboat_lod",
                        "hei_yacht_heist",
                        "hei_yacht_heist_enginrm",
                        "hei_yacht_heist_Lounge",
                        "hei_yacht_heist_Bridge",
                        "hei_yacht_heist_Bar",
                        "hei_yacht_heist_Bedrm",
                        "hei_yacht_heist_DistantLights",
                        "hei_yacht_heist_LODLights",
                    }}
                },
                  {"Dignity Party Yacht", new MultiInterior{
                    Position = new Vector3(-2023.643, -1038.119, 5.576781),
                    Ipls = new string[] {
                        "smboat",
                        "smboat_lod",
                        "hei_yacht_heist",
                        "hei_yacht_heist_enginrm",
                        "hei_yacht_heist_Lounge",
                        "hei_yacht_heist_Bridge",
                        "hei_yacht_heist_Bar",
                        "hei_yacht_heist_Bedrm",
                        "hei_yacht_heist_DistantLights",
                        "hei_yacht_heist_LODLights",
                    }}
                },
                  {"Aircraft Carrier", new MultiInterior{
                    Position = new Vector3(3084.73, -4770.709, 15.26167),
                    Ipls = new string[] {
                        "hei_carrier",
                        "hei_carrier_DistantLights",
                        "hei_Carrier_int1",
                        "hei_Carrier_int2",
                        "hei_Carrier_int3",
                        "hei_Carrier_int4",
                        "hei_Carrier_int5",
                        "hei_Carrier_int6",
                        "hei_carrier_LODLights",
                    }}
                },
                   {"Bridge Train Normal", new MultiInterior{
                    Position =  new Vector3(532.1309, 4526.187, 89.79387),
                    Ipls = new string[] {
                         "canyonriver01",
                            "railing_start",
                    }} },
                    {"Bridge Train Crash", new MultiInterior{
                    Position =  new Vector3(532.1309, 4526.187, 89.79387),
                    Ipls = new string[] {
                        "canyonriver01_traincrash",
                        "railing_end"}}
                    },
                    {"North Yankton", new MultiInterior{
                    Position =  new Vector3(3217.697, -4834.826, 111.8152),
                    Ipls = new string[] {
                        "prologue01",
                        "prologue01c",
                        "prologue01d",
                        "prologue01e",
                        "prologue01f",
                        "prologue01g",
                        "prologue01h",
                        "prologue01i",
                        "prologue01j",
                        "prologue01k",
                        "prologue01z",
                        "prologue02",
                        "prologue03",
                        "prologue03b",
                        "prologue03_grv_dug",
                        "prologue_grv_torch",
                        "prologue04",
                        "prologue04b",
                        "prologue04_cover",
                        "des_protree_end",
                        "des_protree_start",
                        "prologue05",
                        "prologue05b",
                        "prologue06",
                        "prologue06b",
                        "prologue06_int",
                        "prologue06_pannel",
                        "plg_occl_00",
                        "prologue_occl",
                        "prologuerd",
                        "prologuerdb"
                    }
                    }
                }
            };
    }
}
