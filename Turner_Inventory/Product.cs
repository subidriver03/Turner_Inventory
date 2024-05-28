using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turner_Inventory
{
    public abstract class Product : IShippable
    {
        public abstract decimal ShipCost { get; }
        public abstract string ProductName { get; }
    }
}