using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment_3
{
    class GiantPlanet : Planet, IHasMoons, IHasRings        
    {
        //PRIVATE INSTANCE VARIABLES
        private string _type;

        //CONSTRUCTOR METHOD
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name,diameter,mass)
        {
            if(type == "Gas" || type == "Ice")
            {
                this._type = type;
                Console.WriteLine($"Planet Type: {type}");
            }
            else
            {
                Console.WriteLine("Planet Type: Invalid Planet Type entered");
            }
            HasMoons();
            HasRings();
        }

        //PUBLIC METHODS
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
