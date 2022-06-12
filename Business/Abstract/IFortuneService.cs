using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.FortuneDto;

namespace Business.Abstract
{
    public interface IFortuneService
    {
        IDataResult<List<Fortune>> GetALl();
        IDataResult<Fortune> GetByFortuneId();

        IResult Add(FortuneAddDto fortuneAddDto);
        IResult Delete(FortuneDeleteDto fortuneDeleteDto);
        IResult Update(FortuneUpdateDto fortuneUpdateDto);
    }
}
