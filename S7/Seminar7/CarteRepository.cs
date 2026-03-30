using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Seminar7
{
    public class CarteRepository
    {
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Razvan Petcu\\Desktop\\An2CSIE\\PAW\\NET_FrameWork_C_sharp\\S7\\Seminar7\\Database1.mdf\";Integrated Security=True";
        public List<Carte> GetAll()
        {
            var rezultat = new List<Carte>();
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using(var command = new SqlCommand("SELECT * FROM Carti", connection)) 
                {
                    using(var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var carte = new Carte();
                            carte.Id = reader.GetGuid(reader.GetOrdinal("Id")); //ori asa ori (Guid)reader["Id"]  e mai recoandat asa pt ca iiti dda o exceptie mai clara
                            carte.Titlu = reader.GetString(reader.GetOrdinal("Titlu"));
                            carte.Autor = reader.GetString(reader.GetOrdinal("Autor"));
                            carte.AnAparitie = reader.GetInt32(reader.GetOrdinal("AnAparitie"));
                            var genString = reader.GetString(reader.GetOrdinal("Gen"));
                            carte.Gen = (GenCarte)Enum.Parse(typeof(GenCarte), genString); //asa se ajunge de la string la enum

                            rezultat.Add(carte);
                        }
                    }
                }
            }

            return rezultat;
        }

        public Carte GetById(Guid id)
        {
            Carte rezultat = null;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand($"SELECT * FROM Carti WHERE Id = @id", connection))
                {
                    command.Parameters.AddWithValue("Id", id);  //facem asa ca sa evitam sql injectionurile

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            rezultat = new Carte();
                            rezultat.Id = reader.GetGuid(reader.GetOrdinal("Id")); //ori asa ori (Guid)reader["Id"]  e mai recoandat asa pt ca iiti dda o exceptie mai clara
                            rezultat.Titlu = reader.GetString(reader.GetOrdinal("Titlu"));
                            rezultat.Autor = reader.GetString(reader.GetOrdinal("Autor"));
                            rezultat.AnAparitie = reader.GetInt32(reader.GetOrdinal("AnAparitie"));
                            var genString = reader.GetString(reader.GetOrdinal("Gen"));
                            rezultat.Gen = (GenCarte)Enum.Parse(typeof(GenCarte), genString); //asa se ajunge de la string la enum
                        }
                    }
                }
            }

            return rezultat;
        }

        public void Add(Carte carte)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("INSERT INTO Carti (Id, Titlu, Autor, AnAparitie, Gen) VALUES (@Id, @Titlu, @Autor, @AnAparitie, @Gen)", connection))
                {
                    command.Parameters.AddWithValue("Id", carte.Id);
                    command.Parameters.AddWithValue("Titlu", carte.Titlu);
                    command.Parameters.AddWithValue("Autor", carte.Autor);
                    command.Parameters.AddWithValue("AnAparitie", carte.AnAparitie);
                    command.Parameters.AddWithValue("Gen", carte.Gen.ToString());

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(Carte carte)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("UPDATE Carti SET Titlu = @Titlu, Autor = @Autor, AnAparitie = @AnAparitie, Gen = @Gen WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("Id", carte.Id);
                    command.Parameters.AddWithValue("Titlu", carte.Titlu);
                    command.Parameters.AddWithValue("Autor", carte.Autor);
                    command.Parameters.AddWithValue("AnAparitie", carte.AnAparitie);
                    command.Parameters.AddWithValue("Gen", carte.Gen.ToString());

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (var command = new SqlCommand("DELETE FROM Carti WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
