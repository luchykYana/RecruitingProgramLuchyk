using RecruitingProgramLuchyk.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingProgramLuchyk.Data.ViewModels
{
    public class InterviewViewModel
    {
        public string Time { get; set; }
        public ApplicantViewModel Applicant { get; set; }
        public InterviewerViewModel Interviewer { get; set; }
        public int During { get; set; }
    }
}
