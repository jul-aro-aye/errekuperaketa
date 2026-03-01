using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Errekuperaketa.Model;

namespace Errekuperaketa.Controller
{
    public class PelikulaController
    {
        private string connectionString =
            "server=localhost;port=3306;database=errekuperaketa;uid=root;pwd=1MG2024;";

        // exekutatzen den karpeta berean log.txt sortuko da
        private string logPath = Path.Combine(Application.StartupPath, "log.txt");

        // Pelikula aktiboak lortu (ezabatuta = false)
        public List<Pelikula> GetPelikulakAktiboak()
        {
            List<Pelikula> lista = new List<Pelikula>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT pelikulaId, izenburua, deskribapena, eserlekuGuztira, ezabatuta " +
                               "FROM pelikula WHERE ezabatuta = FALSE";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Pelikula p = new Pelikula()
                    {
                        PelikulaId = reader.GetInt32("pelikulaId"),
                        Izenburua = reader.GetString("izenburua"),
                        Deskribapena = reader.GetString("deskribapena"),
                        EserlekuGuztira = reader.GetInt32("eserlekuGuztira"),
                        Ezabatuta = reader.GetBoolean("ezabatuta")
                    };

                    lista.Add(p);
                }
            }

            return lista;
        }

        // Pelikula guztiak (AdminPanel-erako)
        public List<Pelikula> GetPelikulakGuztiak()
        {
            List<Pelikula> lista = new List<Pelikula>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT pelikulaId, izenburua, deskribapena, eserlekuGuztira, ezabatuta " +
                               "FROM pelikula";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(new Pelikula()
                    {
                        PelikulaId = reader.GetInt32("pelikulaId"),
                        Izenburua = reader.GetString("izenburua"),
                        Deskribapena = reader.GetString("deskribapena"),
                        EserlekuGuztira = reader.GetInt32("eserlekuGuztira"),
                        Ezabatuta = reader.GetBoolean("ezabatuta")
                    });
                }
            }
            return lista;
        }


        // AdminPanel-eko CRUD metodoak
        public void SortuPelikula(string izen, string desk, int eserlekuGuztira)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO pelikula (izenburua, deskribapena, eserlekuGuztira, ezabatuta) " +
                               "VALUES (@izen, @desk, @eserleku, FALSE)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@izen", izen);
                cmd.Parameters.AddWithValue("@desk", desk);
                cmd.Parameters.AddWithValue("@eserleku", eserlekuGuztira);
                cmd.ExecuteNonQuery();

                int id = (int)cmd.LastInsertedId;
                LogMugimendua($"Sortu | PelikulaId: {id} | {izen}");
            }
        }

        public void AldatuPelikula(int id, string izen, string desk, int eserlekuGuztira)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE pelikula SET izenburua=@izen, deskribapena=@desk, " +
                               "eserlekuGuztira=@eserleku WHERE pelikulaId=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@izen", izen);
                cmd.Parameters.AddWithValue("@desk", desk);
                cmd.Parameters.AddWithValue("@eserleku", eserlekuGuztira);
                cmd.ExecuteNonQuery();

                LogMugimendua($"Editatu | PelikulaId: {id} | {izen}");
            }
        }

        public void SoftDelete(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE pelikula SET ezabatuta=TRUE WHERE pelikulaId=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                LogMugimendua($"SoftDelete | PelikulaId: {id}");
            }
        }

        public void HardDelete(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM pelikula WHERE pelikulaId=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                LogMugimendua($"HardDelete | PelikulaId: {id}");
            }
        }

        // ekintzen loga gordetzeko metodoa
        private void LogMugimendua(string mezua)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(logPath, true))
                {
                    sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} | {mezua}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log errorea: " + ex.Message);
            }
        }

        public List<Pelikula> GetPelikulakEzabatuta()
        {
            List<Pelikula> lista = new List<Pelikula>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT pelikulaId, izenburua, deskribapena, eserlekuGuztira, ezabatuta " +
                               "FROM pelikula WHERE ezabatuta = TRUE";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Pelikula()
                    {
                        PelikulaId = reader.GetInt32("pelikulaId"),
                        Izenburua = reader.GetString("izenburua"),
                        Deskribapena = reader.GetString("deskribapena"),
                        EserlekuGuztira = reader.GetInt32("eserlekuGuztira"),
                        Ezabatuta = reader.GetBoolean("ezabatuta")
                    });
                }
            }

            return lista;
        }

        public void Berreskuratu(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE pelikula SET ezabatuta = FALSE WHERE pelikulaId = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                // Log fitxategia eguneratzeko metodoa baduzu
                LogMugimendua($"Berreskuratu | PelikulaId: {id}");
            }
        }

        public int GetEserlekuErreserbatutakoak(int pelikulaId)
        {
            int total = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SUM(eserlekuKopurua) as total FROM erreserba WHERE pelikulaId = @pid";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", pelikulaId);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                    total = Convert.ToInt32(result);
            }
            return total;
        }

        public void SortuErreserba(int pelikulaId, string izena, int kopurua)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO erreserba (pelikulaId, erreserbaIzena, eserlekuKopurua) " +
                               "VALUES (@pid, @izena, @kopurua)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pid", pelikulaId);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@kopurua", kopurua);
                cmd.ExecuteNonQuery();
            }

            LogMugimendua($"Erreserba: {izena}, PelikulaId: {pelikulaId}, Kopurua: {kopurua}");
        }

        public bool ErreserbakDitu(int pelikulaId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM erreserba WHERE pelikulaId = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", pelikulaId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}