using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Lib.Elements
{
    public class Element
    {
        public string Name;
        public int AtomicNumber;
        public int ValenceElectrons;
        public float Electronegativity;
        public float AtomicMass;
        public IList<float> Isotopes;

        // Unused/Undecided properties
        //public float Density;
        //public float EnergyOfFirstIonisation;
        //public float EnergyOfSecondIonisation;
        
        private ElementType Type { get; set; }

        public Element( string name, 
                        int atomicNumber, 
                        int valenceElectrons,
                        float electronegativity,
                        float atomicMass,
                        IList<float> isotopes)
        {
            Name = name;
            AtomicNumber = atomicNumber;
            ValenceElectrons = valenceElectrons;
            Electronegativity = electronegativity;
            AtomicMass = atomicMass;
            Isotopes = isotopes;
        }
    }
}