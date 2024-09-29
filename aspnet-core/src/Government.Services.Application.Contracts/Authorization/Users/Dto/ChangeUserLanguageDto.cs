using System.ComponentModel.DataAnnotations;

namespace Government.Services.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
