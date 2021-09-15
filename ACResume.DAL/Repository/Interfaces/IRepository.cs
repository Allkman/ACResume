using ACResume.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACResume.API.RepositoryInMemory.Interfaces
{
    public interface IRepository
    {
        Task<MyResume> CreateMyResume(MyResume myResume);
        Task<List<MyResume>> GetMyResume();
        Task<MyResume> GetMyResumeById(string id);
    }
}
