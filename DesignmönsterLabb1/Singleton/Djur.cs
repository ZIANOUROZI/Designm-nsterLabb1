using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.Singleton
{
    //Singleton designmönster
    public class Djur
    {
        public string Name { get; set; }
        public Djur(string name)
        {
            Name = name;
        }
        public virtual void Ljud()
        {
            Console.WriteLine("Djur ljud");
        }
    }
}
