using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.FactoryMethod
{
    public class DjurFabrik
    {
        public static IDjur Do(string type)
        {
            if(type.Equals("Katt"))
            {
                return new Katt();
            }
            else if(type.Equals("Hund"))
            {
                return new Hund();
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
