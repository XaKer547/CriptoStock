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


        private readonly IKucoinSocketClient _socketClient;
        private readonly IKucoinRestClient _restClient;
        public KucoinStockProvider(IKucoinSocketClient client, IKucoinRestClient restClient)
        {
            _socketClient = client;
            _restClient = restClient;
        }


        public async Task ConnectToTickerChanelAsync(CoinPairDTO pair)
        {
            await _socketClient.UnsubscribeAsync(0);

            var result = await _socketClient.SpotApi.SubscribeToTickerUpdatesAsync(pair.GetSymbol("-"), Update);
        }

        private void Update(DataEvent<KucoinStreamTick> @event)
        {
            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = (decimal)@event.Data.LastPrice,
            });
        }

        public async Task<IReadOnlyCollection<CoinDTO>> GetSymbols()
        {
            var symbols = await _restClient.SpotApi.ExchangeData.GetSymbolsAsync();

            return symbols.Data.Select(s => new CoinDTO
            {
                Id = s.BaseAsset,
                Name = s.BaseAsset,
            }).ToArray();
        }
    }
}
