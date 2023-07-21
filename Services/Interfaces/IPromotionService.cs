using MonolithSample.Models;

namespace MonolithSample.Services.Interfaces
{
    public interface IPromotionService
    {
        uint Add();

        bool Edit();

        Promotion Get();

        bool Delete();
    }
}
