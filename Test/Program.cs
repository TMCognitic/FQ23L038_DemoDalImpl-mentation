using MonApi.Dal.DataAccess;
using MonApi.Dal.Entities;
using MonApi.Dal.Repositories;
using System.Data.SqlClient;

SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MonApiDb;Integrated Security=True;Encrypt=False;");
IUtilisateurRepository repository = new UtilisateurService(sqlConnection);

Utilisateur utilisateur = new Utilisateur() { NomComplet = "Strimelle Aurélien", Email = "aurélien.strimelle@bstorm.be", Passwd = "Test1236=" };

repository.Insert(utilisateur);