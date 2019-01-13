using GTANetworkAPI;
using System;
using System.Collections.Generic;

namespace GTAN.Data
{
    public class Houses : Dictionary<int, Vector3> { }

    public static class GtaHouses
    {
        #region Fields
        private static Random Random; 
        #endregion

        #region House Dictionaries
        public static readonly Houses VespucciHouses = new Houses()
        {
            {1, new Vector3(-1098.678, -1678.947, 3.360237) },
            {2, new Vector3(-1097.881, -1673.301, 7.235308)},
            {3, new Vector3(-1089.393, -1680.632, 4.544619)},
            {4, new Vector3(-1058.981, -1656.876, 4.755157)},
            {5, new Vector3(-1060.428, -1658.272, 4.755158)},
            {6, new Vector3(-1057.98, -1642.819, 4.257308)},
            {7, new Vector3(-1062.799, -1641.308, 4.134467)},
            {8, new Vector3(-1071.489, -1636.303, 7.83428)},
            {9, new Vector3(-1077.011, -1620.929, 4.264339)},
            {10, new Vector3(-1078.387, -1616.212, 4.080819)},
            {12, new Vector3(-1093.159, -1607.945, 8.239926)},
            {13, new Vector3(-1105.918, -1596.712, 4.608509)},
            {14, new Vector3(-1114.363, -1579.142, 8.0978) },
            {15, new Vector3(-1112.479, -1577.978, 8.0978)},
            {16, new Vector3(-1115.063, -1577.531, 4.187236)},
            {17, new Vector3(-1134.704, -1569.006, 4.150815)},
            {18, new Vector3(-1084.804, -1558.785, 4.33391)},
            {19, new Vector3(-1077.397, -1553.588, 4.273998)},
            {20, new Vector3(-1066.253, -1545.153, 4.664191)},
            {21, new Vector3(-1058.182, -1540.527, 4.679056)},
            {22, new Vector3(-1057.306, -1551.451, 4.609193)},
            {23, new Vector3(-1043.83, -1579.963, 4.742518) },
            {24, new Vector3(-1048.876, -1580.604, 4.824526)},
            {25, new Vector3(-1064.182, -1558.294, 5.077002)},
            {26, new Vector3(-1072.04, -1565.365, 4.151701)},
            {27, new Vector3(-1065.287, -1586.26, 4.090513)},
            {28, new Vector3(-1041.281, -1590.9, 4.702326)},
            {29, new Vector3(-1038.849, -1610.008, 4.625661)},
            {30, new Vector3(-1031.879, -1620.313, 4.917753)},
            {31, new Vector3(-1023.108, -1614.726, 4.429368)},
            {32, new Vector3(-975.3867, -1580.878, 4.969452)},
            {33, new Vector3(-970.3228, -1579.071, 4.95669)},
            {34, new Vector3(-940.891, -1568.14, 4.807979)},
            {35, new Vector3(-957.6898, -1567.256, 5.069029)},
            {36, new Vector3(-965.1651, -1564.413, 4.861174)},
            {37, new Vector3(-952.1655, -1552.61, 4.859365)},
            {38, new Vector3(-947.4615, -1550.889, 5.026759)},
            {39, new Vector3(-933.6942, -1555.889, 4.709573)},
            {40, new Vector3(-922.116, -1527.981, 4.809114)},
            {41, new Vector3(-917.3773, -1526.328, 4.757728)},
            {43, new Vector3(-904.298, -1514.54, 4.643502) },
            {44, new Vector3(-911.9376, -1511.909, 4.893399)},
            {45, new Vector3(-892.5415, -1517.247, 4.864435)},
            {46, new Vector3(-887.8409, -1515.699, 4.905785)},
            {47, new Vector3(-880.5283, -1503.021, 5.010898)},
            {48, new Vector3(-894.0063, -1498.299, 4.659932)},
            {49, new Vector3(-898.7717, -1499.907, 4.757162)},
            {50, new Vector3(-923.619, -1508.829, 4.721528)},
            {51, new Vector3(-928.541, -1510.793, 4.720936)},
            {52, new Vector3(-935.7572, -1523.494, 4.861092)},
            {53, new Vector3(-991.264, -1518.606, 4.885889)},
            {54, new Vector3(-1010.116, -1491.075, 5.044449)},
            {55, new Vector3(-1014.999, -1514.341, 6.857643)},
            {56, new Vector3(-1010.67, -1531.904, 4.887102)},
            {57, new Vector3(-1148.84, -1523.818, 10.26601)},
            {58, new Vector3(-1144.287, -1529.349, 4.022292)},
            {59, new Vector3(-1131.401, -1551.911, 4.517982)},
            {60, new Vector3(-1156.181, -1574.807, 8.423355)},
            {61, new Vector3(-1147.205, -1562.068, 4.132515)},
            {62, new Vector3(-1155.374, -1543.202, 4.354232)},
            {63, new Vector3(-1161.076, -1532.081, 4.711861)},
            {64, new Vector3(-1151.26, -1519.666, 4.236464)},
            {65, new Vector3(-1130.475, -1496.318, 4.336125)},
            {66, new Vector3(-1121.368, -1494.275, 4.257071)},
            {67, new Vector3(-1118.143, -1488.191, 4.21149)},
            {68, new Vector3(-1090.629, -1485.426, 4.931055)},
            {69, new Vector3(-1086.146, -1503.712, 5.07323)},
            {70, new Vector3(-1102.278, -1492.298, 4.785018)},
            {71, new Vector3(-1070.229, -1514.662, 5.046301)},
            {72, new Vector3(-1078.335, -1524.37, 4.484499)},
            {73, new Vector3(-1087.038, -1529.521, 4.48196)},
            {74, new Vector3(-1108.105, -1527.113, 6.482796)},
            {75, new Vector3(-1102.236, -1537.201, 4.371271)},
            {76, new Vector3(-1125.235, -1544.232, 4.532739)}
        }; 
        #endregion

        #region Public Methods
        /// <summary>
        /// Given one of the static House dictionaries get a random selection
        /// </summary>
        /// <param name="houses"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static IEnumerable<Vector3> GetRandomLocations(Houses houses, int amount)
        {
            List<Vector3> vectors = new List<Vector3>();
            var count = houses.Count;
            for (int i = 0; i < amount; i++)
            {
                var randInt = Random.Next(0, count);
                vectors.Add(houses[randInt]);
            }

            return vectors;
        } 
        #endregion
    }
}