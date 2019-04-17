using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MimmiProject.Models.Pages
{
    [ContentType(DisplayName = "EventPage", GUID = "29c500c3-16a4-4c48-82fa-f0de87b7a80e", Description = "")]
    public class EventPage : SitePageData
    {


        [CultureSpecific]
        [Display(Name = "Heading", Description = "Heading", GroupName = SystemTabNames.Content, Order = 100)]
        public virtual string Heading { get; set; }
        [CultureSpecific]
        [Display(Name = "Date", Description = "Date", GroupName = SystemTabNames.Content, Order = 100)]
        public virtual DateTime Date { get; set; }

        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}