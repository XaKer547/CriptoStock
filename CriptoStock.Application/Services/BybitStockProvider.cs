using Bybit.Net.Clients;
using Bybit.Net.Objects.Models.V5;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;

namespace CriptoStock.Application.Services
{
    public class BybitStockProvider : IStockProvider<BybitSpotTickerUpdate>
    {
        private readonly BybitSocketClient _client;
        public BybitStockProvider()
        {
            _client = new BybitSocketClient();
        }

        public event IStockProvider<BybitSpotTickerUpdate>.CurrencyChanged CurrencyChangedEvent;

        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(string symbol)
        {
            var result = await _client.V5SpotApi.SubscribeToTickerUpdatesAsync(symbol, Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<BybitSpotTickerUpdate> @event)
        {
            if (!isConnected)
            {
                CurrencyChangedEvent.Invoke(null);
                return;
            }

            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = @event.Data.LastPrice,
            });
        }
    }
}
