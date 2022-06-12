using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs.FortuneDto;
using Entities.Concrete;
using DataAccess.Abstract;
using AutoMapper;

namespace Business.Concrete
{
    public class FortuneManager : IFortuneService
    {
        IFortuneDal _fortuneDal;
        IMapper _mapper;
        public FortuneManager(IFortuneDal fortuneDal, IMapper mapper)
        {
            _fortuneDal = fortuneDal;
            _mapper = mapper;
        }
        public IResult Add(FortuneAddDto fortuneAddDto)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(FortuneDeleteDto fortuneDeleteDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Fortune>> GetALl()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Fortune> GetByFortuneId()
        {
            throw new NotImplementedException();
        }

        public IResult Update(FortuneUpdateDto fortuneUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
