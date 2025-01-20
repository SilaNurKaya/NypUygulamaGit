namespace odevNyp
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.solPanel = new System.Windows.Forms.Panel();
            this.içerikPanel = new System.Windows.Forms.Panel();
            this.menuBtn = new System.Windows.Forms.Button();
            this.anaSayfaBtn = new System.Windows.Forms.Button();
            this.kayanPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.solPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.menuBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 30);
            this.panel1.TabIndex = 0;
            // 
            // solPanel
            // 
            this.solPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.solPanel.Controls.Add(this.kayanPanel);
            this.solPanel.Controls.Add(this.anaSayfaBtn);
            this.solPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.solPanel.Location = new System.Drawing.Point(0, 30);
            this.solPanel.Name = "solPanel";
            this.solPanel.Size = new System.Drawing.Size(200, 623);
            this.solPanel.TabIndex = 1;
            // 
            // içerikPanel
            // 
            this.içerikPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.içerikPanel.Location = new System.Drawing.Point(200, 30);
            this.içerikPanel.Name = "içerikPanel";
            this.içerikPanel.Size = new System.Drawing.Size(1032, 623);
            this.içerikPanel.TabIndex = 2;
            // 
            // menuBtn
            // 
            this.menuBtn.FlatAppearance.BorderSize = 0;
            this.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuBtn.Location = new System.Drawing.Point(53, 3);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(70, 25);
            this.menuBtn.TabIndex = 0;
            this.menuBtn.Text = "Menü";
            this.menuBtn.UseVisualStyleBackColor = true;
            // 
            // anaSayfaBtn
            // 
            this.anaSayfaBtn.FlatAppearance.BorderSize = 0;
            this.anaSayfaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaSayfaBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaSayfaBtn.Location = new System.Drawing.Point(37, 17);
            this.anaSayfaBtn.Name = "anaSayfaBtn";
            this.anaSayfaBtn.Size = new System.Drawing.Size(160, 40);
            this.anaSayfaBtn.TabIndex = 0;
            this.anaSayfaBtn.Text = "Ana Sayfa";
            this.anaSayfaBtn.UseVisualStyleBackColor = true;
            this.anaSayfaBtn.Click += new System.EventHandler(this.anaSayfaBtn_Click);
            // 
            // kayanPanel
            // 
            this.kayanPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.kayanPanel.Location = new System.Drawing.Point(3, 17);
            this.kayanPanel.Name = "kayanPanel";
            this.kayanPanel.Size = new System.Drawing.Size(20, 40);
            this.kayanPanel.TabIndex = 1;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 653);
            this.Controls.Add(this.içerikPanel);
            this.Controls.Add(this.solPanel);
            this.Controls.Add(this.panel1);
            this.Name = "AnaForm";
            this.Text = "KOMOREBI VITA HOTEL";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel1.ResumeLayout(false);
            this.solPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel solPanel;
        private System.Windows.Forms.Panel içerikPanel;
        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button anaSayfaBtn;
        private System.Windows.Forms.Panel kayanPanel;
    }
}

