using RecruitingProgramLuchyk.Data;
using RecruitingProgramLuchyk.Data.Interfaces;
using RecruitingProgramLuchyk.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecruitingProgramLuchyk.Services
{
    public class ApplicantService : IService<Applicant>
    {
        private AppDBContext _context;
        public ApplicantService(AppDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Applicant> GetAll() => _context.Applicants.ToList();

        public Applicant GetById(int id) => _context.Applicants.FirstOrDefault(item => item.Id == id);

        public void Add(Applicant item)
        {
            var _item = new Applicant()
            {
                Name = item.Name,
                Surname = item.Surname,
                Skills = item.Skills,
                Level = item.Level
            };

            _context.Applicants.Add(_item);
            _context.SaveChanges();
        }

        public Applicant UpdateById(int id, Applicant item)
        {
            var _item = _context.Applicants.FirstOrDefault(item => item.Id == id);

            if (_item != null)
            {
                _item.Name = item.Name;
                _item.Surname = item.Surname;
                _item.Skills = item.Skills;
                _item.Level = item.Level;

                _context.SaveChanges();
            };

            return _item;
        }

        public void DeleteById(int id)
        {
            var _item = _context.Applicants.FirstOrDefault(item => item.Id == id);
            if (_item != null)
            {
                _context.Applicants.Remove(_item);
                _context.SaveChanges();
            }
        }
    }
}
