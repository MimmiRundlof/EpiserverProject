using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MimmiProject.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "019ce2f7-90a7-42e2-8b9b-f7b8999ed728", Description = "")]
    public class StartPage : SitePageData
    {
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }

    }
}