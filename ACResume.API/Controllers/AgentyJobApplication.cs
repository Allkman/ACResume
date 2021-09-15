using ACResume.API.RepositoryInMemory.Interfaces;
using ACResume.DAL.Models;
using ACResume.Shared.DTOs.Cards;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ACResume.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgentyJobApplication : ControllerBase
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;
        public AgentyJobApplication(IMapper mapper, IRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        [HttpPost]
        public async Task<ActionResult> Post(MyResumeCard myResumeCard)
        {
            var card = _mapper.Map<MyResume>(myResumeCard);
            await _repository.CreateMyResume(card);

            return CreatedAtRoute("GetMyResume", new {  id = myResumeCard.Id}, myResumeCard);
        }
        [HttpGet("{id}", Name = "GetMyResume")]
        public async Task<ActionResult<MyResumeCard>> Get(string id)
        {
            var myResumeCard = await _repository.GetMyResumeById(id);
            if (myResumeCard == null)
            {
                return NotFound();
            }

            return _mapper.Map<MyResumeCard>(myResumeCard);
        }

        [HttpGet]
        //just for testing, as if i am getting a collection of resumes. (but in my case its only one Resume...)
        public async Task<ActionResult> GetMyResume()
        {
            await Task.Delay(1);
            return Ok(_repository.GetMyResume());
        }
    }
}
