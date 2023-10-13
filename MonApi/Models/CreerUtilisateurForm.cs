using System.ComponentModel.DataAnnotations;

namespace MonApi.Models
{
#nullable disable
    public class CreerUtilisateurForm
    {
        [Required]
        public string NomComplet { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Passwd { get; set; }

    }
}
