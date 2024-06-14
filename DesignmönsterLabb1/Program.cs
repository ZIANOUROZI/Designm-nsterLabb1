using DesignmönsterLabb1.Adapter;
using DesignmönsterLabb1.FactoryMethod;
using DesignmönsterLabb1.Singleton;

namespace DesignmönsterLabb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a fuctory method");
            
            IDjur katt = DjurFabrik.Do("Katt");
            katt.Ljud();
            IDjur hund = DjurFabrik.Do("Hund");
            hund.Ljud();


            //Singleton
            Console.WriteLine("***********************************");
            Console.WriteLine("This is a Sinleton");
            // Skapa en hund och sätt den i Singleton
            Djur minHund = new Hund1("Rex");
            DjurSingleton.Instance.SetDjur(minHund);

            // Hämta och använd djuret
            Djur djur = DjurSingleton.Instance.GetDjur();
            Console.WriteLine($"Djurets namn: {djur.Name}");
            djur.Ljud();  // Output: Voff!

            // Byt till en katt och sätt den i Singleton
            Djur minKatt = new Katt1("Misse");
            DjurSingleton.Instance.SetDjur(minKatt);

            // Hämta och använd den nya katten
            djur = DjurSingleton.Instance.GetDjur();
            Console.WriteLine($"Djurets namn: {djur.Name}");
            djur.Ljud();  // Output: Mjaou!


            //Adapter
            Console.WriteLine("**********************************************");
            Console.WriteLine("This is a Adapter");
            IKörbar bil = new Bil();
            bil.kör();

            //skapa en motorcykel
            Motorcycle motorcykel = new Motorcycle();
            motorcykel.Drive();
        }
    }
}
