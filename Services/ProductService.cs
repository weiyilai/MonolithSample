using MonolithSample.Models;
using MonolithSample.Services.Interfaces;

namespace MonolithSample.Services
{
    public class ProductService : IProductService
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

        public Product Get()
        {
            return new Product();
        }
    }
}
