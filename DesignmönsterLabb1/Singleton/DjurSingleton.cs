using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignmönsterLabb1.Singleton
{
    internal class DjurSingleton
    {
        private static DjurSingleton _instance;
        private Djur _djur;

        // Privat konstruktor så ingen annan kan skapa en ny instans
        private DjurSingleton() { }

        // Metod för att hämta den enda instansen av Singleton-klassen
        public static DjurSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DjurSingleton();
                }
                return _instance;
            }
        }

        // Sätt djuret
        public void SetDjur(Djur djur)
        {
            _djur = djur;
        }

        // Hämta djuret
        public Djur GetDjur()
        {
            return _djur;
        }
    }
}
