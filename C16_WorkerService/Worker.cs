using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace C16_WorkerService
{
   public class Worker : BackgroundService  // arv
    {
        //variable:
        private readonly ILogger<Worker> _logger; // loger till console eller filer
        private readonly string _url = "https://google.com"; //statisk

        private HttpClient _client; // 1. h�mta-skicka info-- request-respond// finns variable "client" men inte deklarerad
        private HttpResponseMessage  _result ;//response, f� tillbacka svar

        public Worker(ILogger<Worker> logger)
        //construktor = har samma namn som Class
        //()dependency injection ILogger<Worker>--2 st best�
        {
            _logger = logger;
            
        }


        public override Task StartAsync(CancellationToken cancellationToken)
            // jag tillagt --starta tj�nsten
        {
            _client = new HttpClient();     //deklarera
            _logger.LogInformation("The service has been started");
            return base.StartAsync(cancellationToken);
        }


        public override Task StopAsync(CancellationToken cancellationToken)
        // jag tillagt --stoppa tj�nsten
        {
            _client.Dispose();   // st�dda upp funk. f�r RAMminne
            _logger.LogInformation("The service has been stopped");//slutta leka 
            return base.StopAsync(cancellationToken);// g� fr�n
        }


      protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        //metod//ovverride--fr�n abstract class
        //(CancellationToken stoppingToken)-avbryta sig Asynv funk.=stoppa in & interrapp
        {
         while (!stoppingToken.IsCancellationRequested)
            {//skapa instance

                //client = new HttpClient();
                //deklarera "client"// nackdel-RAMminne -skapa new client varje sec =10000000mln
                // i <dependence injectin>vi skapa "HttpClient client" i 
                //ctor"public Worker"==det funkar inte oxs�

             try//altid n�r vi utf�ra n�n form att handling vi g�r try-catch att f�nga fel medelande
               // resultat likad oavsett vad
                {
                    _result = await _client.GetAsync(_url);
                    if (_result.IsSuccessStatusCode)
                        _logger.LogInformation($"The website {_url} is up. Status code= {_result.StatusCode}");
                    else
                        _logger.LogInformation($"The website {_url} is down. Status code= {_result.StatusCode}");

                }
                catch (Exception ex)
                {
                    _logger.LogInformation($"{ex.Message}");
                }
               
                

                await Task.Delay(10*1000, stoppingToken); // check  varje 10 sec
                //ligga=sova=v�nta 10 sec, om jag vill vakna , d� anv�nda "stoppingToken"
            }
        }
    }
}
