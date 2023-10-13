using MonApi.Dal.Entities;
using MonApi.Dal.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonApi.Dal.DataAccess
{
    public class UtilisateurService : IUtilisateurRepository
    {
        private readonly SqlConnection _connection;

        public UtilisateurService(SqlConnection connection)
        {
            _connection = connection;
        }

        public void Insert(Utilisateur utilisateur)
        {
            using(SqlCommand sqlCommand = _connection.CreateCommand())
            {
                sqlCommand.CommandText = "INSERT INTO Utilisateur (NomComplet, Email, Passwd) VALUES (@NomComplet, @Email, HASHBYTES('SHA2_512', @Passwd));";
                sqlCommand.Parameters.AddWithValue("NomComplet", utilisateur.NomComplet);
                sqlCommand.Parameters.AddWithValue("Email", utilisateur.Email);
                sqlCommand.Parameters.AddWithValue("Passwd", utilisateur.Passwd);
                _connection.Open();
                sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
