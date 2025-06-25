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
            icon_statistics.MouseMove += icons_MouseMove;
            icon_history.MouseMove += icons_MouseMove;
            icon_setting.MouseMove += icons_MouseMove;

            icon_statistics.MouseLeave += icons_MouseLeave;
            icon_history.MouseLeave += icons_MouseLeave;
            icon_setting.MouseLeave += icons_MouseLeave;

            icon_statistics.Click += icons_Click;
            icon_history.Click += icons_Click;
            icon_setting.Click += icons_Click;

            icon_add.Tag = 1;
            icon_statistics.Tag = 2;
            icon_history.Tag = 3;
            icon_setting.Tag = 4;
        }

        private void icons_MouseMove(object sender, MouseEventArgs e)
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

        private void icons_MouseLeave(object sender, EventArgs e)
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

        private void icons_Click(object sender, EventArgs e)
        {
            PictureBox icon = (PictureBox)sender;

            switch (icon.Tag)
            {
                case 1:
                    Form form_for_add = new Form2();
                    form_for_add.ShowDialog();
                    break;
                case 2:
                    Form form_for_statistics = new Form3();
                    form_for_statistics.ShowDialog();
                    break;
                case 3:
                    Form form_for_history = new Form4();
                    form_for_history.ShowDialog();
                    break;
                case 4:
                    Form5 form_for_setting = new Form5();
                    form_for_setting.ShowDialog();
                    break;
            }
        }
    }
}
