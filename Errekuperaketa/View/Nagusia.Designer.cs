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

            // formularioaren ezarpenak
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zinema App";
            this.Load += new System.EventHandler(this.FormNagusia_Load);

            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(320, 26);
            this.lblInfo.Text = "Zinema - Pelikulen Kudeaketa";
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;

            // DATAGRIDVIEW
            this.dgvPelikulak.Location = new System.Drawing.Point(12, 50);
            this.dgvPelikulak.Name = "dgvPelikulak";
            this.dgvPelikulak.Size = new System.Drawing.Size(760, 320);

            // responsive egiteko
            this.dgvPelikulak.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // estiloak
            this.dgvPelikulak.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvPelikulak.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvPelikulak.MultiSelect = false;
            this.dgvPelikulak.ReadOnly = true;

            this.dgvPelikulak.AllowUserToAddRows = false;
            this.dgvPelikulak.AllowUserToDeleteRows = false;
            this.dgvPelikulak.AllowUserToResizeRows = false;

            this.dgvPelikulak.RowHeadersVisible = false;

            this.dgvPelikulak.SelectionChanged +=
                new System.EventHandler(this.eserlekuLibreak);

            // lblEserlekuLibre
            this.lblEserlekuLibre.AutoSize = true;
            this.lblEserlekuLibre.Location = new System.Drawing.Point(12, 385);
            this.lblEserlekuLibre.Name = "lblEserlekuLibre";
            this.lblEserlekuLibre.Size = new System.Drawing.Size(120, 13);
            this.lblEserlekuLibre.Text = "Eserleku libre: ";


            this.lblEserlekuLibre.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            // btnErreserbatu
            this.btnErreserbatu.Location = new System.Drawing.Point(12, 410);
            this.btnErreserbatu.Name = "btnErreserbatu";
            this.btnErreserbatu.Size = new System.Drawing.Size(120, 40);
            this.btnErreserbatu.Text = "Erreserbatu";

            this.btnErreserbatu.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            this.btnErreserbatu.Click +=
                new System.EventHandler(this.btnErreserbatu_Click);

            // btnAdmin
            this.btnAdmin.Location = new System.Drawing.Point(150, 410);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(120, 40);
            this.btnAdmin.Text = "Admin Panela";

            this.btnAdmin.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            this.btnAdmin.Click +=
                new System.EventHandler(this.btnAdmin_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(290, 410);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.Text = "Eguneratu";

            this.btnRefresh.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left;

            this.btnRefresh.Click +=
                new System.EventHandler(this.btnRefresh_Click);

            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.dgvPelikulak);
            this.Controls.Add(this.lblEserlekuLibre);
            this.Controls.Add(this.btnErreserbatu);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnRefresh);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPelikulak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
