﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using MimmiProject.Models.Pages;

namespace MimmiProject.Controllers
{
    public class StandardPageController : PageControllerBase<StandardPage>
    {
        public StandardPageController(IContentLoader loader) : base(loader)
        {
        }
        public ActionResult Index(StandardPage currentPage)
        {
            return View(CreatePageViewModel(currentPage));

        }
    }
}