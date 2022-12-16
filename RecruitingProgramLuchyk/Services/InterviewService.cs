using Microsoft.EntityFrameworkCore;
using RecruitingProgramLuchyk.Data;
using RecruitingProgramLuchyk.Data.Interfaces;
using RecruitingProgramLuchyk.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace RecruitingProgramLuchyk.Services
{
    public class InterviewService : IService<Interview>
    {
        private AppDBContext _context;
        public InterviewService(AppDBContext context)
        {
            _context = context;
        }
        public IEnumerable<Interview> GetAll() => _context.Interviews.Include(c => c.Applicant).Include(c => c.Interviewer).ToList();

        public Interview GetById(int id) => _context.Interviews.Include(c => c.Applicant).Include(c => c.Interviewer).FirstOrDefault(item => item.Id == id);

        public void Add(Interview item)
        {
            var _item = new Interview()
             {
                 Time = item.Time,
                 During = item.During,
                 Applicant = item.Applicant,
                 Interviewer = item.Interviewer
             };

                _context.Interviews.Add(_item);
                _context.SaveChanges();
        }

        public Interview UpdateById(int id, Interview item)
        {
            var _item = _context.Interviews.FirstOrDefault(item => item.Id == id);

            if (_item != null)
            {
                _item.Time = item.Time;
                _item.During = item.During;
                _item.Applicant = item.Applicant;
                _item.Interviewer = item.Interviewer;

                _context.SaveChanges();
            };

            return _item;
        }

        public void DeleteById(int id)
        {
            var _item = _context.Interviews.FirstOrDefault(item => item.Id == id);
            if (_item != null)
            {
                _context.Interviews.Remove(_item);
                _context.SaveChanges();
            }
        }
    }
}
