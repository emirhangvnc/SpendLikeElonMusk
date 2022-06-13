using Business.Abstract;
using Entities.DTOs.CompanyWealthDto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyWealthsController : ControllerBase
    {
        ICompanyWealthService _companyWealthService;

        public CompanyWealthsController(ICompanyWealthService companyWealthService)
        {
            _companyWealthService = companyWealthService;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            var result = _companyWealthService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetByCompanyWealthId(int companyWealthId)
        {
            var result = _companyWealthService.GetByCompanyWealthId(companyWealthId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Add(IFormFile file, CompanyWealthAddDto companyWealthAddDto)
        {
            var result = _companyWealthService.Add(file,companyWealthAddDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]

        public IActionResult Delete(CompanyWealthDeleteDto companyWealthDeleteDto)
        {
            var result = _companyWealthService.Delete(companyWealthDeleteDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Update(IFormFile file,CompanyWealthUpdateDto companyWealthUpdateDto)
        {
            var result = _companyWealthService.Update(file,companyWealthUpdateDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}