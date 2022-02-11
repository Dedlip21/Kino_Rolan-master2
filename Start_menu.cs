using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kino_Rolan
{
    class Start_menu: System.Windows.Forms.Form
    {
        PictureBox pic;

        public Start_menu()
        {
            /*MainMenu menu = new MainMenu();
            MenuItem menuFile = new MenuItem("Seaded");
            menuFile.MenuItems.Add("Admin", new EventHandler(menuAdmin)).Shortcut = Shortcut.CtrlS;
            //menuFile.MenuItems.Add("Размер", new EventHandler());
            //menuFile.MenuItems.Add("Postimees", new EventHandler());
            menu.MenuItems.Add(menuFile);
            this.Menu = menu;*/

            this.Icon = Properties.Resources.icon;
            this.Text = "Kinoworld";

            Button Kinozal_btn = new Button
            {
                Text = "Osta pilet",
                Location = new System.Drawing.Point(220, 100),//Point(x,y)
                Height = 50,
                Width = 120,
                BackColor = Color.LightYellow
            };
            Kinozal_btn.Click += Kinozal_btn_Click;

            pic = new PictureBox();//создали PictureBox
            pic.Size = new Size(220, 380);
            pic.Location = new Point(500, 15);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.ImageLocation = (@"..\..\img\spiderman.jpg");

            Button Listat_btn = new Button
            {
                Text = "🢂",
                Location = new System.Drawing.Point(580, 410),//Point(x,y)
                Height = 30,
                Width = 60,
                BackColor = Color.LightYellow
            };
            Button Info_btn = new Button
            {
                Text = "Info ℹ️",
                Location = new System.Drawing.Point(220, 170),//Point(x,y)
                Height = 50,
                Width = 120,
                BackColor = Color.LightYellow
            };
            Info_btn.Click += Info_btn_Click;

            Button Pravil_btn = new Button
            {
                Text = "Reegel 📖",
                Location = new System.Drawing.Point(220, 240),//Point(x,y)
                Height = 50,
                Width = 120,
                BackColor = Color.LightYellow
            };
            Pravil_btn.Click += Pravil_btn_Click;

            Button Admin_btn = new Button
            {
                Text = "Admin",
                Location = new System.Drawing.Point(220, 310),//Point(x,y)
                Height = 50,
                Width = 120,
                BackColor = Color.LightYellow
            };
            Admin_btn.Click += Admin_btn_Click;



            Label lbl = new Label
            {
                Text = "Kinoteatr „Kinoworld“",
                Size = new System.Drawing.Size(240, 30),
                Location = new System.Drawing.Point(180, 25),
                Font = new Font("Oswald", 16, FontStyle.Bold),
                BackColor = Color.LightYellow

            };


            this.Controls.Add(Kinozal_btn);
            this.Controls.Add(Info_btn);
            this.Controls.Add(Pravil_btn);
            this.Controls.Add(Admin_btn);
            this.Controls.Add(lbl);

            // this.BackColor = Color.LightSalmon;
            Image bgimg = new Bitmap(@"..\..\img\cashregistr.jpg");
            this.BackgroundImage = bgimg;


            Listat_btn.Click += Listat_btn_Click;
            this.Controls.Add(Listat_btn);
            this.Controls.Add(pic);
            this.Controls.Add(Kinozal_btn);
            this.Height = 500;//свойство высота формы
            this.Width = 800;
        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            AdminMenu uus_aken = new AdminMenu();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
        }

        int scetcikafi = 0;
        private void Listat_btn_Click(object sender, EventArgs e)
        {
            scetcikafi++; //тут я увеличиваю значения счетчика на 1
            if (scetcikafi == 1)
            {

                pic.ImageLocation = (@"..\..\img\matrix.jpg");

            }
            else if (scetcikafi == 2)
            {

                pic.ImageLocation = (@"..\..\img\dovod.jpg");
            }
            else if (scetcikafi == 3)
            {
                pic.ImageLocation = (@"..\..\img\odindoma.jpg");
            }
            else if (scetcikafi == 4)
            {

                scetcikafi = 0; //сбрасывает счетччик, что бы начать все заново
                pic.ImageLocation = (@"..\..\img\spiderman.jpg");
            }
        }

        private void Pravil_btn_Click(object sender, EventArgs e)
        {
            var info = File.ReadAllText(@"..\..\info\Pravila_zal.txt");
            var information = MessageBox.Show(info, "Info");
        }

        private void Info_btn_Click(object sender, EventArgs e)
        {
            var info = File.ReadAllText(@"..\..\info\Info_text_zal.txt");
            var information = MessageBox.Show(info, "Info");
        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }


        private void Kinozal_btn_Click(object sender, EventArgs e)
        {
            Film_choose uus_aken = new Film_choose();//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.Show();
            this.Hide();
        }
    }
}
