using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;


namespace MimmiProject.Models.Pages
{
    [ContentType(DisplayName = "SysRoot", GUID = "3fa7d9e7-877b-11d3-827c-00a024cacfcb", Description = "")]
    public class SysRoot : SitePageData
    {

        [Display(Name = "Logotype", GroupName = SiteTabNames.Header)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(GroupName = SiteTabNames.Footer)]
        public virtual string Phone { get; set; }

        [Display(GroupName = SiteTabNames.Footer)]
        [EmailAddress]
        public virtual string Email { get; set; }

        [Display(GroupName = SiteTabNames.Footer)]
        public virtual string Address { get; set; }

    }
}