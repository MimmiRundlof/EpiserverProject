using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using MimmiProject.Models.Pages;

namespace MimmiProject.Controllers
{
    public class EventPageController : PageControllerBase<EventPage>
    {

        public EventPageController(IContentLoader loader) : base(loader)
        {
        }

        public ActionResult Index(EventPage currentPage)
        {


            return View(CreatePageViewModel(currentPage));
        }
    }
}