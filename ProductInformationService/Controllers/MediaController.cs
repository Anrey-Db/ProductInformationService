using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductInformationServices.BusinessLayer.Interface;
using ProductInformationServices.Repository.Interface;
namespace ProductInformationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IMediaBusinessLayer _mediaBussinesLayer;
        public MediaController(IMediaBusinessLayer mediaBussinesLayer)
        {
            _mediaBussinesLayer = mediaBussinesLayer;
        }
    }
}
