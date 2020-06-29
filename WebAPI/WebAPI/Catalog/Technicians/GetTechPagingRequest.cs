using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Catalog.Technicians
{
    public class GetTechPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
