using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Lib.Elements;

namespace Assets.Lib
{
    public static class ContentContainer
    {
        private static IDictionary<int, Element> ElementDict;
        private static IDictionary<int, Compound> CompoundDict;

        public static Element GetElement (int atomicNumber)
        {
            if (ElementDict.ContainsKey(atomicNumber))
            {
                return ElementDict[atomicNumber];
            }
            else
            {
                return LoadElement(atomicNumber);
            }
        }

        public static Compound GetCompound (int compoundHash)
        {
            if (CompoundDict.ContainsKey(compoundHash))
            {
                return CompoundDict[compoundHash];
            }
            else
            {
                return LoadCompound(compoundHash);
            }
        }

        public static IList<Element> GetAvailableElements()
        {
            // Get available elements from db/file/etc
            return null;
        }

        private static Element LoadElement (int atomicNumber)
        {
            // load element from db/file/etc
            return null;
        }

        private static Compound LoadCompound (int compoundHash)
        {
            // load compound from db/file/etc
            return null;
        }
    }
}
