using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MimmiProject.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "bd1f992d-20c8-4db2-b1a4-0d47ba97fa0d", Description = "")]
    public class NewsPage : SitePageData
    {
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}