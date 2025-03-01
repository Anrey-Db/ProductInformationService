using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInformationServices.Model.Metadata
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int ProductId { get; set; }
        public Product? Product { get; set; }
        public string ReviewerName { get; set; }
        public string Content { get; set; }
        [Range (1,10)]
        public int Rating { get; set; }


    }
}
