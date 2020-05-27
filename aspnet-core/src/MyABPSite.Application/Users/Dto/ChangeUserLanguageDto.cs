using System.ComponentModel.DataAnnotations;

namespace MyABPSite.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}