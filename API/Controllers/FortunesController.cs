using Business.Abstract;
using Entities.DTOs.FortuneDto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FortunesController : ControllerBase
    {
        IFortuneService _fortuneService;

        public FortunesController(IFortuneService fortuneService)
        {
            _fortuneService = fortuneService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            var result = _fortuneService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByFavoriteId(int fortuneId)
        {
            var result = _fortuneService.GetByFortuneId(fortuneId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Add(FortuneAddDto fortuneAddDto)
        {
            var result = _fortuneService.Add(fortuneAddDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Delete(FortuneDeleteDto fortuneDeleteDto)
        {
            var result = _fortuneService.Delete(fortuneDeleteDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Update(FortuneUpdateDto fortuneUpdateDto)
        {
            var result = _fortuneService.Update(fortuneUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}