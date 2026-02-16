using System;
using System.Windows.Forms;

namespace Errekuperaketa.View
{
    public partial class Nagusia : Form
    {
        public Nagusia()    
        {
            InitializeComponent();
        }

        private void FormNagusia_Load(object sender, EventArgs e)
        {
            // Pelikulak datu base edo beste iturri batetik kargatzeko
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
            MessageBox.Show("Admnistrazio panela");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eguneraketa panela");
        }
    }
}
