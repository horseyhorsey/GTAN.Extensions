using GTANetworkAPI;

namespace GTAN.Data
{
    public class Interior
    {
        public string Name { get; }
        public string IplName { get; }
        public Vector3 Position { get; set; }
        public InteriorLocation Location { get; }
        public InteriorType Type { get; }

        public Interior(string ipl, Vector3 vector3, InteriorLocation location, InteriorType type)
        {
            IplName = ipl;
            Position = vector3;
            Location = location;
            Type = type;
        }
    }

    public class MultiInterior
    {
        public string[] Ipls { get; set; }
        public Vector3 Position { get; set; }
    }

    public enum InteriorLocation
    {
        Apartments,
        ArcadiusBusinessCentre,
        Bunkers,
        CharCreator,
        ClubWareHouse,
        Garages,
        LomBank,
        MazeBank,
        MazeBankWest,
        Mission,
        OnlineBunkers,
        OnlineApartments,       
        Special,
        ArenaWar,
    }

    public enum InteriorType
    {
        Apartment,
        Bank,
        Bunker,
        CargoShip,
        FIB,
        Office,
        RedCarpet,
        Stilthouse,
        Store,
        Trevor,
        Stadium,
        Clubhouse,
        Warehouse,
        CompanyWarehouse,
        DLCGarage,
        Garage,
        Character,
        Misc,
        Arena,
    }
}
