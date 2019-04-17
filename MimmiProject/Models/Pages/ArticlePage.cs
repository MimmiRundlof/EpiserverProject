using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace MimmiProject.Models.Pages
{
    [ContentType(DisplayName = "ArticlePage", GUID = "32a4c1a6-d9a5-4d58-944f-8c059af9e120", Description = "")]
    public class ArticlePage : SitePageData
    {
        [CultureSpecific]
        [Display(
           Name = "Heading",
           Description = "Heading",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Image",
          Description = "Image",
          GroupName = SystemTabNames.Content,
          Order = 1)]
        public virtual ContentReference Image { get; set; }


        [CultureSpecific]
        [Display(
           Name = "Mainbody",
           Description = "Mainbody",
           GroupName = SystemTabNames.Content,
           Order = 10)]
        public virtual XhtmlString MainBody { get; set; }


    }
}