using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs.PersonalWeathDto;
using Entities.Concrete;
using DataAccess.Abstract;
using AutoMapper;

namespace Business.Concrete
{
    public class PersonalWealthManager : IPersonalWealthService
    {
        IPersonalWealthDal _personalWealthDal;
        IMapper _mapper;
        public PersonalWealthManager(IPersonalWealthDal personalWealthDal,IMapper mapper)
        {
            _personalWealthDal = personalWealthDal;
            _mapper = mapper;
        }
        public IResult Add(PersonalWeathAddDto personalWeathAddDto)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(PersonalWeathDeleteDto personalWeathDeleteDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Favorite>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Favorite> GetByPersonalWeathId()
        {
            throw new NotImplementedException();
        }

        public IResult Update(PersonalWeathUpdateDto personalWeathUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
