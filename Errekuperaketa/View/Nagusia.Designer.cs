namespace Errekuperaketa.View
{
    partial class Nagusia
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvPelikulak;
        private System.Windows.Forms.Button btnErreserbatu;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblEserlekuLibre;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPelikulak = new System.Windows.Forms.DataGridView();
            this.btnErreserbatu = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblEserlekuLibre = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPelikulak)).BeginInit();
            this.SuspendLayout();

            // dgvPelikulak
            this.dgvPelikulak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelikulak.Location = new System.Drawing.Point(12, 50);
            this.dgvPelikulak.Name = "dgvPelikulak";
            this.dgvPelikulak.Size = new System.Drawing.Size(600, 250);
            this.dgvPelikulak.SelectionChanged += new System.EventHandler(this.eserlekuLibreak);

            // lblInfo
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Text = "Zinema - Pelikulen Kudeaketa";

            // lblEserlekuLibre
            this.lblEserlekuLibre.AutoSize = true;
            this.lblEserlekuLibre.Location = new System.Drawing.Point(12, 320);
            this.lblEserlekuLibre.Text = "Eserleku libre: ";

            // btnErreserbatu
            this.btnErreserbatu.Location = new System.Drawing.Point(12, 350);
            this.btnErreserbatu.Size = new System.Drawing.Size(120, 40);
            this.btnErreserbatu.Text = "Erreserbatu";
            this.btnErreserbatu.Click += new System.EventHandler(this.btnErreserbatu_Click);

            // btnAdmin
            this.btnAdmin.Location = new System.Drawing.Point(150, 350);
            this.btnAdmin.Size = new System.Drawing.Size(120, 40);
            this.btnAdmin.Text = "Admin Panela";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(290, 350);
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.Text = "Eguneratu";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // FormNagusia
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.dgvPelikulak);
            this.Controls.Add(this.btnErreserbatu);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEserlekuLibre);

            this.Text = "Zinema App";
            this.Load += new System.EventHandler(this.FormNagusia_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPelikulak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
