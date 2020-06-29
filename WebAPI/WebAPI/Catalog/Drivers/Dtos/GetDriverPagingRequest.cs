using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Catalog.Drivers.Dtos
{
    public class GetDriverPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
