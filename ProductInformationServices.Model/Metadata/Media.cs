using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInformationServices.Model.Metadata
{
    public class Media
    {
        public int MediaId { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }

        public int ProductId { get; set; }
        public Product ?Product { get; set;}
    }
}
