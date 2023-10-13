using MonApi.Bll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DalUtilisateur = MonApi.Dal.Entities.Utilisateur;

namespace MonApi.Bll.Mappers
{
    internal static class Mappers
    {
        internal static DalUtilisateur ToDal(this Utilisateur utilisateur)
        {
            return new DalUtilisateur() { 
                Id = utilisateur.Id, 
                NomComplet = utilisateur.NomComplet, 
                Email = utilisateur.Email, 
                Passwd = utilisateur.Passwd, 
                Actif = utilisateur.Actif 
            };
        }
    }
}
