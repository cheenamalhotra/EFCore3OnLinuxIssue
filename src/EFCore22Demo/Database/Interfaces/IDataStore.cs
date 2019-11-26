using System.Threading.Tasks;
using DemoProject.Models;

namespace DemoProject.Database.Interfaces
{
    public interface IDataStore
    {
        Task PersistAsync(MatchStatus matchStatus);
    }
}
