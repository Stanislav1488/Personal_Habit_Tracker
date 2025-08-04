using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Personal_Habit_Tracker.Form1;

namespace Personal_Habit_Tracker
{
    public partial class Form4 : Form
    {
        public static int task_point = 100;

        PictureBox windowForDelete = new PictureBox();
        PictureBox icon_okey = new PictureBox();
        CheckBox deleteAllCases = new CheckBox();

        public Form4()
        {
            InitializeComponent();
            IconEventsAndTags();
            ObjectsForDeleteCases();

            icon_okey.Click += new EventHandler(DeleteCheckBoxes_Click);
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

            task_with_notice_icon.Click += icons_Click;
            habit_icon.Click += icons_Click;
            task_icon.Click += icons_Click;
            delete_icon.Click += icons_Click;

            finished_icon.Tag = 1;
            task_with_notice_icon.Tag = 2;
            habit_icon.Tag = 3;
            task_icon.Tag = 4;
            delete_icon.Tag = 5;
        }

        private void ObjectsForDeleteCases()
        {
            //windowForDelete
            windowForDelete.BackColor = Color.FromArgb(26, 28, 26);
            windowForDelete.Location = new Point(60, 0);
            windowForDelete.Size = new Size(490, 50);

            //icon_okey
            deleteAllCases.BackColor = Color.FromArgb(26, 28, 26);
            deleteAllCases.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            deleteAllCases.ForeColor = Color.White;
            deleteAllCases.Location = new Point(69, 6);
            deleteAllCases.Size = new Size(160, 31);
            deleteAllCases.Text = "Выбрать всё";

            //deleteAllCases
            icon_okey.BackColor = Color.FromArgb(26, 28, 28);
            icon_okey.Location = new Point(238, 0);
            icon_okey.Size = new Size(50, 50);
            icon_okey.SizeMode = PictureBoxSizeMode.Normal;
            icon_okey.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\okey_white.png");

        }

        private void AddWindowForDeleteCases()
        {
            this.Controls.Add(deleteAllCases);
            this.Controls.Add(icon_okey);
            this.Controls.Add(windowForDelete);
        }

        private void DeleleWindowForDeleteCases()
        {
            this.Controls.Remove(windowForDelete);
            this.Controls.Remove(deleteAllCases);
            this.Controls.Remove(icon_okey);
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

        private void icons_Click(object sender, EventArgs e)
        {
            PictureBox icon = (PictureBox)sender;

            switch (icon.Tag)
            {
                case 1:
                    LoadFilteredTasks(x => x.Finish_Task == true);
                    break;
                case 2:
                    //НУжно будет разобраться с такими задачими
                    break;
                case 3:
                    LoadFilteredTasks(x => x.Finish_Task == false && x.HaditCategory == true);
                    break;
                case 4:
                    LoadFilteredTasks(x => x.Finish_Task == false && x.ObjectiveCategory == true);
                    break;
            }
        }

        //Иконка, котороя добавляет окно для удаления CheakBox
        private void delete_icon_Click(object sender, EventArgs e)
        {
            AddWindowForDeleteCases();
        }

        //Нажатие на icon_okey, для подверждения удаления
        private void DeleteCheckBoxes_Click(object sender, EventArgs e)
        {
            DeleteCheckBoxes();
            DeleleWindowForDeleteCases();
            
        }

        private void DeleteCheckBoxes()
        {
            List<CheckBoxData> checkBoxData = LoadCheckBoxesData();

            foreach (CheckBox control in this.Controls.OfType<CheckBox>().ToList())
            {
                if (control.Checked == true && control != deleteAllCases)
                {
                    if (checkBoxData.Any(x => x.Name == control.Name))
                    {
                        checkBoxData.RemoveAll(x => x.Name == control.Name);
                    }
                }
                SaveCheckBoxesData(checkBoxData);
                DeleteFromFormAllObject();
            }
        }

        //Удаляет все checkBox с формы
        private void DeleteFromFormAllObject()
        {
            foreach (Control control in this.Controls.OfType<CheckBox>().ToList())
            {
                this.Controls.Remove(control);
                control.Dispose();
            }
        }

        // Загрузка данных из JSON
        private List<CheckBoxData> LoadCheckBoxesData()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "checkboxes.json");
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<CheckBoxData>>(json)
                           ?? new List<CheckBoxData>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
            return new List<CheckBoxData>();
        }

        // Сохранение данных в JSON
        private void SaveCheckBoxesData(List<CheckBoxData> data)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "checkboxes.json");
            try
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}");
            }
        }

        //Загрузка и фильтрация checkBox
        private void LoadFilteredTasks(Func<CheckBoxData, bool> filterCondition)
        {
            DeleteFromFormAllObject();
            task_point = 100;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "checkboxes.json");

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<CheckBoxData> savedBoxes = JsonConvert.DeserializeObject<List<CheckBoxData>>(json);

                foreach (var saved in savedBoxes.Where(filterCondition))
                {
                    CheckBox chk = new CheckBox
                    {
                        Name = saved.Name,
                        Text = saved.Text,
                        Location = new Point(140, task_point),
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 15.75F, FontStyle.Bold),
                        AutoSize = true,
                        Checked = false
                    };

                    this.Controls.Add(chk);

                    task_point += 40;
                }
            }
        }

    }
}
