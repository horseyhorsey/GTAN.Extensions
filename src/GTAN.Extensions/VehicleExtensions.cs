using GTAN.Data;
using System.Collections.Generic;

namespace GTAN.Extensions
{
    public static class VehicleExtensions
    {
        
        //public static  void CreateVehicle(GTANetworkMethods.Vehicle vehicle)
        //{
            
        //}
            /// <summary>
        /// Gets a hash for the vehicle model from its string name from new list
        /// </summary>
        /// <param name="vehicle"></param>
        /// <param name="vehicleName"></param>
        /// <returns></returns>
        public static uint GetModel(this GTANetworkMethods.Vehicle vehicle, string vehicleName)
        {
            var allVehicles = GetVehicleHashes(vehicle, VehicleType.All);
            if (allVehicles.ContainsKey(vehicleName))
                return allVehicles[vehicleName];
            else
                return 0;
        }

        public static IReadOnlyDictionary<string, uint> GetVehicleHashes(this GTANetworkMethods.Vehicle vehicle, 
            VehicleType vehicleType)
        {
            var allVehicles = new Dictionary<string, uint>();
            var vDict = typeof(VehicleDicts);

            //Return all vehicles
            if (vehicleType.HasFlag(VehicleType.All))
            {                
                foreach (var dict in vDict.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static))
                {
                    var entries = dict.GetValue(dict) as IReadOnlyDictionary<string, uint>;
                    if (entries?.Count > 0)
                    {
                        foreach (var vehicleHash in entries)
                        {
                            allVehicles.Add(vehicleHash.Key, vehicleHash.Value);
                        }
                    }
                }
                return allVehicles;
            }

            //Get vehicles from given enum types
            var types = vehicleType.ToString().Split(',');
            foreach (var type in types)
            {                
                var prop = vDict.GetProperty(type.Trim());
                var dict = prop.GetValue(prop) as IReadOnlyDictionary<string, uint>;
                if (dict?.Count > 0)
                {
                    foreach (var vHash in dict)
                    {
                        allVehicles.Add(vHash.Key, vHash.Value);
                    }
                }
            }
            return allVehicles;
        }
    }
}
