using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace VirtualPet.Tests
{
    public class PetTests
    {
        private Pet testPet;

        public PetTests()
        {
            testPet = new Pet();
        }

        [Fact]
        public void Pet_Constructor_Should_Instantiate_Pet_Object()

        {
            Assert.NotNull(testPet);
        }

        [Fact]
        public void Pet_Should_Have_Name()
       
        {
            testPet.Name = "Fluffy";
            Assert.NotNull(testPet.Name);
        }

        [Fact]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
            testPet.SetName("Fluffy");

            Assert.Equal("Fluffy", testPet.Name);
        }

        [Fact]
        public void GetName_Should_Get_Pet_Name_Value()
        {
            testPet.SetName("Fido");

            string testPetName = testPet.GetName();

            Assert.Equal("Fido", testPetName);
        }

        [Fact]
        public void Pet_Should_Have_Species()
        {
            testPet.Species = "Cat";
            Assert.NotNull(testPet.Species);
        }

        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            testPet.SetSpecies("Cat");

            Assert.Equal("Cat", testPet.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            testPet.SetSpecies("Dog");

            string testPetSpecies = testPet.GetSpecies();

            Assert.Equal("Dog", testPetSpecies);
        }
    }
}
