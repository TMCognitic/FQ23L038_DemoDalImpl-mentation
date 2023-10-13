using MonApi.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApi.Dal.Repositories
{
    public interface IUtilisateurRepository
    {
        void Insert(Utilisateur utilisateur);
    }
}
