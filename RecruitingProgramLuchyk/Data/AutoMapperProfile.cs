using AutoMapper;
using RecruitingProgramLuchyk.Data.Models;
using RecruitingProgramLuchyk.Data.ViewModels;

namespace RecruitingProgramLuchyk.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Applicant, ApplicantViewModel>().ReverseMap();
            CreateMap<Interviewer, InterviewerViewModel>().ReverseMap();
            CreateMap<Interview, InterviewViewModel>().ReverseMap();
        }
    }
}
