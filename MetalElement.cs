using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementArray
{
    class MetalElement:Element
    {
        public MetalElement(string symbol,int number, double weight)
            : base(symbol,number,weight)
        {

        }
        public override void DescribeElement()
        {
            string commonProperties = "\n1.Good conductors of electricity and heat";
            if (ElementSymbol.Equals("Zn"))
            {
                Console.WriteLine("Metal elements" +
                    "\n************************************************************************" +
                    "\nAtomic symbol: " + ElementSymbol +
                    "\nAtomic number: " + AtomicNumber +
                    "\nAtomic weight:" + AtomicWeight +
                    "\nProperty of Zinc element:" +
                    "\nslightly brittle metal at room temperature" +
                    "\nshiny-greyish appearance when oxidation is removed" +
                    "\nProperties of metal element:" + commonProperties);
            }
            if(ElementSymbol.Equals("K"))
            {
                Console.WriteLine("Metal elements" +
                    "\n************************************************************************" +
                    "\nAtomic symbol: " + ElementSymbol +
                    "\nAtomic number: " + AtomicNumber +
                    "\nAtomic weight:" + AtomicWeight +
                    "\nProperties of Potassium element:" +
                    "\nsilvery white metal" +
                    "\nis soft enough to easily cut with a knife" +
                    "\nProperties of metal element:" + commonProperties);
            }
            if (ElementSymbol.Equals("Ag"))
            {
                Console.WriteLine("Metal elements" +
                   "\n************************************************************************" +
                   "\nAtomic symbol: " + ElementSymbol +
                   "\nAtomic number: " + AtomicNumber +
                   "\nAtomic weight:" + AtomicWeight +
                   "\nProperty of Silver element:" +
                   "\nsoft, white, lustrous transition meta" +
                   "\nProperties of metal element:" + commonProperties);
            }
        }
    }
}
