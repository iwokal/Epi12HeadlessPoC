using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace epi12.Models.Pages
{
    [ContentType(DisplayName = "Home Page", GUID = "{D1CDEDBE-6A72-4928-BAAD-F98942BB2D06}")]
    public class HomePage: BasePage
    {
        [Display(Name = "Image", Description = "Add an image (optional)",
                 GroupName = SystemTabNames.Content,
                 Order = 2)]
        public virtual ContentReference Image { get; set; }

        [Display(Name = "Main body", Description = "Add a body",
                 GroupName = SystemTabNames.Content,
                 Order = 3)]
        public virtual ContentArea MainBody { get; set; }
    }
}
