using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;

namespace C16_WorkerService
{
    public class Program
    {
        public static void Main(string[] args)  //funk.
        {
                      // vi anpassa all info til Workers.cs:

                 Log.Logger = new LoggerConfiguration() // iniciera 
                    .MinimumLevel.Debug()
                    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                    .Enrich.FromLogContext()
                    .WriteTo.File(@"D:\workerservice\log\LogFile.txt")
         // jag bytar .Console till .File & skriver s�k v�g till ()ska skapa katalog d:\workerservice\log 
                    .CreateLogger();

           try
           {
                    Log.Information("Starting workerservice...");
                    //log punkt info/skilja sig fr�n Workers.cs <= fr�n annat class Serialog
                    CreateHostBuilder(args).Build().Run();
                    // skapa en tj�nst <Worker>- nedre i f.
                    return ;
           }// om n�n fel -> g� till catch
                catch (Exception ex)
           {
                    Log.Fatal(ex, "Workerservice terminated unexpectedly. Errow :{ex.Message}");
                    return ;
           }
             finally
           {
                    Log.CloseAndFlush();//CloseAndFlush - alla message skriva ut 
           }                                                     
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
                    Host.CreateDefaultBuilder(args)
                .UseSerilog()   //<-Add this line//middelwire=separat tj�nst som anv�nds utav kunna g�ra saker
                .UseWindowsService()  // l�ga till efter installed MicrExtensHostWindServ
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });
    }
}
