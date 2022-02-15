//using System.ComponentModel.DataAnnotations;
//using EPiServer.Core;
//using EPiServer.DataAbstraction;
//using EPiServer.DataAnnotations;
//using EPiServer.Web;
//using EPiServer;
//using epi12.Models.Media;

//namespace epi12.Models.Pages
//{
//    /// <summary>
//    /// Model for Assets/Scripts/components/pages/LandingPage.vue
//    /// </summary>
//    [ContentType(DisplayName = "Landing Page", GUID = "46278700-3173-4945-b143-befe071f0f71", Description = "Starting page for the site")]
//    public class LandingPage : BasePage
//    {
//        [CultureSpecific]
//        [Display(
//            Name = "Hero Image",
//            GroupName = SystemTabNames.Content,
//            Order = 10)]
//        [UIHint(UIHint.Image)]
//        public virtual Url HeroImage { get; set; }

//        [CultureSpecific]
//        [Display(
//            Name = "Subtitle",
//            GroupName = SystemTabNames.Content,
//            Order = 30)]
//        public virtual string Subtitle { get; set; }

//        [Required]
//        [Display(
//            Name = "Link to Artists list",
//            GroupName = SystemTabNames.Content,
//            Order = 35)]
//        public virtual PageReference ArtistsLink { get; set; }

//        [CultureSpecific]
//        [Display(
//            Name = "Main Content Area",
//            GroupName = SystemTabNames.Content,
//            Order = 40)]
//        [AllowedTypes(typeof(ImageFile))]
//        public virtual ContentArea MainContentArea { get; set; }

//        [CultureSpecific]
//        [Display(
//            Name = "Footer Content Area",
//            GroupName = SystemTabNames.Content,
//            Order = 50)]
//        [AllowedTypes(typeof(ImageFile))]
//        public virtual ContentArea FooterContentArea { get; set; }
//    }
//}