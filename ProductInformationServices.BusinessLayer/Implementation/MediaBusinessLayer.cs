using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInformationServices.Repository.Interface;
using ProductInformationServices.BusinessLayer.Interface;
using ProductInformationServices.Model.Metadata;

namespace ProductInformationServices.BusinessLayer.Implementation
{
    public class  MediaBusinessLayer :BusinessLayer<Media>,IMediaBusinessLayer
    {
        public MediaBusinessLayer(IMediaRepository repository): base(repository) 
        {
        }
    }
}
    