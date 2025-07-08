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
        int caseCount = 0, hadit_pointY = 100, objectiveCategory_pointY = 100;
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
        }

        public class CheckBoxData
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
            windowForDelete.Size = new System.Drawing.Size(1306, 50);

            //icon_okey
            deleteAllCases.BackColor = Color.FromArgb(26, 28, 26);
            deleteAllCases.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteAllCases.ForeColor = Color.White;
            deleteAllCases.Location = new Point(69, 6);
            deleteAllCases.Size = new Size(160, 31);
            deleteAllCases.Text = "Выбрать всё";

            //deleteAllCases
            icon_okey.BackColor = Color.FromArgb(26, 28, 28);
            icon_okey.Location = new Point(238, 0);
            icon_okey.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\okey_graphite_black.png");
            icon_okey.Size = new Size(50, 50);
            icon_okey.SizeMode = PictureBoxSizeMode.Normal;

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
                    Form5 form_for_setting = new Form5();
                    form_for_setting.ShowDialog();
                    break;
            }
        }

        private void icon_delete_Click(object sender, EventArgs e)
        {

            if (switchDeleteCases == true)
            {
                icon_delete.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\delete_white.png");
                icon_delete.MouseLeave -= icons_MouseLeave;
                AddWindowForDeleteCases();
                ClearCheckboxes();
                switchDeleteCases = false;
            }
            else
            {
                icon_delete.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icons\\delete_blue.png");
                icon_delete.MouseLeave += icons_MouseLeave;
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
                Form2.ClosedByAddCase = false;
                caseCount++;


                SaveCheckBoxes();
            }
        }

        //Очистка свойства checkBoxes для удаления
        private void ClearCheckboxes()
        {
            foreach (CheckBox control in this.Controls.OfType<CheckBox>().ToList())
            {
                control.Checked = false;
            }
        }

        //Удаление выбраных checkBoxes
        private void DeleteCheckBoxes_Click(object sender, EventArgs e)
        {
            List<CheckBoxData> checkBoxData = LoadCheckBoxesData();

            foreach (CheckBox control in this.Controls.OfType<CheckBox>().ToList())
            {
                if (control.Checked && control != deleteAllCases)
                {
                    this.Controls.Remove(control);
                    checkBoxData.RemoveAll(x => x.Name == control.Name);
                    control.Dispose();


                    if (control.Location.X == 140)
                    {
                        hadit_pointY -= 40;
                    }
                    else if (control.Location.X == 530)
                    {
                        objectiveCategory_pointY -= 40;
                    }

                    caseCount--;
                }

                DeleleWindowForDeleteCases();
                SaveCheckBoxesData(checkBoxData);
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

        //Сохранение
        private void SaveCheckBoxes()
        {
            List<CheckBoxData> checkBoxes = new List<CheckBoxData>();

            foreach (Control control in this.Controls)
            {
                if (control is CheckBox chk)
                {
                    checkBoxes.Add(new CheckBoxData
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
                List<CheckBoxData> savedBoxes = JsonConvert.DeserializeObject<List<CheckBoxData>>(json);

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
                    {
                        hadit_pointY = saved.LocationY + 40;
                    }
                    else
                    {
                        objectiveCategory_pointY = saved.LocationY + 40;
                    }
                }

                caseCount = savedBoxes.Count;
            }
        }
    }
}
