﻿using Core.Entities;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}