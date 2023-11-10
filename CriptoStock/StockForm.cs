using CryptoStock.Desktop.Controls;
using CryptoStock.Domain.Models;
using CryptoStock.Domain.Services;
using static CriptoStock.Desktop.Program;

namespace CriptoStock
{
    public partial class StockForm : Form
    {
        public StockForm(StockProviderResolver resolver, ICoinProvider coinProvider)
        {
            InitializeComponent();

            FillCoinTypes(coinProvider);

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

        private async void FillCoinTypes(ICoinProvider coinProvider)
        {
            var coinTypes = await coinProvider.GetCoinTypesAsync();

            var coins = coinTypes.ToArray();

            baseAssetComboBox.ValueMember = nameof(CoinDTO.Name);
            quoteAssetCombobox.ValueMember = nameof(CoinDTO.Name);

            baseAssetComboBox.Items.AddRange(coins);
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
    }
}