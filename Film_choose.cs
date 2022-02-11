using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino_Rolan
{
    public partial class Film_choose : Form
    {
        PictureBox pic1;
        PictureBox pic2;
        PictureBox pic3;
        public Film_choose()
        {
            this.Icon = Properties.Resources.icon;
            this.Text = "Kinoworld";

            this.ClientSize = new System.Drawing.Size(720, 500);

            pic1 = new PictureBox();//создали PictureBox
            pic1.Size = new Size(220, 400);
            pic1.Location = new Point(500, 20);
            pic1.SizeMode = PictureBoxSizeMode.StretchImage;
            pic1.ImageLocation = (@"..\..\img\spiderman.jpg");
            pic1.Click += kartinka1_Click;

            pic2 = new PictureBox();//создали PictureBox
            pic2.Size = new Size(220, 400);
            pic2.Location = new Point(250, 20);
            pic2.SizeMode = PictureBoxSizeMode.StretchImage;
            pic2.ImageLocation = (@"..\..\img\dovod.jpg");
            pic2.Click += kartinka2_Click;

            pic3 = new PictureBox();//создали PictureBox
            pic3.Size = new Size(220, 400);
            pic3.Location = new Point(1, 20);
            pic3.SizeMode = PictureBoxSizeMode.StretchImage;
            pic3.ImageLocation = (@"..\..\img\matrix.jpg");
            pic3.Click += kartinka3_Click;

            Image bgimg = new Bitmap(@"..\..\img\grey.jpg");
            this.BackgroundImage = bgimg;
            //this.BackColor = Color.DarkGray;
            this.Controls.Add(pic1);
            this.Controls.Add(pic2);
            this.Controls.Add(pic3);

        }

        private void kartinka1_Click(object sender, EventArgs e)
        {
            Saal_choose uus_aken = new Saal_choose();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
            string spi = "Spiderman";
            using (StreamWriter srb = new StreamWriter(@"..\..\zapisfilma\Film.txt", true))
            {
                srb.WriteLine(spi);
            }
            this.Hide();

        }

        private void kartinka2_Click(object sender, EventArgs e)
        {
            Saal_choose uus_aken = new Saal_choose();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
            string dovod = "Tenet";
            using (StreamWriter srb = new StreamWriter(@"..\..\zapisfilma\Film.txt", true))
            {
                srb.WriteLine(dovod);
            }
            this.Hide();
        }

        private void kartinka3_Click(object sender, EventArgs e)
        {
            Saal_choose uus_aken = new Saal_choose();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
            string ma = "Matrix";
            using (StreamWriter srb = new StreamWriter(@"..\..\zapisfilma\Film.txt", true))
            {
                srb.WriteLine(ma);
            }
            this.Hide();
        }
    }
}
