using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HistoricalService {
    public class Program {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();


        private static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) => { services.AddHostedService<Worker>(); });
    }
}