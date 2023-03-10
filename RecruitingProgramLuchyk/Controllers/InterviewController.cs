using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RecruitingProgramLuchyk.Data.Interfaces;
using RecruitingProgramLuchyk.Data.Models;
using RecruitingProgramLuchyk.Data.ViewModels;

namespace RecruitingProgramLuchyk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        public IService<Interview> _service;
        private IMapper _mapper;
        public InterviewController(IService<Interview> service, IMapper mapper)
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
        public IActionResult Add([FromBody] InterviewViewModel item)
        {
            _service.Add(_mapper.Map<InterviewViewModel, Interview>(item));
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id, [FromBody] InterviewViewModel item)
        {
            var updatedItem = _service.UpdateById(id, _mapper.Map<InterviewViewModel, Interview>(item));
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
