using System.ComponentModel.DataAnnotations;

namespace Fanuc.Webmanagement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}