using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IBlogService
    {
        IResult Add(Blog blog);
        IResult Update(Blog blog);
        IResult Delete(Blog blog);
        IDataResult<List<Blog>> GetAll();
        IDataResult<List<BlogDetailDto>> GetAllDetails();
        IDataResult<List<BlogDetailDto>> GetAllDetailsById(int id);
        IDataResult<Blog> GetById(int Id);
    }
}
