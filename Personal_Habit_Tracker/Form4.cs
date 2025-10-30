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
        public event Action FormClosedWithUpdate;
        int tagGategoty;
        public static int task_point = 100;

        PictureBox windowForDelete = new PictureBox();
        PictureBox icon_okey = new PictureBox();
        CheckBox deleteAllCases = new CheckBox();
        Label nameCategory = new Label();

        public Form4()
        {
            InitializeComponent();
            IconEventsAndTags();
            SettingNameCategory();
            ObjectsForDeleteCases();

            icon_okey.Click += new EventHandler(DeleteCheckBoxes_Click);
            deleteAllCases.CheckedChanged += new EventHandler(DeleteAllcases_CheckedChanged);
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

        private void SettingNameCategory()
        {
            nameCategory.BackColor = Color.FromArgb(23, 24, 26);
            nameCategory.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            nameCategory.ForeColor = Color.White;
            nameCategory.Location = new Point(140, 50);
            nameCategory.AutoSize = true;

            this.Controls.Add(nameCategory);
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
            tagGategoty = (int)icon.Tag;
            LoadTask();
        }

        private void LoadTask()
        {
            switch (tagGategoty)
            {
                case 1:
                    LoadFilteredTasks(x => x.Finish_Task == true);
                    nameCategory.Text = "Завершённые задачи:";
                    break;
                case 2:
                    LoadFilteredTasks(x => x.Finish_Task == false && x.Planned_Activities == true);
                    nameCategory.Text = "Запланированные дела:";
                    break;
                case 3:
                    LoadFilteredTasks(x => x.Finish_Task == false && x.HaditCategory == true);
                    nameCategory.Text = "Привычки:";
                    break;
                case 4:
                    LoadFilteredTasks(x => x.Finish_Task == false && x.ObjectiveCategory == true);
                    nameCategory.Text = "Задачи:";
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
            DeleteFromFormAllObject();
            DeleteFromFormAllLabel();
            DeleleWindowForDeleteCases();
        }

        //Выбор всех CheckBoxes для удаления
        private void DeleteAllcases_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteAllCases.Checked == true)
            {
                foreach (CheckBox control in this.Controls.OfType<CheckBox>().ToList())
                {
                    control.Checked = true;
                }
            }
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

            }
        }

        //Удаляет все checkBox с формы
        private void DeleteFromFormAllObject()
        {
            foreach (Control control in this.Controls.OfType<CheckBox>().ToList())
            {
                if (control != deleteAllCases)
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
            }
        }

        //Удаление всех label с формы
        private void DeleteFromFormAllLabel()
        {
            foreach (Label control in this.Controls.OfType<Label>().ToList())
            {
                if (control.Tag != null && (control.Tag.ToString() == "counter" || control.Tag.ToString() == "notificationDate"))
                {
                    this.Controls.Remove(control);
                    control.Dispose();
                }
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
            DeleteFromFormAllLabel();
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

                    if (saved.HaditCategory)
                    {
                        AddCounter(chk.Name, task_point);
                        task_point += 60;
                    }
                    else if (saved.ObjectiveCategory)
                    {
                        task_point += 40;
                    }
                    else if (saved.Planned_Activities)
                    {
                        AddNotificationDateLabel(chk.Name, task_point);
                        task_point += 60;
                    }
                }
            }
        }

        //добавление счетчика
        private void AddCounter(string habitID, int LocationY)
        {
            List<CheckBoxData> habits = LoadCheckBoxesData();
            var habit = habits.FirstOrDefault(x => x.Name == habitID);

            Label counterForHabits = new Label();
            counterForHabits.Name = "counter_" + habitID;
            counterForHabits.ForeColor = Color.White;
            counterForHabits.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            counterForHabits.AutoSize = true;
            counterForHabits.Location = new Point(140, LocationY + 30);
            counterForHabits.Tag = "counter";

            if (habit.CurrentCount == habit.TargetCount)
            {
                counterForHabits.Text = "Завершено";
                counterForHabits.ForeColor = Color.LightGreen;
            }
            else
            {
                counterForHabits.Text = "Сегодня:" + habit.CurrentCount + "/" + habit.TargetCount;
            }

            this.Controls.Add(counterForHabits);
        }

        //создание даты упоминания
        private void AddNotificationDateLabel(string taskID, int LocationY)
        {
            List<CheckBoxData> checkBoxes = LoadCheckBoxesData();
            var checkBox = checkBoxes.FirstOrDefault(x => x.Name == taskID);

            Label notificationDateLabel = new Label();
            notificationDateLabel.Name = "notificationDate_" + taskID;
            notificationDateLabel.Text = checkBox.DateTimeForCheckBoxes.ToShortTimeString();
            notificationDateLabel.ForeColor = Color.White;
            notificationDateLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular);
            notificationDateLabel.AutoSize = true;
            notificationDateLabel.Location = new Point(140, LocationY + 30);
            notificationDateLabel.Tag = "notificationDate";

            if (!checkBox.Finish_Task)
            {
                if (checkBox.DateTimeForCheckBoxes.Date < DateTime.Today.Date)
                {
                    notificationDateLabel.Text = "Незавершенно";
                    notificationDateLabel.ForeColor = Color.FromArgb(220, 53, 69);
                }
                else
                {
                    notificationDateLabel.Text = checkBox.DateTimeForCheckBoxes.ToShortTimeString();
                }
            }
            else
            {
                notificationDateLabel.Text = "Завершено";
                notificationDateLabel.ForeColor = Color.LightGreen;
            }

            this.Controls.Add(notificationDateLabel);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosedWithUpdate?.Invoke();
        }
    }
}
