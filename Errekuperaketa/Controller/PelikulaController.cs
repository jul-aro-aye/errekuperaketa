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
    }
}