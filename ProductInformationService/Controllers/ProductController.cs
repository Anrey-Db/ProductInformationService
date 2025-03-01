using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductInformationServices.BusinessLayer.Interface;

namespace ProductInformationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusinessLayer _productBusinessLayer;

        public ProductController(IProductBusinessLayer productBusinessLayer)
        {
            _productBusinessLayer = productBusinessLayer;
        }

    }
}
