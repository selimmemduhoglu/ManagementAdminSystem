using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorevcim.Core.DTOs
{
    public class ProductBrandsDto:BaseDto
    {
        public string BrandsName { get; set; }
        public string BrandsWebUrl { get; set; }
        public string Explanation { get; set; }
        public string logoBase64Content { get; set; }
        public string LogoFileName { get; set; }
        public string LogoFilePath { get; set; }
        public int ProductFeaturesId { get; set; }


    }
}
