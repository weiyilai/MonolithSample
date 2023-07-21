using MonolithSample.Models;

namespace MonolithSample.Services.Interfaces
{
    public interface IEpaperService
    {
        uint Add();

        bool Edit();

        Epaper Get();

        bool Delete();
    }
}
