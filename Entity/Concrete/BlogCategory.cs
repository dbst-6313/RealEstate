﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class BlogCategory:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
