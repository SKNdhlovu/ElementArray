using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementArray
{
    abstract class Element
    {
        private string elementSymbol;
        private int atomicNumber;
        private double atomicWeight;

        public Element(string symbol, int number, double weight)
        {
            elementSymbol = symbol;
            atomicNumber = number;
            atomicWeight = weight;
        }
        public string ElementSymbol { get { return elementSymbol; } }
        public int AtomicNumber { get { return atomicNumber; } }
        public double AtomicWeight { get { return atomicWeight; } }
        public abstract void DescribeElement();
    }
}
