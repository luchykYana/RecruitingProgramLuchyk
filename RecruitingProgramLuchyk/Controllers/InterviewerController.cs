using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecruitingProgramLuchyk.Data.Interfaces;
using RecruitingProgramLuchyk.Data.Models;
using RecruitingProgramLuchyk.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitingProgramLuchyk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewerController : ControllerBase
    {
        public IService<Interviewer> _service;
        private IMapper _mapper;
        public InterviewerController(IService<Interviewer> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allItems = _service.GetAll();
            return Ok(allItems);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var item = _service.GetById(id);
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Add([FromBody] InterviewerViewModel item)
        {
            _service.Add(_mapper.Map<InterviewerViewModel, Interviewer>(item));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, [FromBody] InterviewerViewModel item)
        {
            var updatedItem = _service.UpdateById(id, _mapper.Map<InterviewerViewModel, Interviewer>(item));
            return Ok(updatedItem);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _service.DeleteById(id);
            return Ok();
        }
    }
}
