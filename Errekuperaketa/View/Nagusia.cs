using System;
using System.Windows.Forms;

using Errekuperaketa.Controller;
using Errekuperaketa.Model;
using System.Collections.Generic;

namespace Errekuperaketa.View
{
    public partial class Nagusia : Form
    {
        private PelikulaController pelikulaController = new PelikulaController();
        public Nagusia()    
        {
            InitializeComponent();
        }

        private void KargatuPelikulak()
        {
            List<Pelikula> lista = pelikulaController.GetPelikulakAktiboak();

            dgvPelikulak.DataSource = null;
            dgvPelikulak.DataSource = lista;

            if (dgvPelikulak.Columns["Ezabatuta"] != null)
                dgvPelikulak.Columns["Ezabatuta"].Visible = false;

            // Zutabeen izen pertsonalizatuak
            if (dgvPelikulak.Columns["PelikulaId"] != null)
                dgvPelikulak.Columns["PelikulaId"].HeaderText = "ID";

            if (dgvPelikulak.Columns["Izenburua"] != null)
                dgvPelikulak.Columns["Izenburua"].HeaderText = "Pelikula";

            if (dgvPelikulak.Columns["Deskribapena"] != null)
                dgvPelikulak.Columns["Deskribapena"].HeaderText = "Deskribapena";

            if (dgvPelikulak.Columns["EserlekuGuztira"] != null)
                dgvPelikulak.Columns["EserlekuGuztira"].HeaderText = "Eserlekuak Guztira";

            if (!dgvPelikulak.Columns.Contains("EserlekuLibreak"))
            {
                DataGridViewTextBoxColumn libreCol = new DataGridViewTextBoxColumn();
                libreCol.Name = "EserlekuLibreak";
                libreCol.HeaderText = "Eserleku libreak";
                libreCol.ReadOnly = true;
                dgvPelikulak.Columns.Add(libreCol);
            }

            // Eserleku libreak kalkulatu
            foreach (DataGridViewRow row in dgvPelikulak.Rows)
            {
                Pelikula p = row.DataBoundItem as Pelikula;
                int erreserbatutakoak = pelikulaController.GetEserlekuErreserbatutakoak(p.PelikulaId);
                row.Cells["EserlekuLibreak"].Value = p.EserlekuGuztira - erreserbatutakoak;
            }

        }

        private void FormNagusia_Load(object sender, EventArgs e)
        {
            KargatuPelikulak();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KargatuPelikulak();
        }

        private void eserlekuLibreak(object sender, EventArgs e)
        {
            // Libre dauden eserleku kopurua erakusteko
        }

        private void btnErreserbatu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Erreserba egiten");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPanel panel = new AdminPanel();

            panel.ShowDialog();
        }
    }
}
