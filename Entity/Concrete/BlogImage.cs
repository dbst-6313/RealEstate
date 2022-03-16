using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class BlogImage:IEntity
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string ImagePath { get; set; }
    }
}
