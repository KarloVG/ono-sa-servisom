using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Protests.Api.Requests
{
    public class BaseRequest
    {
        [FromQuery(Name = "search")]
        public string Search { get; set; }

        [FromQuery(Name = "page")]
        public int Page { get; set; }

        [FromQuery(Name = "sort")]
        public string Sort { get; set; }
    }
}
