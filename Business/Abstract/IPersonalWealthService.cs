using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.PersonalWealthDto;

namespace Business.Abstract
{
    public interface IPersonalWealthService
    {
        IDataResult<List<PersonalWealth>> GetAll();
        IDataResult<PersonalWealth> GetByPersonalWealthId(int personalWealth);

        IResult Add(PersonalWealthAddDto personalWealthAddDto);
        IResult Delete(PersonalWealthDeleteDto personalWealthDeleteDto);
        IResult Update(PersonalWealthUpdateDto PpersonalWealthUpdateDto);
    }
}