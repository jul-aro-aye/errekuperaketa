namespace Errekuperaketa.View
{
    partial class EzabatuakPanel
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvEzabatuta;
        private System.Windows.Forms.Button btnBerreskuratu;
        private System.Windows.Forms.Button btnBetirakoEzabatu;
        private System.Windows.Forms.Label lblInfo;

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
            this.dgvEzabatuta = new System.Windows.Forms.DataGridView();
            this.btnBerreskuratu = new System.Windows.Forms.Button();
            this.btnBetirakoEzabatu = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEzabatuta)).BeginInit();
            this.SuspendLayout();

            this.ClientSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pelikula Ezabatuak";
            this.Load += new System.EventHandler(this.DeletedPanel_Load);


            // dgvEzabatuta
            this.dgvEzabatuta.Location = new System.Drawing.Point(12, 40);
            this.dgvEzabatuta.Name = "dgvEzabatuta";
            this.dgvEzabatuta.Size = new System.Drawing.Size(560, 300);
            this.dgvEzabatuta.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                     System.Windows.Forms.AnchorStyles.Bottom |
                                     System.Windows.Forms.AnchorStyles.Left |
                                     System.Windows.Forms.AnchorStyles.Right;
            this.dgvEzabatuta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;


            // lblInfo
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInfo.Location = new System.Drawing.Point(12, 10);
            this.lblInfo.Text = "Ezabatuak - Pelikulen Kudeaketa";

            // btnBerreskuratu
            this.btnBerreskuratu.Location = new System.Drawing.Point(12, 350);
            this.btnBerreskuratu.Size = new System.Drawing.Size(140, 40);
            this.btnBerreskuratu.Text = "Berreskuratu";
            this.btnBerreskuratu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnBerreskuratu.Click += new System.EventHandler(this.btnBerreskuratu_Click);

            // btnBetirakoEzabatu
            this.btnBetirakoEzabatu.Location = new System.Drawing.Point(180, 350);
            this.btnBetirakoEzabatu.Size = new System.Drawing.Size(140, 40);
            this.btnBetirakoEzabatu.Text = "Betirako Ezabatu";
            this.btnBetirakoEzabatu.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.btnBetirakoEzabatu.Click += new System.EventHandler(this.btnBetirakoEzabatu_Click);

            // DeletedPanel Form
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.dgvEzabatuta);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBerreskuratu);
            this.Controls.Add(this.btnBetirakoEzabatu);
            this.Text = "Ezabatuak";
            this.Load += new System.EventHandler(this.DeletedPanel_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEzabatuta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}