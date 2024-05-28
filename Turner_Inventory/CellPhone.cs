namespace Turner_Inventory
{
    public class CellPhone : Product
    {
        public override decimal ShipCost => 5.95m;
        public override string ProductName => "Cell Phone";
    }
}
