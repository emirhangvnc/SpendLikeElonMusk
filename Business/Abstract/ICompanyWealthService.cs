using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.CompanyWealthDto;

namespace Business.Abstract
{
    public interface ICompanyWealthService
    {
        IDataResult<List<CompanyWealth>> GetALl();
        IDataResult<CompanyWealth> GetByCompanyWealthId(int companyWealthId);

        IResult Add(CompanyWealthAddDto companyWealthAddDto);
        IResult Delete(CompanyWealthDeleteDto companyWealthDeleteDto);
        IResult Update(CompanyWealthUpdateDto companyWealthUpdateDto);
    }
}