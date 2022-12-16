using RecruitingProgramLuchyk.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingProgramLuchyk.Data.Interfaces
{
    interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }

    }
}
