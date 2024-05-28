namespace Turner_Inventory
{
    public interface IShippable
    {
        decimal ShipCost { get; }
        string ProductName { get; }
    }
}
