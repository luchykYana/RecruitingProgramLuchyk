using RecruitingProgramLuchyk.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingProgramLuchyk.Data.ViewModels
{
    public class InterviewerViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Skills { get; set; }
        public Level Level { get; set; }
    }
}
