using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class ShelterTests
    {
        private Shelter testShelter;
        public ShelterTests()
        {
            testShelter = new Shelter();
        }

        [Fact]
        public void Shelter_Constructor_Should_Instantiate_Shelter_Object()
        {
            Assert.NotNull(testShelter);
        }
    }
}
