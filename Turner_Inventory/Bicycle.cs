namespace Turner_Inventory
{
    public class Bicycle : Product
    {
        public override decimal ShipCost => 9.50m;
        public override string ProductName => "Bicycle";
    }
}
