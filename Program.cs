using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Element[] elementArray = new Element[6];
            elementArray[0] = new MetalElement("Zn",30,65.38);
            elementArray[1] = new NonMetalElement("He", 2, 4.003);
            elementArray[2] = new MetalElement("K", 19, 39.0983);
            elementArray[3] = new NonMetalElement("Ne", 1029, 20.18);
            elementArray[4] = new MetalElement("Ag", 47, 107.9);
            elementArray[5] = new NonMetalElement("O",8,15.999);

            for(int i=0;i<elementArray.Length;i++)
            {
                elementArray[i].DescribeElement();
            }
            Console.ReadLine();
        }
    }
}
