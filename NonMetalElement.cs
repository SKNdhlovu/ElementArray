using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementArray
{
    class NonMetalElement:Element
    {
        public NonMetalElement(string symbol, int number, double weight)
            : base (symbol, number,weight)
        {
        }
        public override void DescribeElement()
        {
            string commonProperties = "\n1.Poor conductors of electricity\n2.Are brittle";
            if (ElementSymbol.Equals("He"))
            {
                Console.WriteLine("Metal elements" +
                    "\n************************************************************************" +
                    "\nAtomic symbol: " + ElementSymbol +
                    "\nAtomic number: " + AtomicNumber +
                    "\nAtomic weight:" + AtomicWeight +
                    "\nProperty of Helium element:" +
                    "\n1.Colorless, odorless, tasteless, non-toxic, inert, monatomic gas" +
                    "\n2.Its boiling point is the lowest among all the elements" +
                    "\nProperties of non-metal element:" + commonProperties);
            }
            if (ElementSymbol.Equals("O"))
            {
                Console.WriteLine("Metal elements" +
                    "\n************************************************************************" +
                    "\nAtomic symbol: " + ElementSymbol +
                    "\nAtomic number: " + AtomicNumber +
                    "\nAtomic weight:" + AtomicWeight +
                    "\nProperties of Oxygen element:" +
                    "\n1.Highly reactive" +
                    "\n2.Member of the chalcogen group " +
                    "\nProperties of non-metal element:" + commonProperties);
            }
            if (ElementSymbol.Equals("Ne"))
            {
                Console.WriteLine("Metal elements" +
                   "\n************************************************************************" +
                   "\nAtomic symbol: " + ElementSymbol +
                   "\nAtomic number: " + AtomicNumber +
                   "\nAtomic weight:" + AtomicWeight +
                   "\nProperty of Neon element:" +
                   "\n1.It is a noble gas" +
                   "\n2.It is a colorless, odorless, inert monatomic gas under standard conditions" +
                   "\nProperties of metal element:" + commonProperties);
            }
            
        }
    }
}
