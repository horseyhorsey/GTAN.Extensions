using Xunit;
using GTANetworkAPI;
using GTAN.Extensions;

namespace GTAN.Extensions.Tests
{
    public class WorldExtensionTests
    {
        [Fact]
        public void GetClosestAtm()
        {
            var atm = GTANetworkAPI.NAPI.World.FindNearestAtm(new Vector3(1482.36f, 3587.45f, 35.39f));
            Assert.NotNull(atm);
        }

        [Fact]
        public void VectorString()
        {
            var vexstring = "0 0 0.5";
            var vector = GTAN.Extensions.Vector3Extensions.ConvertToVector3(new Vector3(), vexstring);

            Assert.True(vector.Z == 0.5);
        }
    }
}
