using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.PersonalWealthDto;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface IPersonalWealthService
    {
        IDataResult<List<PersonalWealth>> GetAll();
        IDataResult<PersonalWealth> GetByPersonalWealthId(int personalWealth);

        IResult Add(IFormFile file, PersonalWealthAddDto personalWealthAddDto);
        IResult Delete(PersonalWealthDeleteDto personalWealthDeleteDto);
        IResult Update(IFormFile file, PersonalWealthUpdateDto PpersonalWealthUpdateDto);
    }
}