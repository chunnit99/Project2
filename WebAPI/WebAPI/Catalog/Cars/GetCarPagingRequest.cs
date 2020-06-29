using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Catalog.Cars
{
    public class GetCarPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
