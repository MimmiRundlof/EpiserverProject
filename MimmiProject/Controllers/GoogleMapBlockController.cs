using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using MimmiProject.Models.Blocks;
using MimmiProject.Models.ViewModels;

namespace MimmiProject.Controllers
{
    public class GoogleMapBlockController : BlockController<GoogleMapBlock>
    {
        private readonly IContentLoader loader;
        public GoogleMapBlockController(IContentLoader loader)
        {
            this.loader = loader;
        }
        public override ActionResult Index(GoogleMapBlock currentBlock)
        {
            var viewmodel = new GoogleMapViewModel
            {
                Latitude = currentBlock.Latitude,
                Longitude = currentBlock.Longitude

            };
            return PartialView(viewmodel);

        }
    }
}
