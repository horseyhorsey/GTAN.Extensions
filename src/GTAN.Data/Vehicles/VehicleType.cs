using System;

namespace GTAN.Data
{
    [Flags]
    public enum VehicleType
    {
        None                        = 0,
        Bicycle                     = 1 << 0,
        Boat                        = 1 << 1,
        Commercial                  = 1 << 2,
        Compact                     = 1 << 4,
        Coupe                       = 1 << 4,
        EmergencyAirSea             = 1 << 5,
        EmergencyCar                = 1 << 6,
        EmergencyTruck              = 1 << 7,
        Helicopter                  = 1 << 8,
        Industrial                  = 1 << 9,
        Military                    = 1 << 10,
        Motorcycle                  = 1 << 11,
        Muscle                      = 1 << 12,
        OffRoad                     = 1 << 13,
        Plane                       = 1 << 14,
        Sedan                       = 1 << 15,
        Service                     = 1 << 16,
        Sport                       = 1 << 17,
        SportClassic                = 1 << 18,
        Super                       = 1 << 19,
        Suv                         = 1 << 20,
        Trailer                     = 1 << 21,
        Train                       = 1 << 22,
        Utility                     = 1 << 23,
        Van                         = 1 << 24,
        All                         = 1 << 25,
    }
}
