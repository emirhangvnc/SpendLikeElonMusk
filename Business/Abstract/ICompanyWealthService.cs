using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.CompanyWealthDto;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICompanyWealthService
    {
        IDataResult<List<CompanyWealth>> GetAll();
        IDataResult<CompanyWealth> GetByCompanyWealthId(int companyWealthId);

        IResult Add(IFormFile file, CompanyWealthAddDto companyWealthAddDto);
        IResult Delete(CompanyWealthDeleteDto companyWealthDeleteDto);
        IResult Update(IFormFile file, CompanyWealthUpdateDto companyWealthUpdateDto);
    }
}