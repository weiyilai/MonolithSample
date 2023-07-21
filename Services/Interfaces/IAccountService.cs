using MonolithSample.Models;

namespace MonolithSample.Services.Interfaces
{
    public interface IAccountService
    {
        uint Add();

        bool Edit();

        Account Get();

        bool Delete();
    }
}
