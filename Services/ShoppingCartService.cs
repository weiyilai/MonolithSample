using MonolithSample.Models;
using MonolithSample.Services.Interfaces;

namespace MonolithSample.Services
{
    public class ShoppingCartService : IShoppingCartService
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

        public ShoppingCart Get()
        {
            return new ShoppingCart();
        }
    }
}
