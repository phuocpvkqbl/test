using System.ComponentModel.DataAnnotations;

namespace Thaco.Peugeot.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
