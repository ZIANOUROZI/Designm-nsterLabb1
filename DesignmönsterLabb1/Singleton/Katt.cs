using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.Singleton
{
    internal class Katt1 :Djur
    {
        public Katt1(string name) : base(name) { }
        public override void Ljud()
        {
            Console.WriteLine("mjooo mjoooo");
        }
    }
}
