using MonApi.Bll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApi.Bll.Repositories
{
    public interface IUtilisateurRepository
    {
        void Insert(Utilisateur utilisateur);
    }
}
