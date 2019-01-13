using GTAN.Data;
using GTANetworkMethods;
using System.Collections.Generic;

namespace GTAN.Extensions
{
    public static class PoolsExtensions
    {
        /// <summary>
        /// Store loaded IPLS from extensions
        /// </summary>
        /// <remarks>
        /// Unsure where these are tracked in API or know whether they are skipped if asked to load multiple times
        /// </remarks>
        internal static List<Interior> LoadedIpls { get; set; }
        internal static List<MultiInterior> LoadedMultiIpls { get; set; }

        public static List<Interior> GetLoadedIpls(this Pools pools)
        {
            return LoadedIpls;
        }

        static PoolsExtensions()
        {
            LoadedIpls = new List<Interior>();
            LoadedMultiIpls = new List<MultiInterior>();
        }
    }
}
