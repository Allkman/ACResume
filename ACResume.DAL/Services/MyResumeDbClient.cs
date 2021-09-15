using ACResume.API.Services.Interfaces;
using ACResume.DAL.DbSettings;
using ACResume.DAL.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace ACResume.DAL.Services
{
    public class MyResumeDbClient : IMyResumeDbClient
    {
        private readonly IMongoCollection<MyResume> _myResume;

        public MyResumeDbClient(IOptions<MyResumeDbConfig> options)
        {
            var client = new MongoClient(options.Value.Connection_String);
            var database = client.GetDatabase(options.Value.Database_Name);
            _myResume = database.GetCollection<MyResume>(options.Value.MyResume_Collection_Name);
        }
        public async Task<MyResume> Create(MyResume myResume)
        {
            await _myResume.InsertOneAsync(myResume);
            return myResume;
        }
        public async Task<MyResume> GetById(string id)
        {
            return await _myResume.Find(myResume => myResume.Id == id).FirstOrDefaultAsync();
        }
        public IMongoCollection<MyResume> GetMyResumeCollection()
        {
            return _myResume;
        }
    }
}
