using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MimmiProject.Models.ViewModels
{
    public class PictureBlockViewModel
    {
        public string Headline { get; set; }

        public string Text { get; set; }

        public virtual ContentReference Image { get; set; }
    }
}