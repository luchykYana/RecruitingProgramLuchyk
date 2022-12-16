using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RecruitingProgramLuchyk.Data.Models;
using System.Linq;

namespace RecruitingProgramLuchyk.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                if (!context.Applicants.Any())
                {
                    context.Applicants.AddRange(
                        new Applicant
                    {
                        Name = "applicant name 1",
                        Surname = "applicant surname 1",
                        Skills = "skills1,skill2,skill3",
                        Level = Enums.Level.Junior
                    },
                   new Applicant
                   {
                       Name = "applicant name 2",
                       Surname = "applicant surname 2",
                       Skills = "skills4,skill5",
                       Level = Enums.Level.Trainee
                   },
                   new Applicant
                   {
                       Name = "applicant name 3",
                       Surname = "applicant surname 3",
                       Skills = "skills1,skill2,skill3,skills4,skill5,skills6,skill7",
                       Level = Enums.Level.Middle
                   });
                }
                context.SaveChanges();

                context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                if (!context.Interviewers.Any())
                {
                    context.Interviewers.AddRange(
                        new Interviewer
                    {
                        Name = "interviewer name 1",
                        Surname = "interviewer surname 1",
                        Skills = "skills1,skill2,skill3,skills4,skill5,skill6",
                        Level = Enums.Level.Senior
                    },
                    new Interviewer
                    {
                        Name = "interviewer name 2",
                        Surname = "interviewer surname 2",
                        Skills = "skills1,skill2,skill3",
                        Level = Enums.Level.Junior
                    },
                   new Interviewer
                   {
                       Name = "interviewer name 3",
                       Surname = "interviewer surname 3",
                       Skills = "skills1,skill2,skill3,skills4,skill5",
                       Level = Enums.Level.Middle
                   });
                }
                context.SaveChanges();

                context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                if (!context.Interviews.Any())
                {
                    context.Interviews.AddRange(
                        new Interview
                        {
                            Time = "11:20",
                            Applicant = context.Applicants.FirstOrDefault(),
                            Interviewer = context.Interviewers.FirstOrDefault(),
                            During = 20
                        },
                    new Interview
                    {
                        Time = "16:40",
                        Applicant = context.Applicants.FirstOrDefault(),
                        Interviewer = context.Interviewers.FirstOrDefault(),
                        During = 30
                    },
                   new Interview
                   {
                       Time = "113:20",
                       Applicant = context.Applicants.FirstOrDefault(),
                       Interviewer = context.Interviewers.FirstOrDefault(),
                       During = 25
                   });
                }
                context.SaveChanges();
            }
        }
    }
}
