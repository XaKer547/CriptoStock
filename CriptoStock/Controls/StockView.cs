using CriptoStock.Desktop.Presenters;
using CriptoStock.Domain.Models;
using CriptoStock.Domain.Services;
using CryptoStock.Desktop.Infrastructure;
using CryptoStock.Desktop.Models.Enums;
using CryptoStock.Domain.Models;
using System.ComponentModel;

namespace CryptoStock.Desktop.Controls
{
    public partial class StockView : UserControl, IStockView
    {
        [Description("Вид криптовалютой биржи"), Category("Биржа")]
        public StockTypes StockType
        {
            get => _stockType;
            set
            {
                _stockType = value;
                stockContainer.Text = _stockType.ToString();
            }
        }
        private StockTypes _stockType;

        private StockPresenter _presenter;
        public StockView()
        {
            InitializeComponent();
        }
        //https://stackoverflow.com/questions/23166843/how-to-display-description-of-enum-item-in-popup-menu-in-property-grid-c-sharp

        private decimal previousPrice;
        public async Task UpdateCurrencyAsync(StockDTO? model)
        {
            Invoke(() =>
            {
                var newPrice = model.LastPrice;

                if (previousPrice > newPrice)
                {
                    stockUp.Visible = false;
                    stockDown.Visible = true;
                }
                else if (previousPrice < newPrice)
                {
                    stockUp.Visible = true;
                    stockDown.Visible = false;
                }

                previousPrice = newPrice;

                stockCurrency.Text = newPrice.ToString();
            });
        }

        public void Configure(StockViewOptions options)
        {
            _presenter = new StockPresenter(this, options.Provider);
        }

        public void UpdateStockSymbol(string symbol)
        {
            stockSymbol.Text = symbol;
            stockCurrency.Text = "0";
        }

        public void ConnectToTickerChanel(CoinPairDTO pair) => _presenter.ConnectToTickerChanel(pair);
    }
}
