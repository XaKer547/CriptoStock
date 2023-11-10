using Bybit.Net.Interfaces.Clients;
using Bybit.Net.Objects.Models.V5;
using CriptoStock.Domain.Services;
using CryptoExchange.Net.Sockets;
using CryptoStock.Domain.Models;
using static CriptoStock.Domain.Services.IStockProvider;

namespace CriptoStock.Application.Services
{
    public class BybitStockProvider : IStockProvider
    {
        public event CurrencyChanged CurrencyChangedEvent;


        private readonly IBybitSocketClient _client;
        public BybitStockProvider(IBybitSocketClient client)
        {
            _client = client;
        }


        private bool isConnected;
        public async Task ConnectToTickerChanelAsync(CoinPairDTO pair)
        {
            await _client.UnsubscribeAsync(0);

            var result = await _client.V5SpotApi.SubscribeToTickerUpdatesAsync(pair.GetSymbol(), Update);

            isConnected = result.Success;
        }

        private void Update(DataEvent<BybitSpotTickerUpdate> @event)
        {
            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = @event.Data.LastPrice,
            });
        }
    }
}
