using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.Adapter
{
    // Adapter desigmönster
    public class Bil : IKörbar
    {
        public void kör()
        {
            Console.WriteLine("Kör bilen");
        }
    }
}
