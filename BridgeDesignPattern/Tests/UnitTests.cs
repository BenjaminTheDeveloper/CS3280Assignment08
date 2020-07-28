using System;
using Xunit;
using BridgeDesignPattern;


namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void Vehicles_AddingVehicles_IncreaseCount()
        {
            var sut  = new Vehicles("Texas");

            sut.Add("Toyota");
            sut.Add("Ford");
           string expected = "2";
           string result = sut.GetCount();

            Assert.Equal(expected, result);
        }


        [Fact]
        public void Vehicles_AddingVehicles_IncorrectCount()
        {
            var sut = new Vehicles("Texas");

            sut.Add("Toyota");
            sut.Add("Ford");
            string expected = "10"
            string result = sut.GetCount(); 
            Assert.Equal(expected, result);
        }


        [Fact]
        public void Vehicles_AddingVehicles_IncreaseCount()
        {
            var sut = new Vehicles("Texas");

            sut.Add("Toyota");
            sut.Add("Ford");


            Assert.Equal(expected, result);
        }
    }
}
