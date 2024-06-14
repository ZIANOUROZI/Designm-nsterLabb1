using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.FactoryMethod
{
    public class Katt :IDjur
    {
        public void Ljud()
        {
            Console.WriteLine("Maiooo");
        }
    }
}
