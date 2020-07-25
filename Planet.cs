using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    public abstract class Planet
    {
        //PRIVATE INSTANCE VARIABLES
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES
        public double Diameter
        {
            get
            {
                return _diameter;
            }
        }

        public double Mass
        {
            get
            {
                return _mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return _moonCount;
            }

            set
            {
                _moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }

            set
            {
                _orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return _ringCount;
            }

            set
            {
                _ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }

            set
            {
                _rotationPeriod = value;
            }
        }


        //CONSTRUCTOR METHOD
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //OVERRIDDEN METHOD
        public override string ToString()
        {
            
            return $"Planet Name: {Name}\nDiameter: {Diameter}\nMass:{Mass}";
        }


    }
}
