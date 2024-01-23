namespace ChainofResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHandler monkey = new MonkeyConCreate();
            IHandler squirre = new SquirreConCreate();
            IHandler dog = new DogConCreate();
            monkey.SetNext(squirre).SetNext(dog);

            foreach (var food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                Console.WriteLine($"Client: Who wants a {food}?");

                monkey.Handle(food);
            }
        }
    }
}