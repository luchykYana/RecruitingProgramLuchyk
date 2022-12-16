using Microsoft.EntityFrameworkCore;
using RecruitingProgramLuchyk.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingProgramLuchyk.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Interviewer> Interviewers { get; set; }
        public DbSet<Interview> Interviews { get; set; }
    }
}
