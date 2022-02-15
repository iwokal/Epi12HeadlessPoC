using epi12.Models.Media;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using epi12.Models.Blocks;
using EPiServer;
using EPiServer.Web;

namespace epi12.Models.Pages
{
    [ContentType(DisplayName = "Home Page", GUID = "{D1CDEDBE-6A72-4928-BAAD-F98942BB2D06}")]
    public class HomePage: BasePage
    {
        [Display(Name = "Subtitle", Description = "Add a subtitle",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Subtitle { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Hero Image",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [UIHint(UIHint.Image)]
        public virtual Url HeroImage { get; set; }

        [Display(Name = "Main body", Description = "Add a body",
                 GroupName = SystemTabNames.Content,
                 Order = 4)]
        [AllowedTypes(typeof(ContentBlock), typeof(ImageFile))]
        public virtual ContentArea MainContentArea { get; set; }

        [Required]
        [Display(   Name = "Link to details page",
                    GroupName = SystemTabNames.Content,
                    Order = 35)]
        public virtual PageReference DetailsLink { get; set; }


        ////broken properties
        [ScaffoldColumn(false)]
        public virtual ContentReference Image { get; set; }

        [ScaffoldColumn(false)]
        public virtual ContentArea MainBody { get; set; }
    }
}
