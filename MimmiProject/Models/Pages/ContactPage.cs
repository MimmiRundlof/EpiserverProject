using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using MimmiProject.Models.Blocks;

namespace MimmiProject.Models.Pages
{
    [ContentType(DisplayName = "ContactPage", GUID = "69222f76-118f-4c56-89ae-142270ac136d", Description = "")]
    public class ContactPage : SitePageData
    {

        
        [Display(GroupName = SystemTabNames.Content, Order = 300)]
        public virtual GoogleMapBlock GoogleMapBlock { get; set; }
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }

    }
}