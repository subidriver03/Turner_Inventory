using System;

namespace Turner_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper shipper = new Shipper();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Welcome to the Vibe Inventory Program!");
                Console.WriteLine();
                Console.WriteLine("Choose from the following options:");
                Console.WriteLine();
                Console.WriteLine("1. Add a Bicycle to the shipment");
                Console.WriteLine("2. Add a Lawn Mower to the shipment");
                Console.WriteLine("3. Add a Cell Phone to the shipment");
                Console.WriteLine("4. Add a Baseball Glove to the shipment");
                Console.WriteLine("5. Add Crackers to the shipment");
                Console.WriteLine("6. List Shipment Items");
                Console.WriteLine("7. Compute Shipping Charges");
                Console.WriteLine("8. Clear Cart");
                Console.WriteLine("9. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        shipper.Add(new Bicycle());
                        break;
                    case "2":
                        shipper.Add(new LawnMower());
                        break;
                    case "3":
                        shipper.Add(new CellPhone());
                        break;
                    case "4":
                        shipper.Add(new BaseballGlove());
                        break;
                    case "5":
                        shipper.Add(new Crackers());
                        break;
                    case "6":
                        shipper.ListItems();
                        break;
                    case "7":
                        decimal totalCost = shipper.ComputeShippingCharges();
                        Console.WriteLine($"Total shipping cost for this order is {totalCost:C}");
                        break;
                    case "8":
                        string clearMessage = shipper.Clear();
                        Console.WriteLine(clearMessage);
                        break;
                    case "9":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("Press any key to return to the menu.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
