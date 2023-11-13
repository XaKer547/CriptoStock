using CryptoStock.Desktop.Controls;
using CryptoStock.Desktop.Models.Enums;
using CryptoStock.Domain.Models;
using static CriptoStock.Desktop.Program;

namespace CriptoStock
{
    public partial class StockForm : Form
    {
        private StockTypes _type;
        private readonly StockProviderResolver _resolver;
        public StockForm(StockProviderResolver resolver)
        {
            InitializeComponent();
            _resolver = resolver;

            _type = StockTypes.Binance;

            ConfigureCoinBoxes();

            ConfigureStockViews(resolver);
        }

        private void ConfigureStockViews(StockProviderResolver resolver)
        {
            foreach (var stockView in Controls.OfType<StockView>())
            {
                stockView.Configure(new CryptoStock.Desktop.Infrastructure.StockViewOptions()
                {
                    Provider = resolver(stockView.StockType)
                });
            }

            SetTickerChanel(new CoinPairDTO() { BaseAsset = "BTC", QuoteAsset = "USDT" });
        }

        private void ConfigureCoinBoxes()
        {
            baseAssetComboBox.ValueMember = nameof(CoinDTO.Name);
            quoteAssetCombobox.ValueMember = nameof(CoinDTO.Name);

            FillCoinTypes();
        }

        private async void FillCoinTypes()
        {
            var stockProvider = _resolver(_type);

            var coinTypes = await stockProvider.GetSymbols();

            var coins = coinTypes.ToArray();

            baseAssetComboBox.Items.Clear();
            baseAssetComboBox.Items.AddRange(coins);

            quoteAssetCombobox.Items.Clear();
            quoteAssetCombobox.Items.AddRange(coins);

            baseAssetComboBox.SelectedIndex = 0;
            quoteAssetCombobox.SelectedIndex = 1;
        }

        private void SetTickerChanel(CoinPairDTO pair)
        {
            foreach (var stockView in Controls.OfType<StockView>())
            {
                stockView.ConnectToTickerChanel(pair);
            }
        }

        private void ChannelSetButton_Click(object sender, EventArgs e)
        {
            var baseAsset = (CoinDTO)baseAssetComboBox.SelectedItem;
            var quoteAsset = (CoinDTO)quoteAssetCombobox.SelectedItem;

            SetTickerChanel(new CoinPairDTO()
            {
                BaseAsset = baseAsset.Id,
                QuoteAsset = quoteAsset.Id
            });
        }

        private void RemoveDuplicateValues(ComboBox sender, object value)
        {
            foreach (var cb in coinPairBox.Controls.OfType<ComboBox>())
            {
                if (cb != sender)
                {
                    cb.Items.Remove(value);
                }
            }
        }

        private void BaseAssetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveDuplicateValues((ComboBox)sender, ((ComboBox)sender).SelectedItem);
        }

        private void QuoteAssetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemoveDuplicateValues((ComboBox)sender, ((ComboBox)sender).SelectedItem);
        }

        private void SelectedStock_Changed(object sender, EventArgs e)
        {
            _type = Enum.Parse<StockTypes>(stockCombobox.SelectedItem.ToString());

            FillCoinTypes();
        }
    }
}