using System;
using System.Collections.Generic;
using System.Linq;

namespace Turner_Inventory
{
    public class Shipper
    {
        private List<IShippable> items = new List<IShippable>();

        public void Add(IShippable item)
        {
            if (items.Count < 10)
            {
                items.Add(item);
                Console.WriteLine($"1 {item.ProductName} has been added");
            }
            else
            {
                Console.WriteLine("Cannot add more than 10 items");
            }
        }

        public void ListItems()
        {
            var groupedItems = items.GroupBy(i => i.ProductName).Select(g => new { ProductName = g.Key, Count = g.Count() });

            Console.WriteLine("Shipment manifest:");
            foreach (var item in groupedItems)
            {
                string productName = item.ProductName;
                int count = item.Count;

                if (productName != "Crackers" && count > 1)
                {
                    productName += "s";
                }

                Console.WriteLine($"{count} {productName}");
            }
        }

        public decimal ComputeShippingCharges()
        {
            return items.Sum(i => i.ShipCost);
        }

        public void Clear()
        {
            items.Clear();
            Console.WriteLine("The cart has been cleared.");
        }
    }
}
