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


        private readonly IBybitSocketClient _socketClient;
        private readonly IBybitRestClient _restClient;
        public BybitStockProvider(IBybitSocketClient client, IBybitRestClient restClient)
        {
            _socketClient = client;
            _restClient = restClient;
        }

        public async Task ConnectToTickerChanelAsync(CoinPairDTO pair)
        {
            await _socketClient.UnsubscribeAsync(0);

            var result = await _socketClient.V5SpotApi.SubscribeToTickerUpdatesAsync(pair.GetSymbol(), Update);
        }

        private void Update(DataEvent<BybitSpotTickerUpdate> @event)
        {
            CurrencyChangedEvent.Invoke(new Domain.Models.StockDTO()
            {
                LastPrice = @event.Data.LastPrice,
            });
        }

        public async Task<IReadOnlyCollection<CoinDTO>> GetSymbols()
        {
            var symbols = await _restClient.SpotApiV3.ExchangeData.GetSymbolsAsync();

            return symbols.Data.Select(s => new CoinDTO
            {
                Id = s.BaseAsset,
                Name = s.BaseAsset,
            }).ToArray();
        }
    }
}
