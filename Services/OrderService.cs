using MonolithSample.Models;
using MonolithSample.Services.Interfaces;

namespace MonolithSample.Services
{
    public class OrderService : IOrderService
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

        public Order Get()
        {
            return new Order();
        }
    }
}
