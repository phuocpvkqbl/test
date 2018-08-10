using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace Thaco.Peugeot.Web.API.Controllers
{
    
    public class ValuesController : AbpApiController
    {
        public ValuesController()
        {
            LocalizationSourceName = "MySourceName";
        }
    
    }
}
