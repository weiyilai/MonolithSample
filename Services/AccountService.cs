using MonolithSample.Models;
using MonolithSample.Services.Interfaces;

namespace MonolithSample.Services
{
    public class AccountService : IAccountService
    {
        public uint Add()
        {
            return 0u;
        }

        public bool Delete()
        {
            return true;
        }

        public bool Edit()
        {
            return true;
        }

        public Account Get()
        {
            return new Account();
        }
    }
}
