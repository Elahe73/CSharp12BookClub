// We can take over the default event implementation by writing our own accessors:

Stock stock = new Stock("THPW");
stock.Price = 27.10M;
// Register with the PriceChanged event
stock.PriceChanged += stock_PriceChanged;
stock.Price = 31.59M;

Console.ReadLine();

void stock_PriceChanged(object sender, EventArgs e)
{
    Console.WriteLine("New price = " + ((Stock)sender).Price);
}

public class Stock
{
    string symbol;
    decimal price;

    public Stock(string symbol) { this.symbol = symbol; }

    private EventHandler _priceChanged;         // Declare a private delegate

    public event EventHandler PriceChanged
    {
        add { _priceChanged += value; }   // Explicit accessor
        remove { _priceChanged -= value; }    // Explicit accessor
    }

    protected virtual void OnPriceChanged(EventArgs e)
    {
        _priceChanged?.Invoke(this, e);
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (price == value) return;
            price = value;
            OnPriceChanged(EventArgs.Empty);
        }
    }
}