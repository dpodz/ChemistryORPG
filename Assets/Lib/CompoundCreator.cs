using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Assets.Lib.Helpers;
using Assets.Lib.Elements;

namespace Assets.Lib
{
    public class CCElementInstance
    {
        public Element element;
        public Pair<int, int> coordinates;

        // valence electrons
        public int veN;
        public int veE;
        public int veS;
        public int veW;

        public CCElementInstance(Element e, int x, int y)
        {
            element = e;

            // calculate valence electrons
            // ~TODO~
        }

        public void RotateElementClockwise()
        {
            int veTemp = veW;

            // rotate valence electron
            veW = veS;
            veS = veE;
            veE = veN;
            veN = veTemp;
        }
    }

    public class CompoundCreator : MonoBehaviour
    {
        public IList<Element> elementsAvailable;

        private IList<CCElementInstance> _gridElements;
        private IList<Pair<int, int>> _gridBonds;

        // Use this for initialization
        void Start()
        {
            elementsAvailable = Assets.Lib.ContentContainer.GetAvailableElements();

            _gridElements = new List<CCElementInstance>();
            _gridBonds = new List<Pair<int, int>>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        private Vector2 CalculateMagnetism()
        {
            Vector2 magnetism = new Vector2(0,0);

            return magnetism;
        }
    }
}