using MonolithSample.Models;

namespace MonolithSample.Services.Interfaces
{
    public interface IOrderService
    {
        uint Add();

        bool Edit();

        Order Get();

        bool Delete();
    }
}
