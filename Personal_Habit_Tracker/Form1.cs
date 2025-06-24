using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Personal_Habit_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tags_Icons();
        }

        private void Tags_Icons()
        {
            pictureBox3.MouseMove += pictureBox2_MouseMove;
            pictureBox4.MouseMove += pictureBox2_MouseMove;
            pictureBox5.MouseMove += pictureBox2_MouseMove;

            pictureBox3.MouseLeave += pictureBox2_MouseLeave;
            pictureBox4.MouseLeave += pictureBox2_MouseLeave;
            pictureBox5.MouseLeave += pictureBox2_MouseLeave;

            pictureBox2.Tag = 1;
            pictureBox3.Tag = 2;
            pictureBox4.Tag = 3;
            pictureBox5.Tag = 4;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox icon = (PictureBox)sender;

            switch (icon.Tag)
            {
                case 1:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\add_white.png");
                    break;
                case 2:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\statistics_white.png");
                    break;
                case 3:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\history_white.png");
                    break;
                case 4:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\setting_white.png");
                    break;
            }
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            PictureBox icon = (PictureBox)sender;

            switch (icon.Tag)
            {
                case 1:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\add_blue.png");
                    break;
                case 2:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\statistics_blue.png");
                    break;
                case 3:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\history_blue.png");
                    break;
                case 4:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\setting_blue.png");
                    break;
            }
        }
    }
}
