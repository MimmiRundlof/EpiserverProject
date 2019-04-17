using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MimmiProject.Models.ViewModels
{
    public class ContactBlockViewModel
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public string Email { get; set; }

        public virtual ContentReference Image { get; set; }


    }
}