using MonApi.Bll.Entities;
using MonApi.Bll.Repositories;
using IDalUtilisateurRepository = MonApi.Dal.Repositories.IUtilisateurRepository;
using DalUtilisateurService = MonApi.Dal.DataAccess.UtilisateurService;
using MonApi.Bll.Mappers;

namespace MonApi.Bll.DataAccess
{
    public class UtilisateurService : IUtilisateurRepository
    {
        public void Insert(Utilisateur utilisateur)
        {
            IDalUtilisateurRepository utilisateurRepository = new DalUtilisateurService();
            utilisateurRepository.Insert(utilisateur.ToDal());
        }
    }
}
