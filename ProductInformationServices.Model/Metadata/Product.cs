using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductInformationServices.Model.Metadata
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        [Precision(18, 2)]
        public decimal ProductPrice { get; set; }
        public int ProductStock { get; set; }

       public List<Review> Reviews { get; set; } = new List<Review>();
       public List<Media> Medias { get; set; } = new List<Media>();
    }
}
