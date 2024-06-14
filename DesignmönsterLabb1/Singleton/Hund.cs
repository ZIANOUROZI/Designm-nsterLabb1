using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.Singleton
{
    internal class Hund1 : Djur
    {
        public Hund1(string name) : base(name) { }
        public override void Ljud()
        {
            Console.WriteLine("Voff Voff");
        }
    }
}
