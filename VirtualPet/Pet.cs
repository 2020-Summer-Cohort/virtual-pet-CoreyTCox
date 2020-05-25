using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        //private string name;  // this is unnecessary if you add your properties like in line 16, you can remove it
        //private string species;
        private int hunger;
        //private int boredom;
        //private int health;
        // Properties Section ------------------ see Players Guide pg 136, Auto implemented Properties
        public string Name { get; set; }

        // add a Species property
        public string Species { get; set; }

        // add a Hunger property
        /*public int Hunger
        {
            get
            {
                return hunger;
            }
            set
            {
                hunger = value;
                if (value < 0)
                    hunger = 0;
            }
        }*/
        public int Hunger { get; set; }

        // add a Boredom property
        /*public int Boredom
        {
            get
            {
                return boredom;
            }
            set
            {
                boredom = value;
                if (value < 0)
                    boredom = 0;
            }
        }*/
        public int Boredom { get; set; }

        // add a Health property
        /*public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
                if (value < 0)
                    health = 0;
            }
        }*/
        public int Health { get; set; }

        // Constructor Section --------------------- 

        // add a Pet constructor that assigns Hunger to 50, Boredom to 60, and Health to 30
        Pet pet = new Pet() { Hunger = 50, Boredom = 60, Health = 30 };// Object Initializer Syntax?

        // Methods Section -------------------------- see Players guide pages 90-97

        // finish adding the SetName method which takes in a string parameter, has no return value, and sets the
        // Name property to the value passed in as a parameter
        public void SetName(string name)
        {
            Name = name;
        }

        // add a method named SetSpecies that takes in a string parameter, has no return value, and sets the 
        // Species property to the value passed in as a parameter
        public void SetSpecies(string species)
        {
            Species = species;
        }

        // add a method named Feed that has no parameters, has no return value, and decreases Hunger by 40
        public void Feed()
        {
            Hunger = Hunger - 40;
        }

        // add a method named SeeDoctor that has no parameters, has no return value, and increases Health by 30
        public void SeeDoctor()
        {
            Health = Health + 30;
        }

        // add a method named Play that has no parameters, has no return value, and increases Hunger by 10,
        // decreases Boredom by 20, and increases Health by 10
        public void Play()
        {
            Hunger = Hunger + 10;
            Boredom = Boredom - 20;
            Health = Health + 10;
        }

        // add a method named Tick that has no parameters, has no return value, and increases Hunger by 5, increases
        // Boredom by 5, and decreases Health by 5
        public void Tick()
        {
            Hunger = Hunger + 5;
            Boredom = Boredom + 5;
            Health = Health - 5;
        }

    }
}
