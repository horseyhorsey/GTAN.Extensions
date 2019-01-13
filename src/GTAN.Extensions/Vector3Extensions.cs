using GTANetworkAPI;

namespace GTAN.Extensions
{
    public static class Vector3Extensions
    {
        /// <summary>
        /// Converts a Vector3 string to <see cref="RAGE.Vector3"/>. "0 0 0.5";
        /// </summary>
        /// <param name="vector3"></param>
        /// <param name="vector3String"></param>
        /// <returns></returns>
        public static GTANetworkAPI.Vector3 ConvertToVector3(this Vector3 vector3, string vector3String)
        {
            if (string.IsNullOrEmpty(vector3String)) return new GTANetworkAPI.Vector3();

            //Clean string from Game and get vector vals split
            string vStr = vector3String.Replace(@"\0", "").Replace(@"/0", "").Trim();
            string[] v3s = vStr.Split(' ');

            return
                new GTANetworkAPI
                .Vector3(
                    float.Parse(v3s[0]),
                    float.Parse(v3s[1]),
                    float.Parse(v3s[2]));
        }
    }
}
