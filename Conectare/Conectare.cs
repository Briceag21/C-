
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Conectare
{  public class Conectar
    { //fields
        protected string stringConnection;
        private string connectionString;

        public Conectar(string stringConnection)
        {
            this.stringConnection = stringConnection;
        } 
        public IEnumerable<CursaModel> GetAll()
        {
            var cursaList = new List<CursaModel>();
            using (var connection = new SqlConnection(stringConnection))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Cursa ";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cursaModel = new CursaModel();
                        cursaModel.IdCursa = (int)reader[0];
                        cursaModel.IdGara1 = (int)reader[1];
                        cursaModel.IdGara2 = (int)reader[2];
                        cursaModel.Pret = Convert.ToDouble(reader[3]);
                        cursaModel.IdOrar = (int)reader[4];
                        cursaModel.COmfort = (int)reader[5];
                        cursaModel.IDTren = (int)reader[6];
                        cursaModel.Stare = reader[7].ToString();
                        cursaList.Add(cursaModel);
                    }
                }
                connection.Close();
            }

            return cursaList;
        }
   public void Add(CursaModel cursaModel)
        {
            using (var connection = new SqlConnection(stringConnection))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
         
                command.CommandText = "INSERT INTO Cursa VALUES (@IDGara1, @IDGara2,@Pret,@IdOrar,@Comfort,@IdTren,@Stare)";
                //  command.Parameters.Add("@IDCursa", SqlDbType.Int).Value = cursaModel.Id;
                command.Parameters.Add("@IDGARA1", SqlDbType.Int).Value = cursaModel.IdGara1;
                command.Parameters.Add("@IDGARA2", SqlDbType.Int).Value = cursaModel.IdGara2;
                command.Parameters.Add("@PRET", SqlDbType.Money).Value = cursaModel.Pret;
                command.Parameters.Add("@IdOrar", SqlDbType.Int).Value = cursaModel.IdOrar;
                command.Parameters.Add("@Comfort", SqlDbType.Int).Value = cursaModel.COmfort;
                command.Parameters.Add("@IdTren", SqlDbType.Int).Value = cursaModel.IDTren;
                command.Parameters.Add("@Stare", SqlDbType.NVarChar).Value = cursaModel.Stare;
                command.ExecuteNonQuery();

            }  }
 public IEnumerable<CursaModel> TryOrar(int Gara2, int Orar)
        {
            using (var connection = new SqlConnection(stringConnection))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                 command.CommandText = "SELECT * FROM Cursa WHERE IDGARA2 = '" + Gara2 + "' AND IdOrar= '" + Orar + "'";
                //       command.CommandText = "SELECT * FROM Cursa WHERE IDGARA2 = '" + Gara2 + "'";
        //   command.CommandText = "SELECT * FROM Cursa WHERE IDGARA2 = '" +  Orar + "'";
                var cursaList = new List<CursaModel>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cursaModel = new CursaModel();
                        cursaModel.IdCursa = (int)reader[0];
                        cursaModel.IdGara1 = (int)reader[1];
                        cursaModel.IdGara2 = (int)reader[2];
                        cursaModel.Pret = Convert.ToDouble(reader[3]);
                        cursaModel.IdOrar = (int)reader[4];
                        cursaModel.COmfort = (int)reader[5];
                        cursaModel.IDTren = (int)reader[6];
                        cursaModel.Stare = reader[7].ToString();
                        cursaList.Add(cursaModel);
                    }
                    return cursaList;
      connection.Close();
                }  } }
 public IEnumerable<CursaModel> CMCursa()
        {
            using (var connection = new SqlConnection(stringConnection))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Cursa WHERE IdOrar =40";
                //       command.CommandText = "SELECT * FROM Cursa WHERE IDGARA2 = '" + Gara2 + "'";
                //   command.CommandText = "SELECT * FROM Cursa WHERE IDGARA2 = '" +  Orar + "'";
                var cursaList = new List<CursaModel>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cursaModel = new CursaModel();
                        cursaModel.IdCursa = (int)reader[0];
                        cursaModel.IdGara1 = (int)reader[1];
                        cursaModel.IdGara2 = (int)reader[2];
                        cursaModel.Pret = Convert.ToDouble(reader[3]);
                        cursaModel.IdOrar = (int)reader[4];
                        cursaModel.COmfort = (int)reader[5];
                        cursaModel.IDTren = (int)reader[6];
                        cursaModel.Stare = reader[7].ToString();
                        cursaList.Add(cursaModel);
                    }   return cursaList;
                    connection.Close();
                }
            }
        }
        public IEnumerable<CursaModel> PretulMediu()
        {
            using (var connection = new SqlConnection(stringConnection))
            using (var command = new SqlCommand())
            { connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT Avg(Pret) FROM Cursa ";
                var cursaList = new List<CursaModel>();
                using (var reader = command.ExecuteReader())
                { while (reader.Read())
                    {var cursaModel = new CursaModel();
                        cursaModel.Pret = Convert.ToDouble(reader[0]);
                        cursaList.Add(cursaModel);
                    }
               return cursaList;
 } }}
        public IEnumerable<CursaModel> TryComfort(int Comfort)
        {
            using (var connection = new SqlConnection(stringConnection))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Cursa WHERE Comfort = '" + Comfort + "' ";
                var cursaList = new List<CursaModel>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cursaModel = new CursaModel();
                        cursaModel.IdCursa = (int)reader[0];
                        cursaModel.IdGara1 = (int)reader[1];
                        cursaModel.IdGara2 = (int)reader[2];
                        cursaModel.Pret = Convert.ToDouble(reader[3]);
                        cursaModel.IdOrar = (int)reader[4];
                        cursaModel.COmfort = (int)reader[5];
                        cursaModel.IDTren = (int)reader[6];
                        cursaModel.Stare = reader[7].ToString();
                        cursaList.Add(cursaModel);
                    }
                    return cursaList;
                    connection.Close();
                }
            }
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(stringConnection))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "delete from Cursa where idCursa=@IdCursa";
                command.Parameters.Add("@idCursa", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
