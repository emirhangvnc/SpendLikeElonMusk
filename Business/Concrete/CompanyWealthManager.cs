using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.DTOs.CompanyWealthDto;
using Entities.Concrete;
using DataAccess.Abstract;
using AutoMapper;

namespace Business.Concrete
{
    public class CompanyWealthManager : ICompanyWealthService
    {
        ICompanyWealthDal _companyWealthDal;
        IMapper _mapper;
        public CompanyWealthManager(ICompanyWealthDal companyWealthDal, IMapper mapper)
        {
            _companyWealthDal = companyWealthDal;
            _mapper = mapper;
        }
        public IResult Add(CompanyWealthAddDto companyWealthAddDto)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CompanyWealthDeleteDto companyWealthDeleteDto)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CompanyWealth>> GetALl()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CompanyWealth> GetByCompanyWealthId()
        {
            throw new NotImplementedException();
        }

        public IResult Update(CompanyWealthUpdateDto companyWealthUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
