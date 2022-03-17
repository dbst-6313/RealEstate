using Business.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAdvertDal:IEntityRepository<Advert>
    {
        List<AdvertDetailDto> GetAdvertDetails(Expression<Func<Advert, bool>> filter = null);
        List<AdvertDetailDto> GetAdvertDetailsById(int id);
    }
}
