using Binance.Net.Interfaces;
using BitGet.Net.Interfaces;
using Bybit.Net.Objects.Models.V5;
using CriptoStock.Desktop.Presenters;
using CriptoStock.Domain.Models;
using CriptoStock.Domain.Services;
using Kucoin.Net.Objects.Models.Spot.Socket;

namespace CriptoStock
{
    public partial class StockForm : Form, IStockView
    {
        public StockForm(
            IStockProvider<BybitSpotTickerUpdate> bybitProvider,
            IStockProvider<IBinanceTick> binanceProvider,
            IStockProvider<IBitGetTick> bitGetProvider,
            IStockProvider<KucoinStreamTick> kucoinProvider)
        {
            InitializeComponent();

            var presenter = new StockPresenter(this, bybitProvider, binanceProvider, bitGetProvider, kucoinProvider);

            presenter.ConnectToTickerChanel("BTCUSDT");
        }

        public async Task UpdateBinanceCurrency(StockDTO? model)
        {
            if (model is null)
            {
                binanceStockCurrency.Text = "NaN";
                return;
            }

            var previosValue = decimal.Parse(binanceStockCurrency.Text);

            var newValue = model.LastPrice;

            if (previosValue > newValue)
            {
                binanceStockUp.Visible = false;
                binanceStockDown.Visible = true;
            }
            else if (previosValue < newValue)
            {
                binanceStockUp.Visible = true;
                binanceStockDown.Visible = false;
            }
            else
            {
                binanceStockUp.Visible = false;
                binanceStockDown.Visible = false;
            }

            binanceStockCurrency.Text = newValue.ToString();
        }

        public async Task UpdateBitGetCurrency(StockDTO? model)
        {
            if (model is null)
            {
                bitGetStockCurrency.Text = "NaN";
                return;
            }

            var previosValue = decimal.Parse(bitGetStockCurrency.Text);

            var newValue = model.LastPrice;

            if (previosValue > newValue)
            {
                bitGetStockUp.Visible = false;
                bitGetStockDown.Visible = true;
            }
            else if (previosValue < newValue)
            {
                bitGetStockUp.Visible = true;
                bitGetStockDown.Visible = false;
            }
            else
            {
                bitGetStockUp.Visible = false;
                bitGetStockDown.Visible = false;
            }

            bitGetStockCurrency.Text = newValue.ToString();
        }

        public async Task UpdateBybitCurrency(StockDTO? model)
        {
            if (model is null)
            {
                bybitStockCurrency.Text = "Nan";
                return;
            }

            var previosValue = decimal.Parse(bybitStockCurrency.Text);

            var newValue = model.LastPrice;

            if (previosValue > newValue)
            {
                bybitStockUp.Visible = false;
                bybitStockDown.Visible = true;
            }
            else if (previosValue < newValue)
            {
                bybitStockUp.Visible = true;
                bybitStockDown.Visible = false;
            }
            else
            {
                bybitStockUp.Visible = false;
                bybitStockDown.Visible = false;
            }

            bybitStockCurrency.Text = newValue.ToString();
        }

        public async Task UpdateKucoinCurrency(StockDTO? model)
        {
            if (model is null)
            {
                kucoinStockCurrency.Text = "NaN";
                return;
            }

            var oldCurrency = decimal.Parse(kucoinStockCurrency.Text);

            var newCurrency = model.LastPrice;

            if (oldCurrency > newCurrency)
            {
                kucoinStockUp.Visible = false;
                kucoinStockDown.Visible = true;
            }
            else if (oldCurrency < newCurrency)
            {
                kucoinStockUp.Visible = true;
                kucoinStockDown.Visible = false;
            }
            else
            {
                kucoinStockUp.Visible = false;
                kucoinStockDown.Visible = false;
            }

            kucoinStockCurrency.Text = newCurrency.ToString();
        }


        public void UpdateStockSymbol(string symbol)
        {
            binanceStockSymbol.Text = symbol;
            bitGetStockSymbol.Text = symbol;
            bybitStockSymbol.Text = symbol;
            kucoinStockSymbol.Text = symbol;
        }
    }
}