using Busines.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class BlogCategoryManager : IBlogCategoryService
    {

        IBlogCategoryDal _BlogCategoryDal;

        public BlogCategoryManager(IBlogCategoryDal BlogCategoryDal)
        {
            _BlogCategoryDal = BlogCategoryDal;
        }
        public IResult Add(BlogCategory advert)
        {
            _BlogCategoryDal.Add(advert);
            return new SuccessResult();
        }

        public IResult Delete(BlogCategory advert)
        {
            _BlogCategoryDal.Delete(advert);
            return new SuccessResult();
        }

        public IDataResult<List<BlogCategory>> GetAll()
        {
            return new SuccessDataResult<List<BlogCategory>>(_BlogCategoryDal.GetAll());
        }

        public IDataResult<BlogCategory> GetById(int Id)
        {
            return new SuccessDataResult<BlogCategory>(_BlogCategoryDal.Get(p => p.Id == Id));
        }

        public IResult Update(BlogCategory advert)
        {
            _BlogCategoryDal.Update(advert);
            return new SuccessResult();
        }
    }
}
