namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product{ ProductId = 1, Name = "product1", UnitePrice = 15},
                new Product{ ProductId = 2, Name = "product2", UnitePrice = 20},
                new Product{ ProductId = 3, Name = "product3", UnitePrice = 30},
                new Product{ ProductId = 4, Name = "product4", UnitePrice = 40},
                new Product{ ProductId = 5, Name = "product5", UnitePrice = 60},
            };
            while (true)
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);
                }
                var order = new Order();
                Console.WriteLine(order.State);
                while (true)
                {
                    Console.WriteLine("Enter product id");
                    var id = int.Parse(Console.ReadLine());
                    if (id == 0)
                    {
                        break;
                    }
                    Console.WriteLine("Enter Quantity");
                    var quantity = int.Parse(Console.ReadLine());
                    var product = products.First(p => p.ProductId == id);
                    order.Lines.Add(new OrderLine { ProductId =id, Quantity= quantity, UnitPrice =  product.UnitePrice});
                }
                while (true)
                {
                    Console.WriteLine("Select Action");
                    Console.WriteLine("1\\Confirm");
                    Console.WriteLine("2\\process");
                    Console.WriteLine("3\\Cancel");
                    Console.WriteLine("4\\ship");
                    Console.WriteLine("5\\Deliver");
                    Console.WriteLine("6\\return");
                    Console.WriteLine("7\\exit");

                    var action = int.Parse(Console.ReadLine());

                    try
                    {
                        if (action == 0)
                            break;
                        else if (action == 1)
                            order.Confirm();
                        else if (action == 2)
                            order.Process();
                        else if (action == 3)
                            order.Cancel();
                        else if (action == 4)
                            order.Ship();
                        else if (action == 5)
                            order.Deliver();
                        else if (action == 6)
                            order.Return();
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("orde state changed " + order.State);
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    catch(Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}