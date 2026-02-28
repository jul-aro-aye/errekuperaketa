using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Errekuperaketa.Model;
using Errekuperaketa.Controller;

namespace Errekuperaketa.View
{
    public partial class ErreserbaPanel : Form
    {
        private ErreserbaController erreserbaController = new ErreserbaController();
        private Pelikula aukeratutakoPelikula;

        public ErreserbaPanel(Pelikula p)
        {
            aukeratutakoPelikula = p;
            InitializeComponent();
        }

        private void ErreserbaPanel_Load(object sender, EventArgs e)
        {
            lblPelikula.Text = aukeratutakoPelikula.Izenburua;

            KargatuEserlekuLibreak();
            KargatuCombo();
            KargatuErreserbak();
        }

        private void KargatuEserlekuLibreak()
        {
            int erreserbatutakoak =
                erreserbaController.GetEserlekuErreserbatutakoak(
                    aukeratutakoPelikula.PelikulaId);

            int libre =
                aukeratutakoPelikula.EserlekuGuztira - erreserbatutakoak;

            lblLibre.Text = $"Eserleku libre: {libre}";
        }

        private void KargatuCombo()
        {
            cmbEserlekuKopurua.Items.Clear();

            int erreserbatutakoak =
                erreserbaController.GetEserlekuErreserbatutakoak(
                    aukeratutakoPelikula.PelikulaId);

            int libre =
                aukeratutakoPelikula.EserlekuGuztira - erreserbatutakoak;

            int max = Math.Min(5, libre);

            for (int i = 1; i <= max; i++)
                cmbEserlekuKopurua.Items.Add(i);

            if (cmbEserlekuKopurua.Items.Count > 0)
                cmbEserlekuKopurua.SelectedIndex = 0;
        }

        private void KargatuErreserbak()
        {
            dgvErreserbak.DataSource =
                erreserbaController.GetErreserbakByPelikula(
                    aukeratutakoPelikula.PelikulaId);

            // Zutabe izenak modelarekin bat egon behar dira
            dgvErreserbak.Columns["ErreserbaId"].HeaderText = "ID";
            dgvErreserbak.Columns["ErreserbaIzena"].HeaderText = "Izena";
            dgvErreserbak.Columns["EserlekuKopurua"].HeaderText = "Eserlekuak";
            dgvErreserbak.Columns["ErreserbaData"].HeaderText = "Data";

            dgvErreserbak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnErreserbatu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIzena.Text))
            {
                MessageBox.Show("Sartu izena");
                return;
            }

            int kopurua =
                Convert.ToInt32(cmbEserlekuKopurua.SelectedItem);

            erreserbaController.SortuErreserba(
                aukeratutakoPelikula.PelikulaId,
                txtIzena.Text.Trim(),
                kopurua);

            MessageBox.Show("Erreserba eginda!");

            // Eguneratu datuak
            KargatuEserlekuLibreak();
            KargatuCombo();
            KargatuErreserbak();
        }
    }
}