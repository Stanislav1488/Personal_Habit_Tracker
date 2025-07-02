using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Personal_Habit_Tracker
{
    public partial class Form1 : Form
    {
        int caseCount = 0, hadit_pointY = 100, objectiveCategory_pointY = 100;

        public Form1()
        {
            InitializeComponent();
            LoadCheckBoxes();
            IconEventsAndTags();
        }

        public class SavedCheckBox
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public int LocationX { get; set; }
            public int LocationY { get; set; }
            public bool IsHaditCategory { get; set; }
        }

        private void IconEventsAndTags()
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
                    Form5 form_for_setting = new Form5();
                    form_for_setting.ShowDialog();
                    break;
            }
        }

        private void AddNewCase()
        {
            CheckBox newCase = new CheckBox();
            newCase.Name = "Test" + Convert.ToString(caseCount);
            newCase.Text = Convert.ToString(Form2.text_nameCase);
            newCase.ForeColor = Color.White;
            newCase.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            newCase.AutoSize = true;

            if (Form2.habitCategory == true)
            {
                newCase.Location = new Point(140, hadit_pointY);
                hadit_pointY += 40;
            }
            else if (Form2.objectiveCategory == true)
            {
                newCase.Location = new Point(530, objectiveCategory_pointY);
                objectiveCategory_pointY += 40;
            }

            this.Controls.Add(newCase);
            caseCount++;

            SaveCheckBoxes();
        }

        //Сохранение
        private void SaveCheckBoxes()
        {
            List<SavedCheckBox> checkBoxes = new List<SavedCheckBox>();

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox chk)
                {
                    checkBoxes.Add(new SavedCheckBox
                    {
                        Name = chk.Name,
                        Text = chk.Text,
                        LocationX = chk.Location.X,
                        LocationY = chk.Location.Y,
                        IsHaditCategory = chk.Location.X == 140


                    });
                }
            }

            string json = JsonConvert.SerializeObject(checkBoxes);
            File.WriteAllText("checkboxes.json", json);
        }

        //Загрузка
        private void LoadCheckBoxes()
        {
            if (File.Exists("checkboxes.json"))
            {
                string json = File.ReadAllText("checkboxes.json");
                List<SavedCheckBox> savedBoxes = JsonConvert.DeserializeObject<List<SavedCheckBox>>(json);

                foreach (var saved in savedBoxes)
                {
                    CheckBox chk = new CheckBox
                    {
                        Name = saved.Name,
                        Text = saved.Text,
                        Location = new Point(saved.LocationX, saved.LocationY),
                        ForeColor = Color.White,
                        Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold),
                        AutoSize = true
                    };

                    this.Controls.Add(chk);

                    // Обновляем счетчики позиций
                    if (saved.IsHaditCategory)
                        hadit_pointY = saved.LocationY + 40;
                    else
                        objectiveCategory_pointY = saved.LocationY + 40;
                }

                caseCount = savedBoxes.Count;
            }
        }
    }
}
