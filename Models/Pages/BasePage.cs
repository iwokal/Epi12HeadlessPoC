using EPiServer.Core;
using EPiServer.DataAbstraction;
using System.ComponentModel.DataAnnotations;

namespace epi12.Models.Pages
{
    public abstract class BasePage : PageData
    {
        [Display(Name = "Title", Description = "Add a title",
                 GroupName = SystemTabNames.Content,
                 Order = 1)]
        public virtual string Title { get; set; }
    }
}