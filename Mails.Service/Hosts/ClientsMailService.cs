using Clients.BL.IManager;

namespace Mails.Service.Hosts
{
    public class ClientsMailService : IHostedService
    {
        const string DEFAULT_SEND_MAIL_INTERVAL = "21600";//6 Hours
        private readonly IServiceProvider _serviceProvider;

        private readonly IConfiguration _configuration;

        private Timer? _timer = null;

        private IClientsMailManager? _clientsMailManager = null;

        public ClientsMailService(IServiceProvider serviceProvider, IConfiguration configuration)
        {
            _serviceProvider = serviceProvider;
            _configuration = configuration;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(SendMails, null, TimeSpan.Zero,
            TimeSpan.FromSeconds(double.Parse(_configuration["Mail:SendsEvery"] ?? DEFAULT_SEND_MAIL_INTERVAL)));

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        private async void SendMails(object? state)
        {
             using (var scope = _serviceProvider.CreateScope())
            {
                _clientsMailManager = scope.ServiceProvider.GetRequiredService<IClientsMailManager>();

                await SendMailsScoped();
            }
        }

        private async Task SendMailsScoped()
        {
            if (_clientsMailManager == null)
                throw new ArgumentNullException();

            await _clientsMailManager.SendMailsToUnnotifiedClients();
        }
    }
}