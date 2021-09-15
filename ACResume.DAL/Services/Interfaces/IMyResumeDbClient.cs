using ACResume.DAL.Models;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace ACResume.API.Services.Interfaces
{
    public interface IMyResumeDbClient
    {
        Task<MyResume> Create(MyResume myResume);
        Task<MyResume> GetById(string id);
        IMongoCollection<MyResume> GetMyResumeCollection();
    }
}
