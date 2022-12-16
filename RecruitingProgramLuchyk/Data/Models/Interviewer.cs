using RecruitingProgramLuchyk.Data.Enums;
using RecruitingProgramLuchyk.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingProgramLuchyk.Data.Models
{
    public class Interviewer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Skills { get; set; }
        public Level Level { get; set; }
    }
}
