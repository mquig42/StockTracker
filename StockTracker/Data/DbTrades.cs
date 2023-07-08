namespace StockTracker.Data
{
    //Represents the Trades table
    public class DbTrades
    {
        public DateOnly Date { get; set; }
        public string? Symbol { get; set; }
        public string? Type {  get; set; }
        public string? Description { get; set; }
        public decimal Qty { get; set; }
        public decimal Cash { get; set; }
        public decimal UnitsHeld { get; set; }

        public DbTrades(DateOnly date, string? symbol, string? type, string? description, decimal qty, decimal cash, decimal unitsHeld)
        {
            Date = date;
            Symbol = symbol;
            Type = type;
            Description = description;
            Qty = qty;
            Cash = cash;
            UnitsHeld = unitsHeld;
        }
    }
}
