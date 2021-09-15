using ACResume.DAL.Models;
using ACResume.Shared.DTOs.Cards;
using AutoMapper;

namespace ACResume.API.AutoMapper
{
    public class MyResumeProfile : Profile
    {
        public MyResumeProfile()
        {
            CreateMap<MyResumeCard, MyResume>().ReverseMap();
        }
    }
}
