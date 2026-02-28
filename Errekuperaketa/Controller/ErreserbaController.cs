using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Errekuperaketa.Model;

namespace Errekuperaketa.Controller
{
    internal class ErreserbaController
    {
        private string connectionString =
            "server=localhost;port=3306;database=errekuperaketa;uid=root;pwd=1MG2024;";

        // Pelikula baten erreserba guztiak lortu
        public List<Erreserba> GetErreserbakByPelikula(int pelikulaId)
        {
            List<Erreserba> lista = new List<Erreserba>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT ErreserbaId, PelikulaId, ErreserbaIzena, EserlekuKopurua, erreserbaData
                                 FROM Erreserba
                                 WHERE PelikulaId = @pelikulaId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pelikulaId", pelikulaId);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Erreserba e = new Erreserba()
                    {
                        ErreserbaId = (int)reader["ErreserbaId"],
                        PelikulaId = (int)reader["PelikulaId"],
                        ErreserbaIzena = reader["ErreserbaIzena"].ToString(),
                        EserlekuKopurua = (int)reader["EserlekuKopurua"],
                        ErreserbaData = Convert.ToDateTime(reader["ErreserbaData"])
                    };

                    lista.Add(e);
                }
            }

            return lista;
        }

        // Erreserba sortu
        public void SortuErreserba(int pelikulaId, string izena, int eserlekuKopurua)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"INSERT INTO Erreserba
                                (PelikulaId, erreserbaIzena, EserlekuKopurua, erreserbaData)
                                VALUES
                                (@pelikulaId, @izena, @kopurua, NOW())";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@pelikulaId", pelikulaId);
                cmd.Parameters.AddWithValue("@izena", izena);
                cmd.Parameters.AddWithValue("@kopurua", eserlekuKopurua);

                cmd.ExecuteNonQuery();
            }
        }

        // Erreserbatutako eserleku kopurua kalkulatu
        public int GetEserlekuErreserbatutakoak(int pelikulaId)
        {
            int total = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT IFNULL(SUM(EserlekuKopurua),0)
                         FROM Erreserba
                         WHERE PelikulaId = @pelikulaId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@pelikulaId", pelikulaId);

                total = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return total;
        }
    }
}