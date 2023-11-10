using CriptoStock.Domain.Services;

namespace CryptoStock.Desktop.Infrastructure
{
    public class StockViewOptions
    {
        public IStockProvider Provider { get; set; }
    }
}
