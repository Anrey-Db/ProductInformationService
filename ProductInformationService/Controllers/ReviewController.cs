using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductInformationServices.BusinessLayer.Interface;

namespace ProductInformationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewBusinessLayer _reviewBusinessLayer;

        public ReviewController(IReviewBusinessLayer reviewBusinessLayer) 
        {
            _reviewBusinessLayer = reviewBusinessLayer;
        }
    }
}
