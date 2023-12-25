namespace string_ssınıfı
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnBuyuk = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnKucult = new System.Windows.Forms.Button();
            this.btnSay = new System.Windows.Forms.Button();
            this.btnMesajVer = new System.Windows.Forms.Button();
            this.btnMetniBirlestir = new System.Windows.Forms.Button();
            this.btnİstedigisiradakiharf = new System.Windows.Forms.Button();
            this.btnKacıs = new System.Windows.Forms.Button();
            this.btnKArsılastır = new System.Windows.Forms.Button();
            this.btnBicim = new System.Windows.Forms.Button();
            this.btncompare = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(144, 9);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(381, 36);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Text = "Merhaba dünya ben ilayda";
            // 
            // btnBuyuk
            // 
            this.btnBuyuk.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyuk.Location = new System.Drawing.Point(9, 77);
            this.btnBuyuk.Name = "btnBuyuk";
            this.btnBuyuk.Size = new System.Drawing.Size(135, 30);
            this.btnBuyuk.TabIndex = 1;
            this.btnBuyuk.Text = "büyük";
            this.btnBuyuk.UseVisualStyleBackColor = true;
            this.btnBuyuk.Click += new System.EventHandler(this.btnBuyuk_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(12, 24);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(100, 20);
            this.txtMesaj.TabIndex = 2;
            // 
            // btnKucult
            // 
            this.btnKucult.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.Location = new System.Drawing.Point(153, 76);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(135, 31);
            this.btnKucult.TabIndex = 3;
            this.btnKucult.Text = "küçült";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // btnSay
            // 
            this.btnSay.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSay.Location = new System.Drawing.Point(12, 124);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(135, 30);
            this.btnSay.TabIndex = 4;
            this.btnSay.Text = "karekter Sayısını getir";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // btnMesajVer
            // 
            this.btnMesajVer.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajVer.Location = new System.Drawing.Point(153, 124);
            this.btnMesajVer.Name = "btnMesajVer";
            this.btnMesajVer.Size = new System.Drawing.Size(135, 30);
            this.btnMesajVer.TabIndex = 5;
            this.btnMesajVer.Text = "MesajVer";
            this.btnMesajVer.UseVisualStyleBackColor = true;
            this.btnMesajVer.Click += new System.EventHandler(this.btnMesajVer_Click);
            // 
            // btnMetniBirlestir
            // 
            this.btnMetniBirlestir.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetniBirlestir.Location = new System.Drawing.Point(12, 160);
            this.btnMetniBirlestir.Name = "btnMetniBirlestir";
            this.btnMetniBirlestir.Size = new System.Drawing.Size(135, 30);
            this.btnMetniBirlestir.TabIndex = 6;
            this.btnMetniBirlestir.Text = "metni Birleştir";
            this.btnMetniBirlestir.UseVisualStyleBackColor = true;
            this.btnMetniBirlestir.Click += new System.EventHandler(this.btnMetniBirlestir_Click);
            // 
            // btnİstedigisiradakiharf
            // 
            this.btnİstedigisiradakiharf.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİstedigisiradakiharf.Location = new System.Drawing.Point(153, 160);
            this.btnİstedigisiradakiharf.Name = "btnİstedigisiradakiharf";
            this.btnİstedigisiradakiharf.Size = new System.Drawing.Size(135, 30);
            this.btnİstedigisiradakiharf.TabIndex = 7;
            this.btnİstedigisiradakiharf.Text = "istediği sıradaki harf";
            this.btnİstedigisiradakiharf.UseVisualStyleBackColor = true;
            this.btnİstedigisiradakiharf.Click += new System.EventHandler(this.btnİstedigisıradakharf_Click);
            // 
            // btnKacıs
            // 
            this.btnKacıs.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKacıs.Location = new System.Drawing.Point(12, 196);
            this.btnKacıs.Name = "btnKacıs";
            this.btnKacıs.Size = new System.Drawing.Size(135, 30);
            this.btnKacıs.TabIndex = 8;
            this.btnKacıs.Text = "kaçış";
            this.btnKacıs.UseVisualStyleBackColor = true;
            this.btnKacıs.Click += new System.EventHandler(this.btnKacıs_Click);
            // 
            // btnKArsılastır
            // 
            this.btnKArsılastır.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKArsılastır.Location = new System.Drawing.Point(153, 196);
            this.btnKArsılastır.Name = "btnKArsılastır";
            this.btnKArsılastır.Size = new System.Drawing.Size(135, 30);
            this.btnKArsılastır.TabIndex = 9;
            this.btnKArsılastır.Text = "karsılastır";
            this.btnKArsılastır.UseVisualStyleBackColor = true;
            this.btnKArsılastır.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBicim
            // 
            this.btnBicim.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBicim.Location = new System.Drawing.Point(12, 232);
            this.btnBicim.Name = "btnBicim";
            this.btnBicim.Size = new System.Drawing.Size(135, 30);
            this.btnBicim.TabIndex = 10;
            this.btnBicim.Text = "Bicim";
            this.btnBicim.UseVisualStyleBackColor = true;
            this.btnBicim.Click += new System.EventHandler(this.btnBicim_Click);
            // 
            // btncompare
            // 
            this.btncompare.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncompare.Location = new System.Drawing.Point(153, 232);
            this.btncompare.Name = "btncompare";
            this.btncompare.Size = new System.Drawing.Size(135, 30);
            this.btncompare.TabIndex = 11;
            this.btncompare.Text = "compare";
            this.btncompare.UseVisualStyleBackColor = true;
            this.btncompare.Click += new System.EventHandler(this.btncompare_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(12, 268);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 30);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 314);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btncompare);
            this.Controls.Add(this.btnBicim);
            this.Controls.Add(this.btnKArsılastır);
            this.Controls.Add(this.btnKacıs);
            this.Controls.Add(this.btnİstedigisiradakiharf);
            this.Controls.Add(this.btnMetniBirlestir);
            this.Controls.Add(this.btnMesajVer);
            this.Controls.Add(this.btnSay);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.btnBuyuk);
            this.Controls.Add(this.lblMesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnBuyuk;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Button btnMesajVer;
        private System.Windows.Forms.Button btnMetniBirlestir;
        private System.Windows.Forms.Button btnİstedigisiradakiharf;
        private System.Windows.Forms.Button btnKacıs;
        private System.Windows.Forms.Button btnKArsılastır;
        private System.Windows.Forms.Button btnBicim;
        private System.Windows.Forms.Button btncompare;
        private System.Windows.Forms.Button btnRemove;
    }
}

