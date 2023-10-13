using Microsoft.AspNetCore.Mvc;
using MonApi.Dal.Entities;
using MonApi.Dal.Repositories;
using MonApi.Models;

namespace MonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IUtilisateurRepository _utilisateurRepository;

        public UtilisateurController(IUtilisateurRepository utilisateurRepository)
        {
            _utilisateurRepository = utilisateurRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreerUtilisateurForm form) 
        {
            Utilisateur utilisateur = new Utilisateur() { NomComplet = form.NomComplet, Email = form.Email, Passwd = form.Passwd };

            _utilisateurRepository.Insert(utilisateur);
            return NoContent();
        }
    }
}
