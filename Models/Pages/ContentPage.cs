using epi12.Models.Media;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace epi12.Models.Pages
{
    [ContentType(DisplayName = "Content Page", GUID = "{B1CDEDBA-6A12-4928-BAAD-F98942BB2D06}")]
    public class ContentPage: BasePage
    {
        [Display(Name = "Description", Description = "Add a description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Description { get; set; }

        [Display(Name = "Main body", Description = "Add a body",
                 GroupName = SystemTabNames.Content,
                 Order = 4)]
        [AllowedTypes(typeof(ContentPage), typeof(ImageFile))]
        public virtual ContentArea MainContentArea { get; set; }
    }
}
