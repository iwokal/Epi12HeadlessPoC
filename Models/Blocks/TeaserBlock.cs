using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace epi12.Models.Pages
{
    [ContentType(DisplayName = "TeaserBlock",
                 GUID = "38d57768-e09e-4da9-90df-54c73c61b270",
                 Description = "Heading and image.")]
    public class TeaserBlock : BlockData
    {
        [CultureSpecific]
        [Display(Name = "Heading",
                 Description = "Add a heading.",
                 GroupName = SystemTabNames.Content,
                 Order = 1)]
        public virtual String Heading { get; set; }

        [Display(Name = "Image", Description = "Add an image (optional)",
                 GroupName = SystemTabNames.Content,
                 Order = 2)]
        public virtual ContentReference Image { get; set; }
    }
}
