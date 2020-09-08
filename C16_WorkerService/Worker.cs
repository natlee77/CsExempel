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
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private HttpClient _client;       // hämta-skicka ingo-- request-respond

        public Worker(ILogger<Worker> logger)
            //construktor//dependency injection
        {
            _logger = logger;
            
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {//skapa instance
                
                await _client.GetAsync("https://google.com");
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
