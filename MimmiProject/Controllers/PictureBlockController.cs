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
    public class PictureBlockController : BlockController<PictureBlock>
    {
        private readonly IContentLoader loader;
        public PictureBlockController(IContentLoader loader)
        {
            this.loader = loader;
        }
        public override ActionResult Index(PictureBlock currentBlock)
        {
            var viewmodel = new PictureBlockViewModel
            {
                Headline = currentBlock.Headline,
                Text = currentBlock.Text,
                Image = currentBlock.Image
            };         
            return PartialView(viewmodel);

        }
    }
}
