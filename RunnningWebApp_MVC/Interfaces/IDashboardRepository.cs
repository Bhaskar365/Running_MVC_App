using RunnningWebApp_MVC.Models;

namespace RunnningWebApp_MVC.Interfaces
{
    public interface IDashboardRepository
    {
        Task<List<Race>> GetAllUserRaces();
        Task<List<Club>> GetAllUserClubs();
        Task<AppUser> GetUserById(string id);
    }
}
