using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _oxygen;

        //CONSTRUCTOR METHOD
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
            if(oxygen == true)
            {
                Console.WriteLine($"Oxygen Presence: Present");
            }

            else
            {
                Console.WriteLine($"Oxygen Presence: Negative");
            }
            
            HasMoons();
            Habitable();
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

        public bool Habitable()
        {
            if (_oxygen == true)
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
