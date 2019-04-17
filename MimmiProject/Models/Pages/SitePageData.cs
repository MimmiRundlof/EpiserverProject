using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace MimmiProject.Models.Pages
{
    [ContentType(DisplayName = "SitePageData", GUID = "7e356992-3f77-4dc7-ae81-e69b298a7948", Description = "")]
    public abstract class SitePageData : PageData
    {
        [CultureSpecific]
        [Display(Name = "Meta title", GroupName = SiteTabNames.SEO, Order = 100)]
        [StringLength(60, MinimumLength = 5)]
        public virtual string MetaTitle { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta keywords",
        GroupName = SiteTabNames.SEO, Order = 200)]
        public virtual string MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(Name = "Meta description", GroupName = SiteTabNames.SEO, Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual string MetaDescription { get; set; }

      
    }
}