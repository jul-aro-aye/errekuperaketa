using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Errekuperaketa.Controller;
using Errekuperaketa.Model;

namespace Errekuperaketa.View
{
    public partial class AdminPanel : Form
    {
        private PelikulaController pelikulaController = new PelikulaController();

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            KargatuPelikulak();
        }

        private void KargatuPelikulak()
        {
            List<Pelikula> lista = pelikulaController.GetPelikulakGuztiak();

            dgvAdminPelikulak.DataSource = null;
            dgvAdminPelikulak.DataSource = lista;

            // Zutabeen izen pertsonalizatuak
            if (dgvAdminPelikulak.Columns["PelikulaId"] != null)
                dgvAdminPelikulak.Columns["PelikulaId"].HeaderText = "ID";

            if (dgvAdminPelikulak.Columns["Izenburua"] != null)
                dgvAdminPelikulak.Columns["Izenburua"].HeaderText = "Pelikula";

            if (dgvAdminPelikulak.Columns["Deskribapena"] != null)
                dgvAdminPelikulak.Columns["Deskribapena"].HeaderText = "Deskribapena";

            if (dgvAdminPelikulak.Columns["EserlekuGuztira"] != null)
                dgvAdminPelikulak.Columns["EserlekuGuztira"].HeaderText = "Eserleku Guztira";

            if (dgvAdminPelikulak.Columns["Ezabatuta"] != null)
                dgvAdminPelikulak.Columns["Ezabatuta"].HeaderText = "Ezabatua";

            // Eserleku libreak zutabe berria gehitu
            if (!dgvAdminPelikulak.Columns.Contains("EserlekuLibreak"))
            {
                DataGridViewTextBoxColumn libreCol = new DataGridViewTextBoxColumn();
                libreCol.Name = "EserlekuLibreak";
                libreCol.HeaderText = "Eserleku libreak";
                libreCol.ReadOnly = true;
                dgvAdminPelikulak.Columns.Add(libreCol);

                // EserlekuGuztira zutabearen ondoren erakusteko
                if (dgvAdminPelikulak.Columns["EserlekuGuztira"] != null)
                {
                    libreCol.DisplayIndex = dgvAdminPelikulak.Columns["EserlekuGuztira"].DisplayIndex + 1;
                }
            }

            // Eserleku libreak kalkulatu
            foreach (DataGridViewRow row in dgvAdminPelikulak.Rows)
            {
                Pelikula p = row.DataBoundItem as Pelikula;
                int erreserbatutakoak = pelikulaController.GetEserlekuErreserbatutakoak(p.PelikulaId);
                row.Cells["EserlekuLibreak"].Value = p.EserlekuGuztira - erreserbatutakoak;
            }

            dgvAdminPelikulak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAdminPelikulak.Columns["PelikulaId"].DisplayIndex = 0;
            dgvAdminPelikulak.Columns["Izenburua"].DisplayIndex = 1;
            dgvAdminPelikulak.Columns["Deskribapena"].DisplayIndex = 2;
            dgvAdminPelikulak.Columns["EserlekuGuztira"].DisplayIndex = 3;
            dgvAdminPelikulak.Columns["EserlekuLibreak"].DisplayIndex = 4;
        }

        // Sortu pelikula
        private void btnSortu_Click(object sender, EventArgs e)
        {
            string izen = txtIzenburua.Text;
            string desk = txtDeskribapena.Text;
            int eserleku = (int)nudEserlekuGuztira.Value;

            pelikulaController.SortuPelikula(izen, desk, eserleku);
            KargatuPelikulak();
            MessageBox.Show("Pelikula sortua!");
        }

        // Aldatu pelikula
        private void btnAldatu_Click(object sender, EventArgs e)
        {
            if (dgvAdminPelikulak.SelectedRows.Count == 0) return;

            int id = (int)dgvAdminPelikulak.SelectedRows[0].Cells["PelikulaId"].Value;
            string izen = txtIzenburua.Text;
            string desk = txtDeskribapena.Text;
            int eserleku = (int)nudEserlekuGuztira.Value;

            pelikulaController.AldatuPelikula(id, izen, desk, eserleku);
            KargatuPelikulak();
            MessageBox.Show("Pelikula aldatu da!");
        }

        // Soft Delete
        private void btnSoftDelete_Click(object sender, EventArgs e)
        {
            if (dgvAdminPelikulak.SelectedRows.Count == 0) return;

            int id = (int)dgvAdminPelikulak.SelectedRows[0].Cells["PelikulaId"].Value;
            pelikulaController.SoftDelete(id);
            KargatuPelikulak();
        }

        // Hard Delete
        private void btnEzabatuak_Click(object sender, EventArgs e)
        {
            EzabatuakPanel dp = new EzabatuakPanel();
            dp.ShowDialog();
        }

        // Aukeratutako pelikula txt-n erakustea
        private void dgvAdminPelikulak_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdminPelikulak.SelectedRows.Count == 0) return;

            txtIzenburua.Text = dgvAdminPelikulak.SelectedRows[0].Cells["Izenburua"].Value.ToString();
            txtDeskribapena.Text = dgvAdminPelikulak.SelectedRows[0].Cells["Deskribapena"].Value.ToString();
            nudEserlekuGuztira.Value = Convert.ToDecimal(dgvAdminPelikulak.SelectedRows[0].Cells["EserlekuGuztira"].Value);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KargatuPelikulak();
        }
    }
}