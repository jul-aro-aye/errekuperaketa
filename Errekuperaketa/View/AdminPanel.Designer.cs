namespace Errekuperaketa.View
{
    partial class AdminPanel
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvAdminPelikulak;
        private System.Windows.Forms.TextBox txtIzenburua;
        private System.Windows.Forms.TextBox txtDeskribapena;
        private System.Windows.Forms.NumericUpDown nudEserlekuGuztira;
        private System.Windows.Forms.Button btnSortu;
        private System.Windows.Forms.Button btnAldatu;
        private System.Windows.Forms.Button btnSoftDelete;
        private System.Windows.Forms.Button btnEzabatuak;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblIzenburua;
        private System.Windows.Forms.Label lblDeskribapena;
        private System.Windows.Forms.Label lblEserlekuGuztira;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvAdminPelikulak = new System.Windows.Forms.DataGridView();
            this.txtIzenburua = new System.Windows.Forms.TextBox();
            this.txtDeskribapena = new System.Windows.Forms.TextBox();
            this.nudEserlekuGuztira = new System.Windows.Forms.NumericUpDown();
            this.btnSortu = new System.Windows.Forms.Button();
            this.btnAldatu = new System.Windows.Forms.Button();
            this.btnSoftDelete = new System.Windows.Forms.Button();
            this.btnEzabatuak = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblIzenburua = new System.Windows.Forms.Label();
            this.lblDeskribapena = new System.Windows.Forms.Label();
            this.lblEserlekuGuztira = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPelikulak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEserlekuGuztira)).BeginInit();
            this.SuspendLayout();

            // form konfigurazioa
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);


            // taularen konfigurazioa
            this.dgvAdminPelikulak.Location = new System.Drawing.Point(12, 12);
            this.dgvAdminPelikulak.Name = "dgvAdminPelikulak";
            this.dgvAdminPelikulak.Size = new System.Drawing.Size(550, 450);
            this.dgvAdminPelikulak.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                         System.Windows.Forms.AnchorStyles.Bottom |
                                         System.Windows.Forms.AnchorStyles.Left |
                                         System.Windows.Forms.AnchorStyles.Right;
            this.dgvAdminPelikulak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdminPelikulak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdminPelikulak.MultiSelect = false;
            this.dgvAdminPelikulak.ReadOnly = true;
            this.dgvAdminPelikulak.AllowUserToAddRows = false;
            this.dgvAdminPelikulak.AllowUserToDeleteRows = false;
            this.dgvAdminPelikulak.AllowUserToResizeRows = false;
            this.dgvAdminPelikulak.RowHeadersVisible = false;
            this.dgvAdminPelikulak.SelectionChanged += new System.EventHandler(this.dgvAdminPelikulak_SelectionChanged);

            
            // labelak
            this.lblIzenburua.Text = "Pelikula Izenburua:";
            this.lblIzenburua.Location = new System.Drawing.Point(580, 20);
            this.lblIzenburua.AutoSize = true;
            this.lblIzenburua.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            this.lblDeskribapena.Text = "Deskribapena:";
            this.lblDeskribapena.Location = new System.Drawing.Point(580, 70);
            this.lblDeskribapena.AutoSize = true;
            this.lblDeskribapena.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            this.lblEserlekuGuztira.Text = "Eserleku Guztira:";
            this.lblEserlekuGuztira.Location = new System.Drawing.Point(580, 150);
            this.lblEserlekuGuztira.AutoSize = true;
            this.lblEserlekuGuztira.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // textbox-ak
            this.txtIzenburua.Location = new System.Drawing.Point(580, 40);
            this.txtIzenburua.Width = 300;
            this.txtIzenburua.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            this.txtDeskribapena.Location = new System.Drawing.Point(580, 90);
            this.txtDeskribapena.Width = 300;
            this.txtDeskribapena.Height = 50;
            this.txtDeskribapena.Multiline = true;
            this.txtDeskribapena.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            this.nudEserlekuGuztira.Location = new System.Drawing.Point(580, 170);
            this.nudEserlekuGuztira.Minimum = 1;
            this.nudEserlekuGuztira.Maximum = 500;
            this.nudEserlekuGuztira.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // botoiak
            this.btnSortu.Location = new System.Drawing.Point(580, 210);
            this.btnSortu.Size = new System.Drawing.Size(140, 40);
            this.btnSortu.Text = "Sortu";
            this.btnSortu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSortu.Click += new System.EventHandler(this.btnSortu_Click);

            this.btnAldatu.Location = new System.Drawing.Point(740, 210);
            this.btnAldatu.Size = new System.Drawing.Size(140, 40);
            this.btnAldatu.Text = "Editatu";
            this.btnAldatu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAldatu.Click += new System.EventHandler(this.btnAldatu_Click);

            this.btnSoftDelete.Location = new System.Drawing.Point(580, 270);
            this.btnSoftDelete.Size = new System.Drawing.Size(140, 40);
            this.btnSoftDelete.Text = "Ezabatu";
            this.btnSoftDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSoftDelete.Click += new System.EventHandler(this.btnSoftDelete_Click);

            this.btnEzabatuak.Location = new System.Drawing.Point(740, 270);
            this.btnEzabatuak.Size = new System.Drawing.Size(140, 40);
            this.btnEzabatuak.Text = "Pelikula ezabatuak";
            this.btnEzabatuak.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnEzabatuak.Click += new System.EventHandler(this.btnEzabatuak_Click);

            this.btnRefresh.Location = new System.Drawing.Point(580, 330);
            this.btnRefresh.Size = new System.Drawing.Size(140, 40);
            this.btnRefresh.Text = "Eguneratu";
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // form-era elementuak gehitzea
            this.Controls.Add(this.dgvAdminPelikulak);
            this.Controls.Add(this.lblIzenburua);
            this.Controls.Add(this.lblDeskribapena);
            this.Controls.Add(this.lblEserlekuGuztira);
            this.Controls.Add(this.txtIzenburua);
            this.Controls.Add(this.txtDeskribapena);
            this.Controls.Add(this.nudEserlekuGuztira);
            this.Controls.Add(this.btnSortu);
            this.Controls.Add(this.btnAldatu);
            this.Controls.Add(this.btnSoftDelete);
            this.Controls.Add(this.btnEzabatuak);
            this.Controls.Add(this.btnRefresh);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminPelikulak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEserlekuGuztira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}