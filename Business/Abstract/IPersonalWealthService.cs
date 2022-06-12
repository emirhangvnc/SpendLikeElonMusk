using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.PersonalWeathDto;

namespace Business.Abstract
{
    public interface IPersonalWealthService
    {
        IDataResult<List<PersonalWealth>> GetAll();
        IDataResult<PersonalWealth> GetByPersonalWeathId();

        IResult Add(PersonalWeathAddDto personalWeathAddDto);
        IResult Delete(PersonalWeathDeleteDto personalWeathDeleteDto);
        IResult Update(PersonalWeathUpdateDto PpersonalWeathUpdateDto);
    }
}