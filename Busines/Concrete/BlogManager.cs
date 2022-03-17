using Busines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class BlogManager : IBlogService
    {

        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public IResult Add(Blog advert)
        {
            _blogDal.Add(advert);
            return new SuccessResult();
        }

        public IResult Delete(Blog advert)
        {
            _blogDal.Delete(advert);
            return new SuccessResult();
        }

        public IDataResult<List<Blog>> GetAll()
        {
            return new SuccessDataResult<List<Blog>>(_blogDal.GetAll());
        }

        public IDataResult<List<BlogDetailDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<BlogDetailDto>>(_blogDal.GetAdvertDetails());
        }

        public IDataResult<List<BlogDetailDto>> GetAllDetailsByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<BlogDetailDto>>(_blogDal.GetAdvertDetails(a => a.CategoryId == categoryId));
        }

        public IDataResult<List<BlogDetailDto>> GetAllDetailsById(int id)
        {
            return new SuccessDataResult<List<BlogDetailDto>>(_blogDal.GetAdvertDetails(c => c.Id == id));
        }

        public IDataResult<Blog> GetById(int Id)
        {
            return new SuccessDataResult<Blog>(_blogDal.Get(p => p.Id == Id));
        }

        public IResult Update(Blog advert)
        {
            _blogDal.Update(advert);
            return new SuccessResult();
        }
    }
}
