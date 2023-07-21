using MonolithSample.Services.Interfaces;

namespace MonolithSample.Services
{
    public class SmsService : ISmsService
    {
        public async Task Send()
        {
            await Task.CompletedTask;
        }
    }
}
