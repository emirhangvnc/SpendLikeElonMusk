using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.FortuneDto;

namespace Business.Abstract
{
    public interface IFortuneService
    {
        IDataResult<List<Fortune>> GetAll();
        IDataResult<Fortune> GetByFortuneId(int fortuneId);

        IResult Add(FortuneAddDto fortuneAddDto);
        IResult Delete(FortuneDeleteDto fortuneDeleteDto);
        IResult Update(FortuneUpdateDto fortuneUpdateDto);
    }
}