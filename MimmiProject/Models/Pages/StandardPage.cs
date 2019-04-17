using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MimmiProject.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "0df759f8-310d-4f83-9bef-220e803e4d5a", Description = "")]
    public class StandardPage : SitePageData
    {

        [CultureSpecific]
        [Display(
           Name = "Mainbody",
           Description = "Mainbody",
           GroupName = SystemTabNames.Content,
           Order = 10)]
        public virtual XhtmlString MainBody { get; set; }


    }
}