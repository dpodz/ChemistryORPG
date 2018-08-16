using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Lib.Elements
{
    public class Compound
    {
        public string Name;
        public IList<Element> Elements;
        public CompoundType Type;
    }
}
