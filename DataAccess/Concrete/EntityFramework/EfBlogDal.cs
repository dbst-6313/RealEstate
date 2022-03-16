using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, RealEstateContext>, IBlogDal
    {
        public List<BlogDetailDto> GetAdvertDetails(Expression<Func<Blog, bool>> filter = null)
        {
          using(var context =new RealEstateContext())
            {
                var result = from a in filter == null ? context.blogs : context.blogs.Where(filter)
                             join c in context.blog_categories
                             on a.CategoryId equals c.Id
                             select new BlogDetailDto
                             {
                                 AddDate = a.AddDate,
                                 CategoryId = c.Id,
                                 CategoryName = c.Name,
                                 Header = a.Header,
                                 Id = a.Id,
                                 Images = (from i in context.blogs_image where i.BlogId == a.Id select i.ImagePath).ToList(),
                                 Text = a.Text,
                                 UpdateDate = a.UpdateDate,
                                 View = a.View
                             };
                return result.ToList();
            }
        }
    }
}
