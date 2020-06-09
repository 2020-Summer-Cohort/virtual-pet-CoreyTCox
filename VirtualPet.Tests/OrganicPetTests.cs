using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicPetTests
    {
        private OrganicPet testOrganicPet;
        
        public OrganicPetTests()
        {
            testOrganicPet = new OrganicPet();
        }

        [Fact]
        public void Pet_Should_Have_Hunger()
        {
            Assert.NotNull(testOrganicPet.Hunger);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int testPetHunger = testOrganicPet.GetHunger();

            Assert.Equal(50, testPetHunger);
        }

        [Fact]
        public void Pet_Should_Have_Boredom()
        {
            Assert.NotNull(testOrganicPet.Boredom);
        }

        [Fact]
        public void GetBoredom_Should_Return_Initial_Boredom_Level_Of_60()
        {
            int testPetBoredom = testOrganicPet.GetBoredom();

            Assert.Equal(60, testPetBoredom);
        }

        [Fact]
        public void Pet_Should_Have_Health()
        {
            Assert.NotNull(testOrganicPet.Health);
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
            int testPetHealth = testOrganicPet.GetHealth();

            Assert.Equal(30, testPetHealth);
        }

        [Fact]
        public void Feed_Should_Decrease_Hunger_By_40()
        {
            testOrganicPet.Feed();

            Assert.Equal(10, testOrganicPet.GetHunger());
        }

        [Fact]
        public void SeeVet_Should_Increase_Health_By_30()
        {
            testOrganicPet.SeeVet();

            Assert.Equal(60, testOrganicPet.GetHealth());
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            testOrganicPet.Play();

            Assert.Equal(60, testOrganicPet.GetHunger());
        }

        [Fact]
        public void Play_Should_Decrease_Boredom_By_20()
        {
            testOrganicPet.Play();

            Assert.Equal(40, testOrganicPet.GetBoredom());
        }

        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            testOrganicPet.Play();

            Assert.Equal(40, testOrganicPet.GetHealth());
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            testOrganicPet.Tick();

            Assert.Equal(55, testOrganicPet.GetHunger());
        }

        [Fact]
        public void Tick_Should_Increase_Boredom_By_5()
        {
            testOrganicPet.Tick();

            Assert.Equal(65, testOrganicPet.GetBoredom());
        }

        [Fact]
        public void Tick_Should_Decrease_Health_By_5()
        {
            testOrganicPet.Tick();

            Assert.Equal(25, testOrganicPet.GetHealth());
        }
    }
}
