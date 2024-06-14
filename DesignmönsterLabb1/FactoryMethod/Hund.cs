using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.FactoryMethod
{
    //Arvt från IDjur inreface
    public class Hund : IDjur
    {
        public void Ljud()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
