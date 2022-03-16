using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IBlogImageService
    {
        IDataResult<List<BlogImage>> GetAll();
        IDataResult<BlogImage> GetById(int Id);
        IResult Add(BlogImage blogImage, IFormFile file);
        IResult Update(IFormFile file, BlogImage blogImage);
        IResult Delete(BlogImage blogImage);
    }
}
