using MonolithSample.Models;
using MonolithSample.Services.Interfaces;

namespace MonolithSample.Services
{
    public class PromotionService : IPromotionService
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

        public Promotion Get()
        {
            return new Promotion();
        }
    }
}
