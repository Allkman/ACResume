using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ACResume.API.RepositoryInMemory.Interfaces;
using ACResume.DAL.Models;
using ACResume.API.Services.Interfaces;
using MongoDB.Driver;

namespace ACResume.API.RepositoryInMemory
{
    public class Repository : IRepository
    {
        private readonly IMongoCollection<MyResume> _myResume;
        public Repository(IMyResumeDbClient dbClient)
        {
            _myResume = dbClient.GetMyResumeCollection();            
        }
        public async Task<MyResume> CreateMyResume(MyResume myResume)
        {
            await Task.Delay(1);
            _myResume.InsertOne(myResume);
            return myResume;
        }
        public async Task<MyResume> GetMyResumeById(string id)
        {
            var result = await _myResume.Find(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }
        public async Task<List<MyResume>> GetMyResume()
        {
            return await _myResume.Find(myResume => true).ToListAsync();
        }
    }
}
