using Binance.Net.Interfaces;
using Binance.Net.Interfaces.Clients;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;
using CryptoStock.Domain.Models;
using static CriptoStock.Domain.Services.IStockProvider;

namespace CriptoStock.Application.Services
{
    public class BinanceStockProvider : IStockProvider
    {
        public event CurrencyChanged CurrencyChangedEvent;


        private readonly IBinanceSocketClient _client;
        public BinanceStockProvider(IBinanceSocketClient client)
        {
            _client = client;
        }


        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(CoinPairDTO pair)
        {
            await _client.UnsubscribeAsync(0);

            var result = await _client.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(pair.GetSymbol(), Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<IBinanceTick> @event)
        {
            var price = Math.Round(@event.Data.LastPrice, 2);
            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = price,
            });
        }
    }
}
