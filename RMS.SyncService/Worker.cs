using Microsoft.EntityFrameworkCore;
using RMS.API.Data;

namespace RMS.SyncService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public Worker(ILogger<Worker> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("SyncService pracuje: Sprawdzam stan zasobów o: {time}", DateTimeOffset.Now);

                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                    var count = await context.Resources.CountAsync(stoppingToken);
                    _logger.LogWarning("ALERT SYSTEMOWY: Obecnie w systemie znajduje siê {count} zasobów.", count);
                }

                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}