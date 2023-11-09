using Binance.Net;
using Binance.Net.Interfaces;
using Bitget.Net;
using Bitget.Net.Objects.Models;
using Bybit.Net;
using Bybit.Net.Objects.Models.V5;
using CriptoStock.Application.Services;
using CriptoStock.Domain.Services;
using CryptoStock.Application.Services;
using CryptoStock.Domain.Services;
using Kucoin.Net;
using Kucoin.Net.Objects.Models.Spot.Socket;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CriptoStock.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            var a = ServiceProvider.GetRequiredService<StockForm>();
            System.Windows.Forms.Application.Run(a);
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IStockProvider<BybitSpotTickerUpdate>, BybitStockProvider>();
                    services.AddSingleton<IStockProvider<IBinanceTick>, BinanceStockProvider>();
                    services.AddSingleton<IStockProvider<BitgetTickerUpdate>, BitgetStockProvider>();
                    services.AddSingleton<IStockProvider<KucoinStreamTick>, KucoinStockProvider>();
                    services.AddSingleton<ICoinProvider, CoinProvider>();

                    services.AddBitget();
                    services.AddBinance();
                    services.AddKucoin();
                    services.AddBybit();

                    services.AddTransient<StockForm>();
                });
        }
    }
}