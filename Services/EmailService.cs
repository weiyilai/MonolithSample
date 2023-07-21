using MonolithSample.Services.Interfaces;

namespace MonolithSample.Services
{
    public class EmailService : IEmailService
    {
        public async Task Send()
        {
            await Task.CompletedTask;
        }
    }
}
