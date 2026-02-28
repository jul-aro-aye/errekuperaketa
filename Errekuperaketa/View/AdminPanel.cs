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
            dgvAdminPelikulak.DataSource = lista;

            dgvAdminPelikulak.Columns["PelikulaId"].HeaderText = "ID";
            dgvAdminPelikulak.Columns["Izenburua"].HeaderText = "Pelikula";
            dgvAdminPelikulak.Columns["Deskribapena"].HeaderText = "Deskribapena";
            dgvAdminPelikulak.Columns["EserlekuGuztira"].HeaderText = "Eserleku Guztira";
            dgvAdminPelikulak.Columns["Ezabatuta"].HeaderText = "Soft Delete";

            dgvAdminPelikulak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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