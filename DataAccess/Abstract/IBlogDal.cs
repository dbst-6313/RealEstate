using Business.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBlogDal:IEntityRepository<Blog>
    {
        List<BlogDetailDto> GetAdvertDetails(Expression<Func<Blog, bool>> filter = null);
    }
}
