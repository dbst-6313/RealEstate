using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IBlogCategoryService
    {
        IResult Add(BlogCategory blog);
        IResult Update(BlogCategory blog);
        IResult Delete(BlogCategory blog);
        IDataResult<List<BlogCategory>> GetAll();
        IDataResult<BlogCategory> GetById(int Id);
    }
}
