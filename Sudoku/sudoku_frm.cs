using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Sudoku
{
    public partial class sudoku_frm : Form
    {
        int[,] sudoku = new int[9, 9];
        Sudoku_Kontrol kontrolet = new Sudoku_Kontrol();
        Sudoku_Coz coz = new Sudoku_Coz();


        public sudoku_frm()
        {
            InitializeComponent();
        }

        private void Sayi_Giris(object sender, EventArgs e)
        {
            if (((TextBox)(sender)).Text == "1" || ((TextBox)(sender)).Text == "2" || ((TextBox)(sender)).Text == "3" || ((TextBox)(sender)).Text == "4" || ((TextBox)(sender)).Text == "5" || ((TextBox)(sender)).Text == "6" || ((TextBox)(sender)).Text == "7" || ((TextBox)(sender)).Text == "8" || ((TextBox)(sender)).Text == "9")
            {
                if (kontrolet.Ekleme_Izın(sudoku, Convert.ToInt32(((TextBox)(sender)).Name.Substring(0, 1)), Convert.ToInt32(((TextBox)(sender)).Name.Substring(1, 1)), Convert.ToInt32(((TextBox)(sender)).Text)))
                {
                    sudoku[Convert.ToInt32(((TextBox)(sender)).Name.Substring(0, 1)),Convert.ToInt32(((TextBox)(sender)).Name.Substring(1, 1))]=Convert.ToInt32(((TextBox)(sender)).Text);
                }
                else
                {
                    sudoku[Convert.ToInt32(((TextBox)(sender)).Name.Substring(0, 1)), Convert.ToInt32(((TextBox)(sender)).Name.Substring(1, 1))] = 0;
                    ((TextBox)(sender)).Text = null;
                }
            }
            else
            {
                sudoku[Convert.ToInt32(((TextBox)(sender)).Name.Substring(0, 1)), Convert.ToInt32(((TextBox)(sender)).Name.Substring(1, 1))] = 0;
                ((TextBox)(sender)).Text = null;
            }

        }

        private void sudoku_frm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                     string isim = j.ToString() + i.ToString();
                     TextBox hucre = new TextBox();
                     hucre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                     hucre.Location = new System.Drawing.Point(i*35+20, j*35+20);
                     hucre.MaxLength = 1;
                     hucre.Multiline = true;
                     hucre.Name = isim;
                     hucre.Size = new System.Drawing.Size(30, 30);
                     hucre.TabIndex = 0;
                     hucre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                     hucre.BackColor = Color.GhostWhite;
                     hucre.AllowDrop = true;
                     hucre.TextChanged+=new EventHandler(Sayi_Giris);
                     hucre.DragDrop+=new DragEventHandler(hucre_DragDrop);
                     hucre.DragOver+=new DragEventHandler(hucre_DragOver);
                     hucre.Click += new EventHandler(hucre_Click);
                     Controls.Add(hucre);
                }
                
            }
           
        }

        private void hucre_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
			{
                sayilarMenu.Items[i].Enabled=false; 
			}
            
            for (int i = 1; i < 10; i++)
            {
                if (kontrolet.Ekleme_Izın(sudoku, Convert.ToInt32(((TextBox)(sender)).Name.Substring(0, 1)), Convert.ToInt32(((TextBox)(sender)).Name.Substring(1, 1)), i))
                {
                    sayilarMenu.Items[i-1].Enabled=true;
                }
            }

            sayilarMenu.Show(((TextBox)(sender)).Location.X + this.Location.X+40, ((TextBox)(sender)).Location.Y + this.Location.Y+28);
        }

        private void sudoku_frm_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem = new Pen(Brushes.Black, 3);
            e.Graphics.DrawLine(Pens.Chocolate, 18, 17, 332, 17);
            e.Graphics.DrawLine(kalem, 18, 122, 332, 122);
            e.Graphics.DrawLine(kalem, 18, 227, 332, 227);
            e.Graphics.DrawLine(Pens.Chocolate, 18, 332, 332, 332);

            e.Graphics.DrawLine(Pens.Chocolate, 17, 18, 17, 332);
            e.Graphics.DrawLine(kalem, 122, 18, 122, 332);
            e.Graphics.DrawLine(kalem, 227, 18, 227, 332);
            e.Graphics.DrawLine(Pens.Chocolate, 332, 18, 332, 332);

            e.Graphics.DrawLine(Pens.Black, 18, 52, 332, 52);
            e.Graphics.DrawLine(Pens.Black, 18, 87, 332, 87);
            e.Graphics.DrawLine(Pens.Black, 18, 157, 332, 157);
            e.Graphics.DrawLine(Pens.Black, 18, 192, 332, 192);
            e.Graphics.DrawLine(Pens.Black, 18, 262, 332, 262);
            e.Graphics.DrawLine(Pens.Black, 18, 297, 332, 297);

            e.Graphics.DrawLine(Pens.Black, 52, 18, 52, 332);
            e.Graphics.DrawLine(Pens.Black, 87, 18, 87, 332);
            e.Graphics.DrawLine(Pens.Black, 157, 18, 157, 332);
            e.Graphics.DrawLine(Pens.Black, 192, 18, 192, 332);
            e.Graphics.DrawLine(Pens.Black, 262, 18, 262, 332);
            e.Graphics.DrawLine(Pens.Black, 297, 18, 297, 332);

        }

        private void yeni_btn_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();

            int oyun = rdn.Next(1, 6);

            switch (mod_sec.Text)
            {
                case "Oyun Yarat":
                    TextBox hucre = new TextBox();

                    for (int i = 0; i <= Controls.Count - 1; i++)
            {
                if (Controls[i].GetType().Name == "TextBox")
                {
                    hucre = (TextBox)this.Controls[i];
                    hucre.Text = null;
                    hucre.ReadOnly = false;
                    hucre.BackColor = Color.GhostWhite;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = 0;
                }
            }
                    break;
                case "Kolay":
                    yukle("oyunlar/k" + oyun + ".sdk");
                    break;
                case "Normal":
                    yukle("oyunlar/n" + oyun + ".sdk");
                    break;
                case "Zor":
                    yukle("oyunlar/z" + oyun + ".sdk");
                    break;
            }
        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            if (kaydet())
            {
                MessageBox.Show("Başarı ile kaydedildi.", "Mesaj");
            }
            else
            {
                MessageBox.Show("Kayıt edilemedi.", "Mesaj");
            }
        }

        private void yukle_btn_Click(object sender, EventArgs e)
        {
            if (yukle())
            {
                MessageBox.Show("Başarı ile yüklendi.","Mesaj");
            }
            else
            {
                MessageBox.Show("Yüklenemedi", "Mesaj");
            }
            
        }

        bool kaydet()
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Title = "Sudoku Kaydet";
            kaydet.Filter = "Sudoku Dosyası (*.sdk) |*.sdk";
            if (kaydet.ShowDialog() != DialogResult.OK)
            {
                return false;
            }

            string veri = null;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    veri += sudoku[i, j] + ",";
                }
                veri += sudoku[i, 8] + "\r\n";
            }
            for (int i = 0; i < 8; i++)
            {
                veri += sudoku[8, i] + ",";
            }
            veri += sudoku[8, 8];
            System.IO.File.WriteAllText(kaydet.FileName, veri);

            TextBox hucre = new TextBox();

            for (int i = 0; i <= Controls.Count - 1; i++)
            {
                if (Controls[i].GetType().Name == "TextBox")
                {
                    hucre = (TextBox)this.Controls[i];
                    hucre.Text = null;
                    hucre.ReadOnly = false;
                    hucre.BackColor = Color.GhostWhite;
                }
            }
            return true;
        }

        bool yukle()
        {
            int[,] gecici = new int[9, 9];
            OpenFileDialog yukle = new OpenFileDialog();
            yukle.Title = "Sudoku Yükle";
            yukle.Filter = "Sudoku Dosyası (*.sdk) |*.sdk";
            if (yukle.ShowDialog() != DialogResult.OK)
            {
                return false;
            }

            TextBox hucre = new TextBox();

            for (int i = 0; i <= Controls.Count - 1; i++)
            {
                if (Controls[i].GetType().Name == "TextBox")
                {
                    hucre = (TextBox)this.Controls[i];
                    hucre.Text = null;
                    hucre.ReadOnly = false;
                    hucre.BackColor = Color.GhostWhite;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = 0;
                }
            }
                
            string veri = System.IO.File.ReadAllText(yukle.FileName);
            string[] satirlar = veri.Split("\r".ToCharArray());
            for (int i = 0; i < 9; i++)
            {
                string LFsilme = satirlar[i];
                if (i != 0)
                {
                    LFsilme = satirlar[i].Substring(1, satirlar[i].Length - 1);
                }
                string[] hucreler = LFsilme.Split(Convert.ToChar(","));
                for (int j = 0; j < 9; j++)
                {
                    gecici[i, j] = Convert.ToInt32(hucreler[j]);
                }
            }


            int h = 0;
            int k = 0;
            for (int i = 0; i <= Controls.Count - 1; i++)
            {
                if (Controls[i].GetType().Name == "TextBox")
                {
                    hucre = (TextBox)this.Controls[i];
                    while (h < 9)
                    {
                        while (k < 9)
                        {
                            hucre.Text = gecici[k, h].ToString();
                            if (gecici[k,h]!=0)
                            {
                                hucre.ReadOnly = true;
                                hucre.BackColor = Color.Goldenrod;
                            }
                            k++;
                            break;
                        }
                        if (k == 9)
                        {
                            h++;
                            k = 0;
                        }
                        break;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = gecici[i, j];
                }
            }
            return true;
        }

        void yukle(string dosya)
        {
            int[,] gecici = new int[9, 9];
            
            TextBox hucre = new TextBox();

            for (int i = 0; i <= Controls.Count - 1; i++)
            {
                if (Controls[i].GetType().Name == "TextBox")
                {
                    hucre = (TextBox)this.Controls[i];
                    hucre.Text = null;
                    hucre.ReadOnly = false;
                    hucre.BackColor = Color.GhostWhite;
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = 0;
                }
            }

            string veri = System.IO.File.ReadAllText(dosya);
            string[] satirlar = veri.Split("\r".ToCharArray());
            for (int i = 0; i < 9; i++)
            {
                string LFsilme = satirlar[i];
                if (i != 0)
                {
                    LFsilme = satirlar[i].Substring(1, satirlar[i].Length - 1);
                }
                string[] hucreler = LFsilme.Split(Convert.ToChar(","));
                for (int j = 0; j < 9; j++)
                {
                    gecici[i, j] = Convert.ToInt32(hucreler[j]);
                }
            }


            int h = 0;
            int k = 0;
            for (int i = 0; i <= Controls.Count - 1; i++)
            {
                if (Controls[i].GetType().Name == "TextBox")
                {
                    hucre = (TextBox)this.Controls[i];
                    while (h < 9)
                    {
                        while (k < 9)
                        {
                            hucre.Text = gecici[k, h].ToString();
                            if (gecici[k, h] != 0)
                            {
                                hucre.ReadOnly = true;
                                hucre.BackColor = Color.Goldenrod;
                            }
                            k++;
                            break;
                        }
                        if (k == 9)
                        {
                            h++;
                            k = 0;
                        }
                        break;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    sudoku[i, j] = gecici[i, j];
                }
            }
        }

        private void coz_btn_Click(object sender, EventArgs e)
        {
            if (coz.Coz(sudoku, 0, 0))
            {
                MessageBox.Show("Sudoku Çözüldü.","Mesaj");

                TextBox hucre = new TextBox();

                int[,] gecici = new int[9, 9];

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        gecici[i, j] = sudoku[i, j];
                    }
                }
                
                for (int i = 0; i <= Controls.Count - 1; i++)
                {
                    if (Controls[i].GetType().Name == "TextBox")
                    {
                        hucre = (TextBox)this.Controls[i];
                        hucre.Text = null;
                        hucre.ReadOnly = true;
                    }
                }

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sudoku[i, j] = 0;
                    }
                }

                int h = 0;
                int k = 0;

                for (int i = 0; i <= Controls.Count - 1; i++)
                {
                    if (Controls[i].GetType().Name == "TextBox")
                    {
                        
                        hucre = (TextBox)this.Controls[i];
                        while (h < 9)
                        {
                            while (k < 9)
                            {
                                hucre.Text = gecici[k, h].ToString();
                                k++;
                                break;
                            }
                            if (k == 9)
                            {
                                h++;
                                k = 0;
                            }
                            break;
                        }


                    }
                }
            }
            else
            {
                MessageBox.Show("Sudoku Çözülemedi.","Mesaj");
            }
            
        }

        private void sayi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ((Label)(sender)).DoDragDrop(((Label)(sender)).Image, DragDropEffects.All);
            }
        }

        private void hucre_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void hucre_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.Bitmap) == sayi1.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "1";
            }
            else if (e.Data.GetData(DataFormats.Bitmap) == sayi2.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "2";
            }
            else if (e.Data.GetData(DataFormats.Bitmap) == sayi3.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "3";
            }
            else if (e.Data.GetData(DataFormats.Bitmap) == sayi4.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "4";
            }
            else if (e.Data.GetData(DataFormats.Bitmap) == sayi5.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "5";
            }
            else if (e.Data.GetData(DataFormats.Bitmap) == sayi6.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "6";
            }
            else if (e.Data.GetData(DataFormats.Bitmap) == sayi7.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "7";
            }
            else if (e.Data.GetData(DataFormats.Bitmap) == sayi8.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "8";
            }
            else if (e.Data.GetData(DataFormats.Bitmap) == sayi9.Image & ((TextBox)(sender)).ReadOnly == false)
            {
                ((TextBox)(sender)).Text = "9";
            }
        }

        private void MenuSayi1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }

        private void MenuSayi2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }

        private void MenuSayi3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }

        private void MenuSayi4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }

        private void MenuSayi5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }

        private void MenuSayi6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }

        private void MenuSayi7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }

        private void MenuSayi8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }

        private void MenuSayi9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }

    }

    
}
