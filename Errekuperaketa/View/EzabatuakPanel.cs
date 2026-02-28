using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Errekuperaketa.Controller;
using Errekuperaketa.Model;

namespace Errekuperaketa.View
{
    public partial class EzabatuakPanel : Form
    {
        private PelikulaController pelikulaController = new PelikulaController();

        public EzabatuakPanel()
        {
            InitializeComponent();
        }

        private void DeletedPanel_Load(object sender, EventArgs e)
        {
            KargatuEzabatuta();
        }

        private void KargatuEzabatuta()
        {
            List<Pelikula> lista = pelikulaController.GetPelikulakEzabatuta();
            dgvEzabatuta.DataSource = lista;

            // Ezabatu kolorea eta bestelako kolumnak ezkutatu nahi izanez gero
            if (dgvEzabatuta.Columns["Ezabatuta"] != null)
                dgvEzabatuta.Columns["Ezabatuta"].Visible = false;
        }

        private void btnBerreskuratu_Click(object sender, EventArgs e)
        {
            if (dgvEzabatuta.CurrentRow != null)
            {
                int id = (int)dgvEzabatuta.CurrentRow.Cells["PelikulaId"].Value;
                pelikulaController.Berreskuratu(id);
                KargatuEzabatuta();
            }
        }

        private void btnBetirakoEzabatu_Click(object sender, EventArgs e)
        {
            if (dgvEzabatuta.CurrentRow != null)
            {
                int id = (int)dgvEzabatuta.CurrentRow.Cells["PelikulaId"].Value;
                pelikulaController.HardDelete(id);
                KargatuEzabatuta();
            }
        }
    }
}