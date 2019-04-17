using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace MimmiProject.Models.Blocks
{
    [ContentType(DisplayName = "Picture Block", GUID = "9ddae2aa-632c-47f4-a590-7faaee8ca833", Description = "")]
    public class PictureBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Headline",
            Description = "Picture block headline",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Headline { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Picture block text",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Text { get; set; }

        [Display(Name = "Picture", GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }



    }
}