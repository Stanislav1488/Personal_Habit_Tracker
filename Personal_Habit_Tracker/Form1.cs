using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Personal_Habit_Tracker
{
    public partial class Form1 : Form
    {
        int caseCount = 0, habit_pointY = 100, objectiveCategory_pointY = 100;
        bool switchDeleteCases = true;

        PictureBox windowForDelete = new PictureBox();
        PictureBox icon_okey = new PictureBox();
        CheckBox deleteAllCases = new CheckBox();


        public Form1()
        {
            InitializeComponent();
            LoadCheckBoxes();
            IconEventsAndTags();
            ObjectsForDeleteCases();

            icon_okey.Click += new EventHandler(DeleteCheckBoxes_Click);
            deleteAllCases.CheckedChanged += new EventHandler(DeleteAllCases_CheckedChanged);
        }

        public class CheckBoxData
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public bool HaditCategory { get; set; }
            public bool ObjectiveCategory { get; set; }
            public bool Finish_Task { get; set; }
        }

        private void IconEventsAndTags()
        {
            icon_statistics.MouseMove += icons_MouseMove;
            icon_history.MouseMove += icons_MouseMove;
            icon_setting.MouseMove += icons_MouseMove;
            icon_delete.MouseMove += icons_MouseMove;

            icon_statistics.MouseLeave += icons_MouseLeave;
            icon_history.MouseLeave += icons_MouseLeave;
            icon_setting.MouseLeave += icons_MouseLeave;
            icon_delete.MouseLeave += icons_MouseLeave;

            icon_statistics.Click += icons_Click;
            icon_history.Click += icons_Click;
            icon_setting.Click += icons_Click;

            icon_add.Tag = 1;
            icon_statistics.Tag = 2;
            icon_history.Tag = 3;
            icon_setting.Tag = 4;
            icon_delete.Tag = 5;
        }

        private void ObjectsForDeleteCases()
        {
            //windowForDelete
            windowForDelete.BackColor = Color.FromArgb(26, 28, 26);
            windowForDelete.Location = new Point(60, 0);
            windowForDelete.Size = new Size(1306, 50);

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
                    Form form_for_add = new Form2();
                    form_for_add.ShowDialog();
                    AddNewCase();
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
                    Form form_for_setting = new Form5();
                    form_for_setting.ShowDialog();
                    break;
            }
        }

        private void ToggleControlPanelState()
        {
            foreach (Control iconPanels in this.Controls)
            {
                if (iconPanels is PictureBox && iconPanels != icon_delete)
                {
                    if (switchDeleteCases == true)
                    {
                        iconPanels.Enabled = false;
                    }
                    else
                    {
                        iconPanels.Enabled = true;
                    }
                }
            }
        }

        //Открывается окно для удаления и закрывается при повторном щелчке
        private void icon_delete_Click(object sender, EventArgs e)
        {

            if (switchDeleteCases == true)
            {
                icon_delete.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\delete_white.png");
                icon_delete.MouseLeave -= icons_MouseLeave;
                ToggleControlPanelState();
                AddWindowForDeleteCases();
                ClearCheckboxes();
                switchDeleteCases = false;
            }
            else
            {
                icon_delete.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\delete_blue.png");
                icon_delete.MouseLeave += icons_MouseLeave;
                ToggleControlPanelState();
                DeleleWindowForDeleteCases();
                switchDeleteCases = true;
            }
        }

        //Добавление
        private void AddNewCase()
        {
            if (Form2.ClosedByAddCase == true)
            {
                CheckBox newCase = new CheckBox();
                newCase.Name = "Test" + Convert.ToString(caseCount);
                newCase.Text = Convert.ToString(Form2.text_nameCase);
                newCase.ForeColor = Color.White;
                newCase.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
                newCase.AutoSize = true;

                if (Form2.habitCategory == true)
                {
                    newCase.Location = new Point(140, habit_pointY);
                    habit_pointY += 40;
                }
                else if (Form2.objectiveCategory == true)
                {
                    newCase.Location = new Point(530, objectiveCategory_pointY);
                    objectiveCategory_pointY += 40;
                }

                this.Controls.Add(newCase);
                Form2.ClosedByAddCase = false;
                caseCount++;

                SaveCheckBoxes();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCheckBoxes();
        }

        //Очистка Checked у cheakBoxes
        private void ClearCheckboxes()
        {
            foreach (CheckBox control in this.Controls.OfType<CheckBox>().ToList())
            {
                control.Checked = false;
            }
        }

        //Выбор всех checkBoxes для удаления
        private void DeleteAllCases_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteAllCases.Checked == true)
            {
                foreach (CheckBox control in this.Controls.OfType<CheckBox>().ToList())
                {
                    control.Checked = true;
                }
            }
        }

        //Удаление выбраных checkBoxes
        private void DeleteCheakBoxes()
        {
            List<CheckBoxData> checkBoxData = LoadCheckBoxesData();

            foreach (CheckBox control in this.Controls.OfType<CheckBox>().ToList())
            {
                if (control.Checked == true && control != deleteAllCases)
                {
                    if (checkBoxData.Any(x => x.Name == control.Name && !x.Finish_Task))
                    {
                        checkBoxData.RemoveAll(x => x.Name == control.Name);
                        caseCount--;
                    }
                }
                SaveCheckBoxesData(checkBoxData);
                LoadCheckBoxes();
            }
        }

        private void DeleteCheckBoxes_Click(object sender, EventArgs e)
        {
            DeleteCheakBoxes();
            DeleleWindowForDeleteCases();
            icon_delete.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\delete_blue.png");
            icon_delete.MouseLeave += icons_MouseLeave;
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


        //Сохранение
        private void SaveCheckBoxes()
        {
            List<CheckBoxData> checkBoxes = new List<CheckBoxData>();
            var existingData = LoadCheckBoxesData();
            checkBoxes.AddRange(existingData.Where(x => x.Finish_Task));

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox chk)
                {
                    checkBoxes.Add(new CheckBoxData
                    {
                        Name = chk.Name,
                        Text = chk.Text,
                        HaditCategory = chk.Location.X == 140,
                        ObjectiveCategory = chk.Location.X == 530,
                        Finish_Task = chk.Checked == true,
                    });
                }
            }

            string json = JsonConvert.SerializeObject(checkBoxes);
            File.WriteAllText("checkboxes.json", json);
        }

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

        //Загрузка
        private void LoadCheckBoxes()
        {
            DeleteFromFormAllObject();
            objectiveCategory_pointY = 100;
            habit_pointY = 100;

            if (File.Exists("checkboxes.json"))
            {
                string json = File.ReadAllText("checkboxes.json");
                List<CheckBoxData> savedBoxes = JsonConvert.DeserializeObject<List<CheckBoxData>>(json);

                foreach (var saved in savedBoxes)
                {
                    if (!saved.Finish_Task)
                    {
                        CheckBox chk = new CheckBox
                        {
                            Name = saved.Name,
                            Text = saved.Text,
                            ForeColor = Color.White,
                            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold),
                            AutoSize = true,
                            Checked = false
                        };

                        if (saved.HaditCategory)
                        {
                            chk.Location = new Point(140, habit_pointY);
                            habit_pointY += 40;
                        }
                        if (saved.ObjectiveCategory)
                        {
                            chk.Location = new Point(530, objectiveCategory_pointY);
                            objectiveCategory_pointY += 40;
                        }

                        this.Controls.Add(chk);
                    }
                }

                caseCount = savedBoxes.Count;
            }
        }
    }
}
