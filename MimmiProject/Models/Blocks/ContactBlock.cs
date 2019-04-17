using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace MimmiProject.Models.Blocks
{
    [ContentType(DisplayName = "ContactBlock", GUID = "1fac7672-771f-4298-866a-918b3d531ba7", Description = "")]
    public class ContactBlock : BlockData
    {
        
                [CultureSpecific]
                
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }

        [CultureSpecific]
        [Display(
              Name = "Position",
              Description = "Position field's description",
              GroupName = SystemTabNames.Content,
              Order = 1)]
        public virtual string Position { get; set; }


        [CultureSpecific]
        [Display(
              Name = "Email",
              Description = "Email field's description",
              GroupName = SystemTabNames.Content,
              Order = 1)]
        public virtual string Email { get; set; }

        [Display(Name = "Picture", GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }


        [CultureSpecific]
        [Display(
              Name = "Phone",
              Description = "Phone field's description",
              GroupName = SystemTabNames.Content,
              Order = 1)]
        public virtual string Phone { get; set; }



    }
}