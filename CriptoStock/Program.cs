using Binance.Net;
using Bitget.Net;
using Bybit.Net;
using CriptoStock.Application.Services;
using CriptoStock.Domain.Services;
using CryptoStock.Application.Services;
using CryptoStock.Desktop.Models.Enums;
using CryptoStock.Domain.Services;
using Kucoin.Net;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CriptoStock.Desktop
{
    public static class Program
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

        public delegate IStockProvider StockProviderResolver(StockTypes type);
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddBitget();
                    services.AddBinance();
                    services.AddKucoin();
                    services.AddBybit();


                    services.AddSingleton<BybitStockProvider>();
                    services.AddSingleton<BinanceStockProvider>();
                    services.AddSingleton<BitgetStockProvider>();
                    services.AddSingleton<KucoinStockProvider>();

                    services.AddSingleton<ICoinProvider, CoinProvider>();

                    services.AddTransient<StockProviderResolver>(serviceProvider => type =>
                    {
                        return type switch
                        {
                            StockTypes.Binance => serviceProvider.GetRequiredService<BinanceStockProvider>(),
                            StockTypes.Bitget => serviceProvider.GetRequiredService<BitgetStockProvider>(),
                            StockTypes.Bybit => serviceProvider.GetRequiredService<BybitStockProvider>(),
                            StockTypes.Kucoin => serviceProvider.GetRequiredService<KucoinStockProvider>(),
                            _ => throw new KeyNotFoundException()
                        };
                    });

                    services.AddTransient<StockForm>();
                });
        }
    }
}