using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;
using CryptoStock.Domain.Models;
using Kucoin.Net.Interfaces.Clients;
using Kucoin.Net.Objects.Models.Spot.Socket;
using static CriptoStock.Domain.Services.IStockProvider;

namespace CriptoStock.Application.Services
{
    public class KucoinStockProvider : IStockProvider
    {
        public event CurrencyChanged CurrencyChangedEvent;


        private readonly IKucoinSocketClient _client;
        public KucoinStockProvider(IKucoinSocketClient client)
        {
            _client = client;
        }


        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(CoinPairDTO pair)
        {
            await _client.UnsubscribeAsync(0);

            var result = await _client.SpotApi.SubscribeToTickerUpdatesAsync(pair.GetSymbol("-"), Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<KucoinStreamTick> @event)
        {
            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = (decimal)@event.Data.LastPrice,
            });
        }
    }
}
