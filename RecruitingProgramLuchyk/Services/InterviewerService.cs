using RecruitingProgramLuchyk.Data;
using RecruitingProgramLuchyk.Data.Interfaces;
using RecruitingProgramLuchyk.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecruitingProgramLuchyk.Services
{
    public class InterviewerService : IService<Interviewer>
    {
        private AppDBContext _context;
        public InterviewerService(AppDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Interviewer> GetAll() => _context.Interviewers.ToList();

        public Interviewer GetById(int id) => _context.Interviewers.FirstOrDefault(item => item.Id == id);

        public void Add(Interviewer item)
        {
            var _item = new Interviewer()
            {
                Name = item.Name,
                Surname = item.Surname,
                Skills = item.Skills,
                Level = item.Level
            };

            _context.Interviewers.Add(_item);
            _context.SaveChanges();
        }

        public Interviewer UpdateById(int id, Interviewer item)
        {
            var _item = _context.Interviewers.FirstOrDefault(item => item.Id == id);

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
            var _item = _context.Interviewers.FirstOrDefault(item => item.Id == id);
            if (_item != null)
            {
                _context.Interviewers.Remove(_item);
                _context.SaveChanges();
            }
        }
    }
}
