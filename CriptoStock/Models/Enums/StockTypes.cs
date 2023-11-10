using CryptoStock.Desktop.Converters;
using CryptoStock.Desktop.Editor;
using System.ComponentModel;
using System.Drawing.Design;

namespace CryptoStock.Desktop.Models.Enums
{
    [Editor(typeof(StockProvidersEditor), typeof(UITypeEditor))]
    [TypeConverter(typeof(StockProvidersConverter))]
    public enum StockTypes
    {
        Binance,
        Bitget,
        Bybit,
        Kucoin
    }
}
