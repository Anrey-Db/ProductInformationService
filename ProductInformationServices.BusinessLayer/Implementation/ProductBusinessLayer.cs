using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInformationServices.BusinessLayer.Interface;
using ProductInformationServices.Model.Metadata;
using ProductInformationServices.Repository.Interface;

namespace ProductInformationServices.BusinessLayer.Implementation
{
    public class ProductBusinessLayer :BusinessLayer<Product>,IProductBusinessLayer
    {
        public ProductBusinessLayer(IProductRepository repository):base(repository)
        {
        
        }
    }
}
