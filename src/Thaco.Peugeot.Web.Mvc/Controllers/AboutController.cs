﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Thaco.Peugeot.Controllers;

namespace Thaco.Peugeot.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PeugeotControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
