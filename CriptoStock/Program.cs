using Binance.Net.Interfaces;
using BitGet.Net.Interfaces;
using Bybit.Net.Objects.Models.V5;
using CriptoStock.Application.Services;
using CriptoStock.Domain.Services;
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

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<StockForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IStockProvider<BybitSpotTickerUpdate>, BybitStockProvider>();
                    services.AddSingleton<IStockProvider<IBinanceTick>, BinanceStockProvider>();
                    services.AddSingleton<IStockProvider<IBitGetTick>, BitgetStockProvider>();
                    services.AddSingleton<IStockProvider<KucoinStreamTick>, KucoinStockProvider>();

                    services.AddTransient<StockForm>();
                });
        }
    }
}