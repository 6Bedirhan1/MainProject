namespace c_access
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txadi = new System.Windows.Forms.TextBox();
            this.txtel = new System.Windows.Forms.TextBox();
            this.txadres = new System.Windows.Forms.TextBox();
            this.txsoyadi = new System.Windows.Forms.TextBox();
            this.txmail = new System.Windows.Forms.TextBox();
            this.lblad = new System.Windows.Forms.Label();
            this.lbltlfn = new System.Windows.Forms.Label();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.lbladres = new System.Windows.Forms.Label();
            this.lblsoyadi = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.adveyatlfn = new System.Windows.Forms.Label();
            this.txadtlfn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txadi
            // 
            this.txadi.BackColor = System.Drawing.SystemColors.Menu;
            this.txadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txadi.Location = new System.Drawing.Point(116, 106);
            this.txadi.Margin = new System.Windows.Forms.Padding(2);
            this.txadi.Multiline = true;
            this.txadi.Name = "txadi";
            this.txadi.Size = new System.Drawing.Size(162, 35);
            this.txadi.TabIndex = 0;
            // 
            // txtel
            // 
            this.txtel.BackColor = System.Drawing.SystemColors.Menu;
            this.txtel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtel.Location = new System.Drawing.Point(116, 223);
            this.txtel.Margin = new System.Windows.Forms.Padding(2);
            this.txtel.Multiline = true;
            this.txtel.Name = "txtel";
            this.txtel.Size = new System.Drawing.Size(162, 35);
            this.txtel.TabIndex = 1;
            // 
            // txadres
            // 
            this.txadres.BackColor = System.Drawing.SystemColors.Menu;
            this.txadres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txadres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txadres.Location = new System.Drawing.Point(116, 184);
            this.txadres.Margin = new System.Windows.Forms.Padding(2);
            this.txadres.Multiline = true;
            this.txadres.Name = "txadres";
            this.txadres.Size = new System.Drawing.Size(162, 35);
            this.txadres.TabIndex = 2;
            // 
            // txsoyadi
            // 
            this.txsoyadi.BackColor = System.Drawing.SystemColors.Menu;
            this.txsoyadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txsoyadi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txsoyadi.Location = new System.Drawing.Point(116, 145);
            this.txsoyadi.Margin = new System.Windows.Forms.Padding(2);
            this.txsoyadi.Multiline = true;
            this.txsoyadi.Name = "txsoyadi";
            this.txsoyadi.Size = new System.Drawing.Size(162, 35);
            this.txsoyadi.TabIndex = 3;
            // 
            // txmail
            // 
            this.txmail.BackColor = System.Drawing.SystemColors.Menu;
            this.txmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txmail.Location = new System.Drawing.Point(116, 262);
            this.txmail.Margin = new System.Windows.Forms.Padding(2);
            this.txmail.Multiline = true;
            this.txmail.Name = "txmail";
            this.txmail.Size = new System.Drawing.Size(162, 35);
            this.txmail.TabIndex = 4;
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.BackColor = System.Drawing.SystemColors.Info;
            this.lblad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(8, 118);
            this.lblad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(27, 17);
            this.lblad.TabIndex = 5;
            this.lblad.Text = "AD";
            // 
            // lbltlfn
            // 
            this.lbltlfn.AutoSize = true;
            this.lbltlfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltlfn.Location = new System.Drawing.Point(8, 273);
            this.lbltlfn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltlfn.Name = "lbltlfn";
            this.lbltlfn.Size = new System.Drawing.Size(39, 17);
            this.lbltlfn.TabIndex = 6;
            this.lbltlfn.Text = "MAİL";
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefon.Location = new System.Drawing.Point(8, 235);
            this.lbltelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(72, 17);
            this.lbltelefon.TabIndex = 7;
            this.lbltelefon.Text = "TELEFON";
            // 
            // lbladres
            // 
            this.lbladres.AutoSize = true;
            this.lbladres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbladres.Location = new System.Drawing.Point(8, 196);
            this.lbladres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbladres.Name = "lbladres";
            this.lbladres.Size = new System.Drawing.Size(55, 17);
            this.lbladres.TabIndex = 8;
            this.lbladres.Text = "ADRES";
            // 
            // lblsoyadi
            // 
            this.lblsoyadi.AutoSize = true;
            this.lblsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyadi.Location = new System.Drawing.Point(8, 157);
            this.lblsoyadi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsoyadi.Name = "lblsoyadi";
            this.lblsoyadi.Size = new System.Drawing.Size(56, 17);
            this.lblsoyadi.TabIndex = 9;
            this.lblsoyadi.Text = "SOYAD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(296, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 254);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(712, 375);
            this.btnekle.Margin = new System.Windows.Forms.Padding(2);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(134, 38);
            this.btnekle.TabIndex = 11;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(296, 375);
            this.btnsil.Margin = new System.Windows.Forms.Padding(2);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(143, 38);
            this.btnsil.TabIndex = 12;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // adveyatlfn
            // 
            this.adveyatlfn.AutoSize = true;
            this.adveyatlfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adveyatlfn.Location = new System.Drawing.Point(293, 24);
            this.adveyatlfn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adveyatlfn.Name = "adveyatlfn";
            this.adveyatlfn.Size = new System.Drawing.Size(191, 17);
            this.adveyatlfn.TabIndex = 14;
            this.adveyatlfn.Text = "AD VEYA TELEFON İLE ARA\r\n";
            // 
            // txadtlfn
            // 
            this.txadtlfn.BackColor = System.Drawing.SystemColors.Menu;
            this.txadtlfn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txadtlfn.Location = new System.Drawing.Point(296, 50);
            this.txadtlfn.Margin = new System.Windows.Forms.Padding(2);
            this.txadtlfn.Multiline = true;
            this.txadtlfn.Name = "txadtlfn";
            this.txadtlfn.Size = new System.Drawing.Size(211, 28);
            this.txadtlfn.TabIndex = 13;
            this.txadtlfn.TextChanged += new System.EventHandler(this.txadtlfn_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(907, 496);
            this.Controls.Add(this.adveyatlfn);
            this.Controls.Add(this.txadtlfn);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblsoyadi);
            this.Controls.Add(this.lbladres);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.lbltlfn);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.txmail);
            this.Controls.Add(this.txsoyadi);
            this.Controls.Add(this.txadres);
            this.Controls.Add(this.txtel);
            this.Controls.Add(this.txadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KİŞİ EKLEME VE SİLME";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txadi;
        private System.Windows.Forms.TextBox txtel;
        private System.Windows.Forms.TextBox txadres;
        private System.Windows.Forms.TextBox txsoyadi;
        private System.Windows.Forms.TextBox txmail;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lbltlfn;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.Label lbladres;
        private System.Windows.Forms.Label lblsoyadi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label adveyatlfn;
        private System.Windows.Forms.TextBox txadtlfn;
    }
}

