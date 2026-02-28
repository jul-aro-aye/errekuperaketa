namespace Errekuperaketa.View
{
    partial class ErreserbaPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPelikula;
        private System.Windows.Forms.Label lblLibre;
        private System.Windows.Forms.DataGridView dgvErreserbak;
        private System.Windows.Forms.Panel pnlBotoiak;
        private System.Windows.Forms.Button btnErreserbatu;
        private System.Windows.Forms.ComboBox cmbEserlekuKopurua;
        private System.Windows.Forms.TextBox txtIzena;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPelikula = new System.Windows.Forms.Label();
            this.lblLibre = new System.Windows.Forms.Label();
            this.dgvErreserbak = new System.Windows.Forms.DataGridView();
            this.pnlBotoiak = new System.Windows.Forms.Panel();
            this.btnErreserbatu = new System.Windows.Forms.Button();
            this.cmbEserlekuKopurua = new System.Windows.Forms.ComboBox();
            this.txtIzena = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvErreserbak)).BeginInit();
            this.pnlBotoiak.SuspendLayout();
            this.SuspendLayout();

            // form konfigurazioa
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.ErreserbaPanel_Load);

            // lblInfo
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblInfo.Text = "Zinema - Erreserbak";
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Padding = new System.Windows.Forms.Padding(10);

            // lblPelikula
            this.lblPelikula.AutoSize = true;
            this.lblPelikula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPelikula.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPelikula.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);

            // lblLibre
            this.lblLibre.AutoSize = true;
            this.lblLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLibre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLibre.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);

            // DataGridView
            //this.dgvErreserbak.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.dgvErreserbak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            //this.dgvErreserbak.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            //this.dgvErreserbak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            //this.dgvErreserbak.MultiSelect = false;

            this.dgvErreserbak.Location = new System.Drawing.Point(12, 12);
            this.dgvErreserbak.Name = "dgvErreserbaPelikulak";
            this.dgvErreserbak.Size = new System.Drawing.Size(550, 450);
            this.dgvErreserbak.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                         System.Windows.Forms.AnchorStyles.Bottom |
                                         System.Windows.Forms.AnchorStyles.Left |
                                         System.Windows.Forms.AnchorStyles.Right;
            this.dgvErreserbak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            
            // TextBox izena
            this.txtIzena.Width = 150;
            this.txtIzena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIzena.PlaceholderText = "Sartu zure izena";

            // ComboBox eserleku kopurua
            this.cmbEserlekuKopurua.Width = 100;
            this.cmbEserlekuKopurua.Anchor = System.Windows.Forms.AnchorStyles.Top;

            // Botoia
            this.btnErreserbatu.Size = new System.Drawing.Size(140, 40);
            this.btnErreserbatu.Text = "Erreserbatu";
            this.btnErreserbatu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnErreserbatu.Click += new System.EventHandler(this.btnErreserbatu_Click);

            // Panel botoiak
            this.pnlBotoiak.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotoiak.Width = 200;
            this.pnlBotoiak.Controls.Add(this.txtIzena);
            this.pnlBotoiak.Controls.Add(this.cmbEserlekuKopurua);
            this.pnlBotoiak.Controls.Add(this.btnErreserbatu);

            // Posizio botoiak eta inputak
            this.txtIzena.Location = new System.Drawing.Point(20, 20);
            this.cmbEserlekuKopurua.Location = new System.Drawing.Point(20, 70);
            this.btnErreserbatu.Location = new System.Drawing.Point(20, 120);

            // Form
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.dgvErreserbak);
            this.Controls.Add(this.pnlBotoiak);
            this.Controls.Add(this.lblLibre);
            this.Controls.Add(this.lblPelikula);
            this.Controls.Add(this.lblInfo);
            this.Text = "Erreserbak";
            this.Load += new System.EventHandler(this.ErreserbaPanel_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvErreserbak)).EndInit();
            this.pnlBotoiak.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}