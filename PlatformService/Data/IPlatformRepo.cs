using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformeRepo
    {
        bool saveChanges();

        IEnumerable<Platform> GetAllPlatforms();
        Platform getPlatformById(int id);
        void CreatePlatform(Platform plat);

    }
}