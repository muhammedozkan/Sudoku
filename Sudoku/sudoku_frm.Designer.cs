namespace Sudoku
{
    partial class sudoku_frm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sudoku_frm));
            this.yeni_btn = new System.Windows.Forms.Button();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.yukle_btn = new System.Windows.Forms.Button();
            this.coz_btn = new System.Windows.Forms.Button();
            this.sayi1 = new System.Windows.Forms.Label();
            this.sayi2 = new System.Windows.Forms.Label();
            this.sayi3 = new System.Windows.Forms.Label();
            this.sayi7 = new System.Windows.Forms.Label();
            this.sayi8 = new System.Windows.Forms.Label();
            this.sayi9 = new System.Windows.Forms.Label();
            this.sayi4 = new System.Windows.Forms.Label();
            this.sayi5 = new System.Windows.Forms.Label();
            this.sayi6 = new System.Windows.Forms.Label();
            this.sayilarMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuSayi1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSayi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSayi3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSayi4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSayi5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSayi6 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSayi7 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSayi8 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSayi9 = new System.Windows.Forms.ToolStripMenuItem();
            this.mod_sec = new System.Windows.Forms.ComboBox();
            this.sayilarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // yeni_btn
            // 
            this.yeni_btn.Location = new System.Drawing.Point(395, 46);
            this.yeni_btn.Name = "yeni_btn";
            this.yeni_btn.Size = new System.Drawing.Size(99, 49);
            this.yeni_btn.TabIndex = 0;
            this.yeni_btn.Text = "Yeni Oyun";
            this.yeni_btn.UseVisualStyleBackColor = true;
            this.yeni_btn.Click += new System.EventHandler(this.yeni_btn_Click);
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(395, 196);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(99, 22);
            this.kaydet_btn.TabIndex = 1;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // yukle_btn
            // 
            this.yukle_btn.Location = new System.Drawing.Point(395, 168);
            this.yukle_btn.Name = "yukle_btn";
            this.yukle_btn.Size = new System.Drawing.Size(99, 22);
            this.yukle_btn.TabIndex = 2;
            this.yukle_btn.Text = "Yükle";
            this.yukle_btn.UseVisualStyleBackColor = true;
            this.yukle_btn.Click += new System.EventHandler(this.yukle_btn_Click);
            // 
            // coz_btn
            // 
            this.coz_btn.Location = new System.Drawing.Point(395, 101);
            this.coz_btn.Name = "coz_btn";
            this.coz_btn.Size = new System.Drawing.Size(99, 45);
            this.coz_btn.TabIndex = 3;
            this.coz_btn.Text = "Çöz";
            this.coz_btn.UseVisualStyleBackColor = true;
            this.coz_btn.Click += new System.EventHandler(this.coz_btn_Click);
            // 
            // sayi1
            // 
            this.sayi1.Image = global::Sudoku.Properties.Resources._1;
            this.sayi1.Location = new System.Drawing.Point(392, 241);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(30, 30);
            this.sayi1.TabIndex = 4;
            this.sayi1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayi2
            // 
            this.sayi2.Image = global::Sudoku.Properties.Resources._2;
            this.sayi2.Location = new System.Drawing.Point(428, 241);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(30, 30);
            this.sayi2.TabIndex = 5;
            this.sayi2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayi3
            // 
            this.sayi3.Image = global::Sudoku.Properties.Resources._3;
            this.sayi3.Location = new System.Drawing.Point(464, 241);
            this.sayi3.Name = "sayi3";
            this.sayi3.Size = new System.Drawing.Size(30, 30);
            this.sayi3.TabIndex = 6;
            this.sayi3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayi7
            // 
            this.sayi7.Image = global::Sudoku.Properties.Resources._7;
            this.sayi7.Location = new System.Drawing.Point(392, 313);
            this.sayi7.Name = "sayi7";
            this.sayi7.Size = new System.Drawing.Size(30, 30);
            this.sayi7.TabIndex = 7;
            this.sayi7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayi8
            // 
            this.sayi8.Image = global::Sudoku.Properties.Resources._8;
            this.sayi8.Location = new System.Drawing.Point(428, 313);
            this.sayi8.Name = "sayi8";
            this.sayi8.Size = new System.Drawing.Size(30, 30);
            this.sayi8.TabIndex = 8;
            this.sayi8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayi9
            // 
            this.sayi9.Image = global::Sudoku.Properties.Resources._9;
            this.sayi9.Location = new System.Drawing.Point(464, 313);
            this.sayi9.Name = "sayi9";
            this.sayi9.Size = new System.Drawing.Size(30, 30);
            this.sayi9.TabIndex = 9;
            this.sayi9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayi4
            // 
            this.sayi4.Image = global::Sudoku.Properties.Resources._4;
            this.sayi4.Location = new System.Drawing.Point(392, 277);
            this.sayi4.Name = "sayi4";
            this.sayi4.Size = new System.Drawing.Size(30, 30);
            this.sayi4.TabIndex = 10;
            this.sayi4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayi5
            // 
            this.sayi5.Image = global::Sudoku.Properties.Resources._5;
            this.sayi5.Location = new System.Drawing.Point(428, 277);
            this.sayi5.Name = "sayi5";
            this.sayi5.Size = new System.Drawing.Size(30, 30);
            this.sayi5.TabIndex = 11;
            this.sayi5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayi6
            // 
            this.sayi6.Image = global::Sudoku.Properties.Resources._6;
            this.sayi6.Location = new System.Drawing.Point(464, 277);
            this.sayi6.Name = "sayi6";
            this.sayi6.Size = new System.Drawing.Size(30, 30);
            this.sayi6.TabIndex = 12;
            this.sayi6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sayi_MouseDown);
            // 
            // sayilarMenu
            // 
            this.sayilarMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSayi1,
            this.MenuSayi2,
            this.MenuSayi3,
            this.MenuSayi4,
            this.MenuSayi5,
            this.MenuSayi6,
            this.MenuSayi7,
            this.MenuSayi8,
            this.MenuSayi9});
            this.sayilarMenu.Name = "sayilarMenu";
            this.sayilarMenu.Size = new System.Drawing.Size(81, 202);
            // 
            // MenuSayi1
            // 
            this.MenuSayi1.BackColor = System.Drawing.Color.White;
            this.MenuSayi1.Image = global::Sudoku.Properties.Resources._1;
            this.MenuSayi1.Name = "MenuSayi1";
            this.MenuSayi1.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi1.Text = "1";
            this.MenuSayi1.Click += new System.EventHandler(this.MenuSayi1_Click);
            // 
            // MenuSayi2
            // 
            this.MenuSayi2.BackColor = System.Drawing.Color.White;
            this.MenuSayi2.Image = global::Sudoku.Properties.Resources._2;
            this.MenuSayi2.Name = "MenuSayi2";
            this.MenuSayi2.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi2.Text = "2";
            this.MenuSayi2.Click += new System.EventHandler(this.MenuSayi2_Click);
            // 
            // MenuSayi3
            // 
            this.MenuSayi3.BackColor = System.Drawing.Color.White;
            this.MenuSayi3.Image = global::Sudoku.Properties.Resources._3;
            this.MenuSayi3.Name = "MenuSayi3";
            this.MenuSayi3.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi3.Text = "3";
            this.MenuSayi3.Click += new System.EventHandler(this.MenuSayi3_Click);
            // 
            // MenuSayi4
            // 
            this.MenuSayi4.BackColor = System.Drawing.Color.White;
            this.MenuSayi4.Image = global::Sudoku.Properties.Resources._4;
            this.MenuSayi4.Name = "MenuSayi4";
            this.MenuSayi4.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi4.Text = "4";
            this.MenuSayi4.Click += new System.EventHandler(this.MenuSayi4_Click);
            // 
            // MenuSayi5
            // 
            this.MenuSayi5.BackColor = System.Drawing.Color.White;
            this.MenuSayi5.Image = global::Sudoku.Properties.Resources._5;
            this.MenuSayi5.Name = "MenuSayi5";
            this.MenuSayi5.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi5.Text = "5";
            this.MenuSayi5.Click += new System.EventHandler(this.MenuSayi5_Click);
            // 
            // MenuSayi6
            // 
            this.MenuSayi6.BackColor = System.Drawing.Color.White;
            this.MenuSayi6.Image = global::Sudoku.Properties.Resources._6;
            this.MenuSayi6.Name = "MenuSayi6";
            this.MenuSayi6.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi6.Text = "6";
            this.MenuSayi6.Click += new System.EventHandler(this.MenuSayi6_Click);
            // 
            // MenuSayi7
            // 
            this.MenuSayi7.BackColor = System.Drawing.Color.White;
            this.MenuSayi7.Image = global::Sudoku.Properties.Resources._7;
            this.MenuSayi7.Name = "MenuSayi7";
            this.MenuSayi7.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi7.Text = "7";
            this.MenuSayi7.Click += new System.EventHandler(this.MenuSayi7_Click);
            // 
            // MenuSayi8
            // 
            this.MenuSayi8.BackColor = System.Drawing.Color.White;
            this.MenuSayi8.Image = global::Sudoku.Properties.Resources._8;
            this.MenuSayi8.Name = "MenuSayi8";
            this.MenuSayi8.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi8.Text = "8";
            this.MenuSayi8.Click += new System.EventHandler(this.MenuSayi8_Click);
            // 
            // MenuSayi9
            // 
            this.MenuSayi9.BackColor = System.Drawing.Color.White;
            this.MenuSayi9.Image = global::Sudoku.Properties.Resources._9;
            this.MenuSayi9.Name = "MenuSayi9";
            this.MenuSayi9.Size = new System.Drawing.Size(80, 22);
            this.MenuSayi9.Text = "9";
            this.MenuSayi9.Click += new System.EventHandler(this.MenuSayi9_Click);
            // 
            // mod_sec
            // 
            this.mod_sec.FormattingEnabled = true;
            this.mod_sec.Items.AddRange(new object[] {
            "Oyun Yarat",
            "Kolay",
            "Normal",
            "Zor"});
            this.mod_sec.Location = new System.Drawing.Point(395, 19);
            this.mod_sec.Name = "mod_sec";
            this.mod_sec.Size = new System.Drawing.Size(99, 21);
            this.mod_sec.TabIndex = 13;
            this.mod_sec.Text = "Kolay";
            // 
            // sudoku_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 356);
            this.Controls.Add(this.sayi6);
            this.Controls.Add(this.sayi5);
            this.Controls.Add(this.sayi4);
            this.Controls.Add(this.sayi9);
            this.Controls.Add(this.mod_sec);
            this.Controls.Add(this.sayi8);
            this.Controls.Add(this.sayi7);
            this.Controls.Add(this.sayi3);
            this.Controls.Add(this.sayi2);
            this.Controls.Add(this.sayi1);
            this.Controls.Add(this.coz_btn);
            this.Controls.Add(this.yukle_btn);
            this.Controls.Add(this.yeni_btn);
            this.Controls.Add(this.kaydet_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "sudoku_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.sudoku_frm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.sudoku_frm_Paint);
            this.sayilarMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yeni_btn;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button yukle_btn;
        private System.Windows.Forms.Button coz_btn;
        private System.Windows.Forms.Label sayi1;
        private System.Windows.Forms.Label sayi2;
        private System.Windows.Forms.Label sayi3;
        private System.Windows.Forms.Label sayi7;
        private System.Windows.Forms.Label sayi8;
        private System.Windows.Forms.Label sayi9;
        private System.Windows.Forms.Label sayi4;
        private System.Windows.Forms.Label sayi5;
        private System.Windows.Forms.Label sayi6;
        private System.Windows.Forms.ContextMenuStrip sayilarMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi1;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi2;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi3;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi4;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi5;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi6;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi7;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi8;
        private System.Windows.Forms.ToolStripMenuItem MenuSayi9;
        private System.Windows.Forms.ComboBox mod_sec;




    }
}

