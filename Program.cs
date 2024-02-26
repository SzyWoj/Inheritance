namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ziemia ziemia = new Ziemia();
            Mars mars = new Mars();
            ziemia.RuchObrotowy();
            ziemia.PoraDniaINocy();
            ziemia.Atmosfera();
            mars.Atmosfera();
            Console.ReadKey();
        }

    }

    abstract class CialoNiebieskie
    {
        public string Nazwa { get; set; }

        public void RuchObrotowy()
        {
            Console.WriteLine("Kazde cialo niebieskie posiada ruch obrotowy");
        }
    }

    abstract class Planeta : CialoNiebieskie
    {
        public void PoraDniaINocy()
        {
            Console.WriteLine("Pory Dnia i Nocy");
        }
    }

    class Ziemia : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera Ziemska");
        }
    }

    class Mars : Planeta
    {
        public void Atmosfera()
        {
            Console.WriteLine("Atmosfera Marsa jest 2 razy wieksza od Ziemi");
        }
    }

}
