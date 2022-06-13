using Business.Abstract;
using Entities.DTOs.PersonalWealthDto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalWealthsController : ControllerBase
    {
        IPersonalWealthService _personalWealthService;

        public PersonalWealthsController(IPersonalWealthService personalWealthService)
        {
            _personalWealthService = personalWealthService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            var result = _personalWealthService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByPersonalWealthId(int personalWealthId)
        {
            var result = _personalWealthService.GetByPersonalWealthId(personalWealthId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Add(FormFile file,PersonalWealthAddDto personalWealthAddDto)
        {
            var result = _personalWealthService.Add(file,personalWealthAddDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Delete(PersonalWealthDeleteDto personalWealthDeleteDto)
        {
            var result = _personalWealthService.Delete(personalWealthDeleteDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Update(FormFile file, PersonalWealthUpdateDto personalWealthUpdateDto)
        {
            var result = _personalWealthService.Update(file,personalWealthUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}