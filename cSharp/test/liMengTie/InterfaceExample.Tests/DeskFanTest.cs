using System;
using Xunit;

namespace InterfaceExample.Tests
{
    public class DeskFanTest
    {
        [Fact]
        public void PowerLowerThanZero_ok()
        {
            var fan = new DeskFan(new PowerSupplyLowerThanZero());
            var expected = "Won't work.";
            var actual = fan.Work();
            Assert.Equal(expected, actual);
        }
    }
    class PowerSupplyLowerThanZero : IPowerSupply
    {
        public int GetPower()
        {
            return 0;
        }
    }
}
