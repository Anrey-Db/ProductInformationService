using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInformationServices.Model;
using ProductInformationServices.Model.Metadata;
using ProductInformationServices.Repository.Interface;

namespace ProductInformationServices.Repository.Implementation
{
    public class MediaRepository : Repository<Media>, IMediaRepository
    {
        public MediaRepository(ProductDbContext context) : base(context)
        {
        }
    }
}
