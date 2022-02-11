using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino_Rolan
{
    public partial class Saal_choose : Form
    {

        public Saal_choose()
        {
            this.Icon = Properties.Resources.icon;
            this.Text = "Kinoworld";

            Image bgimg = new Bitmap(@"..\..\img\Hall.jpg");
            this.BackgroundImage = bgimg;

            this.ClientSize = new System.Drawing.Size(900, 550);

            Button mal_btn = new Button
            {
                Text = "Väike saal",
                Location = new System.Drawing.Point(80, 240),//Point(x,y)
                Height = 50,
                Width = 150,
                BackColor = Color.LightYellow
            };
            mal_btn.Click += Mal_btn_Click;

            Button sred_btn = new Button
            {
                Text = "Keskmine saal",
                Location = new System.Drawing.Point(370, 240),//Point(x,y)
                Height = 50,
                Width = 150,
                BackColor = Color.LightYellow
            };
            sred_btn.Click += Sred_btn_Click;

            Button bol_btn = new Button
            {
                Text = "Suur saal",
                Location = new System.Drawing.Point(650, 240),//Point(x,y)
                Height = 50,
                Width = 150,
                BackColor = Color.LightYellow
            };
            bol_btn.Click += Bol_btn_Click;

            Label lbl_zal = new Label
            {
                Text = "Valige saal",
                Size = new System.Drawing.Size(150, 30),
                Location = new System.Drawing.Point(370, 140),
                Font = new Font("Oswald", 16, FontStyle.Bold)
            };

            this.Controls.Add(lbl_zal);
            this.Controls.Add(mal_btn);
            this.Controls.Add(sred_btn);
            this.Controls.Add(bol_btn);
            this.BackColor = Color.LightSalmon;
        }

        private void Bol_btn_Click(object sender, EventArgs e)
        {
            Saal_main uus_aken = new Saal_main(9, 9);//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Sred_btn_Click(object sender, EventArgs e)
        {
            Saal_main uus_aken = new Saal_main(7, 7);//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();

        }

        private void Mal_btn_Click(object sender, EventArgs e)
        {
            Saal_main uus_aken = new Saal_main(5, 5);//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }


        private void MyFotm_Click(object sender, EventArgs e)
        {

        }
    }
}
