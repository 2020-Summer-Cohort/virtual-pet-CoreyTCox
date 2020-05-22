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
        private string name;  // this is unnecessary if you add your properties like in line 16, you can remove it

        // Properties Section ------------------ see Players Guide pg 136, Auto implemented Properties
        public string Name { get; set; }

        // add a Species property

        // add a Hunger property

        // add a Boredom property

        // add a Health property


        // Constructor Section --------------------- 

        // add a Pet constructor that assigns Hunger to 50, Boredom to 60, and Health to 30


        // Methods Section -------------------------- see Players guide pages 90-97

        // finish adding the SetName method which takes in a string parameter, has no return value, and sets the
        // Name property to the value passed in as a parameter

        public void SetName()
        {
            // this method was also missing the curly brace body
        }

        // add a method named SetSpecies that takes in a string parameter, has no return value, and sets the 
        // Species property to the value passed in as a parameter

        // add a method named Feed that has no parameters, has no return value, and decreases Hunger by 40

        // add a method named SeeDoctor that has no parameters, has no return value, and increases Health by 30 

        // add a method named Play that has no parameters, has no return value, and increases Hunger by 10,
        // decreases Boredom by 20, and increases Health by 10

        // add a method named Tick that has no parameters, has no return value, and increases Hunger by 5, increases
        // Boredom by 5, and decreases Health by 5

    }
}
