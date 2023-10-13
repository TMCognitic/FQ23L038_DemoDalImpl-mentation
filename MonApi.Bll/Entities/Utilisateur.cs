using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApi.Bll.Entities
{
    public class Utilisateur
    {
        public int Id { get; init; }
        public string NomComplet { get; init; }
        public string Email { get; init; }
        public string Passwd { get; set; }
        public bool Actif { get; init; }

        internal Utilisateur(int id, string nomComplet, string email, string passwd, bool actif)
            : this(nomComplet, email, passwd)
        {
            Id = id;
            Actif = actif;
        }

        public Utilisateur(string nomComplet, string email, string passwd)
        {
            NomComplet = nomComplet;
            Email = email;
            Passwd = passwd;
        }
    }
}
