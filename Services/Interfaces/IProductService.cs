using MonolithSample.Models;

namespace MonolithSample.Services.Interfaces
{
    public interface IProductService
    {
        uint Add();

        bool Edit();

        Product Get();

        bool Delete();
    }
}
