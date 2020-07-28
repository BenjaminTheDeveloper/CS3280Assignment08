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
            string expected = "10";
            string result = sut.GetCount(); 
            Assert.NotEqual(expected, result);
        }


        [Fact]
        public void Vehicles_SelectionMockUp_Matching()
        {
            var sut = new Vehicles("Texas");

            sut.Add("Toyota");
            sut.Add("Ford");

            var expected = "Texas";
            var result = sut.GetSelection(); 

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Vehicles_SelectionMockUp_NotMatching()
        {
            var sut = new Vehicles("Texas");

            sut.Add("Toyota");
            sut.Add("Ford");

            var expected = "Arizona";
            var result = sut.GetSelection();

            Assert.NotEqual(expected, result);
        }
    }
}
