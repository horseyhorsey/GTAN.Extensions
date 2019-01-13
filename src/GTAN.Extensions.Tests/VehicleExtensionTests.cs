using GTAN.Data;
using GTAN.Extensions;
using Xunit;

namespace GTAN.Extensions.Tests
{
    public class VehicleExtensionTests
    {
        [Fact]
        public void GetAllVehicleHashes()
        {
            var types = VehicleType.All;
            var vehicles = GTANetworkAPI.NAPI.Vehicle.GetVehicleHashes(types);
            Assert.True(vehicles.Count > 0);
        }

        [Theory]
        [InlineData(VehicleType.Boat)]
        [InlineData(VehicleType.EmergencyAirSea)]
        [InlineData(VehicleType.Industrial)]
        [InlineData(VehicleType.Boat | VehicleType.Helicopter)]
        public void GetVehicleHashes(VehicleType vehicleType)
        {            
            var vehicles = GTANetworkAPI.NAPI.Vehicle.GetVehicleHashes(vehicleType);
            Assert.True(vehicles.Count > 0);
        }
    }
}
