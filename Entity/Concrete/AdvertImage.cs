using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class AdvertImage:IEntity
    {
        public int Id { get; set; }
        public int AdvertId { get; set; }
        public string ImagePath { get; set; }
    }
}
