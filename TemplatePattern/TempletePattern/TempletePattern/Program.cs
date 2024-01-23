namespace TempletePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Templete Pattern");

            HouseTemplate concreteHouse = new ConcreteHouse();
            concreteHouse.BuildHouse();

            HouseTemplate woodHouse = new WoodenHouse();
            woodHouse.BuildHouse();
        }
    }
}