using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}