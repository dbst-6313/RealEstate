using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class Blog:IEntity
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public int View { get; set; } = 0;
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int CategoryId { get; set; }
    }
}
