using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApi.Dal.Entities
{
#nullable disable
    public class Utilisateur
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
        public bool Actif { get; set; }
    }
}
