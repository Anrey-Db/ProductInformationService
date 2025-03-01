using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInformationServices.Model;
using ProductInformationServices.Model.Metadata;
using ProductInformationServices.Repository.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductInformationServices.Repository.Implementation
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductDbContext context) : base(context)
        {
        }
    }
    
}
