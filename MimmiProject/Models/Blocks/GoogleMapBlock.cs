using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace MimmiProject.Models.Blocks
{
    [ContentType(DisplayName = "GoogleMap", GUID = "b06cc9b3-61d0-40b1-ae11-fa40da98ea86", Description = "")]
    public class GoogleMapBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Latitude",
            Description = "Latitude",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual double Latitude { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Longitude",
            Description = "Longitude",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual double Longitude { get; set; }


    }
}