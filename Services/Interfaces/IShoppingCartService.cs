using MonolithSample.Models;

namespace MonolithSample.Services.Interfaces
{
    public interface IShoppingCartService
    {
        uint Add();

        bool Edit();

        ShoppingCart Get();

        bool Delete();
    }
}
