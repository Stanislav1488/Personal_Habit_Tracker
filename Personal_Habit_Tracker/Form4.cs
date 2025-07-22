using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Personal_Habit_Tracker
{
    public partial class Form4 : Form
    {
        public static int task_point = 100;

        public Form4()
        {
            InitializeComponent();
            IconEventsAndTags();
        }

        public class CheckBox_for_watching_Data
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public int LocationX {get; set;}
            public int LocationY {get; set;}
            public bool Checked {  get; set; }
        }

        private void IconEventsAndTags()
        {
            task_with_notice_icon.MouseMove += icons_MouseMove;
            habit_icon.MouseMove += icons_MouseMove;
            task_icon.MouseMove += icons_MouseMove;
            delete_icon.MouseMove += icons_MouseMove;

            task_with_notice_icon.MouseLeave += icons_MouseLeave;
            habit_icon.MouseLeave += icons_MouseLeave; ;
            task_icon.MouseLeave += icons_MouseLeave;
            delete_icon.MouseLeave += icons_MouseLeave;

            finished_icon.Tag = 1;
            task_with_notice_icon.Tag = 2;
            habit_icon.Tag = 3;
            task_icon.Tag = 4;
            delete_icon.Tag = 5;
        }

        private void icons_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox icon = (PictureBox)sender;

            switch (icon.Tag)
            {
                case 1:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\okey_white.png");
                    break;
                case 2:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\watch_white.png");
                    break;
                case 3:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\habit_white.png");
                    break;
                case 4:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\task_white.png");
                    break;
                case 5:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\delete_white.png");
                    break;

            }
        }

        private void icons_MouseLeave(object sender, EventArgs e)
        {
            PictureBox icon = (PictureBox)sender;

            switch (icon.Tag)
            {
                case 1:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\okey_blue.png");
                    break;
                case 2:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\watch_blue.png");
                    break;
                case 3:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\habit_blue.png");
                    break;
                case 4:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\task_blue.png");
                    break;
                case 5:
                    icon.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\delete_blue.png");
                    break;

            }
        }

    }
}
