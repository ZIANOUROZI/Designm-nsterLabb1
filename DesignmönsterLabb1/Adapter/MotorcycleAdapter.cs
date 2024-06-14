using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.Adapter
{
    public class MotorcycleAdapter :IKörbar
    {
        private readonly Motorcycle _motorcycle;
        public MotorcycleAdapter(Motorcycle motorcycle)
        {
            _motorcycle = motorcycle;
        }
        public void kör()
        {
            _motorcycle.Drive();
        }
    }
}
