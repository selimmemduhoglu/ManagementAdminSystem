﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.Models
{
    public class ProductProjects : BaseEntity
    {
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public string Explanation { get; set; }

        public int ProductFeaturesId { get; set; }
        public ProductFeatures ProductFeatures { get; set; }
    }
}
