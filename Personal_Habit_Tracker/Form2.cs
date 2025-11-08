using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Personal_Habit_Tracker
{
    public partial class Form2 : Form
    {
        static public string text_nameCase;
        static public int counter_text;
        static public int year = 0001, morth = 01, day = 01, hour = 0, minutes = 0;
        static public bool habitCategory, objectiveCategory, plannedActivitiesCategory, ClosedByAddCase = false;
        static public DateTime dateTime = new DateTime();

        Panel panel = new Panel();
        Label label3 = new Label();
        Label label4 = new Label();
        Label label5 = new Label();
        Label label6 = new Label();
        Label label7 = new Label();
        Label label8 = new Label();
        TextBox textBox2 = new TextBox();
        TextBox textBox3 = new TextBox();
        TextBox textBox4 = new TextBox();
        TextBox textBox5 = new TextBox();
        TextBox textBox6 = new TextBox();
        TextBox text_for_counter = new TextBox();
        RadioButton radioButton4 = new RadioButton();
        RadioButton radioButton5 = new RadioButton();
        RadioButton radioButton6 = new RadioButton();
        RadioButton radioButton7 = new RadioButton();
        RadioButton radioButton8 = new RadioButton();

        public Form2()
        {
            InitializeComponent();
            AllTextBosex_And_RadioButtons_Events();
            Setting_NotificationTime_and_Repeat();
            Setting_Add_TheCounter_For_Habits();
            Update_status_add_case();

        }
        //События
        private void AllTextBosex_And_RadioButtons_Events()
        {
            objectives.CheckedChanged += categories_and_repeats_CheckedChanged;
            planned_activities.CheckedChanged += categories_and_repeats_CheckedChanged;
            radioButton4.CheckedChanged += categories_and_repeats_CheckedChanged;
            radioButton5.CheckedChanged += categories_and_repeats_CheckedChanged;
            radioButton6.CheckedChanged += categories_and_repeats_CheckedChanged;
            radioButton7.CheckedChanged += categories_and_repeats_CheckedChanged;
            radioButton8.CheckedChanged += categories_and_repeats_CheckedChanged;

            textBox2.TextChanged += AllTextBoxes_TextChanged;
            textBox3.TextChanged += AllTextBoxes_TextChanged;
            textBox4.TextChanged += AllTextBoxes_TextChanged;
            textBox5.TextChanged += AllTextBoxes_TextChanged;
            textBox6.TextChanged += AllTextBoxes_TextChanged;
            text_for_counter.TextChanged += AllTextBoxes_TextChanged;
        }

        //Настройки для частоты и времени уведомлений
        private void Setting_NotificationTime_and_Repeat()
        {
            //panel
            panel.Location = new Point(17, 430);
            panel.Size = new Size(332, 242);

            //label3
            label3.Text = "D";
            label3.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 333);
            label3.Size = new Size(27, 27);
            label3.ForeColor = Color.White;

            //label4
            label4.Text = "M";
            label4.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(77, 333);
            label4.Size = new Size(30, 27);
            label4.ForeColor = Color.White;

            //label5
            label5.Text = "Y";
            label5.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(145, 333);
            label5.Size = new Size(26, 27);
            label5.ForeColor = Color.White;

            //label6
            label6.Text = ":";
            label6.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(320, 333);
            label6.Size = new Size(19, 27);
            label6.ForeColor = Color.White;

            //label7
            label7.Text = "Повторение";
            label7.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 390);
            label7.Size = new Size(135, 27);
            label7.ForeColor = Color.White;

            //textBox2
            textBox2.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(39, 333);
            textBox2.Size = new Size(38, 34);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.BackColor = Color.FromArgb(26, 28, 28);
            textBox2.ForeColor = Color.White;
            textBox2.KeyPress += new KeyPressEventHandler(notificationTextBoxes_KeyPress);
            textBox2.Tag = 1;
            //
            //textBox3
            textBox3.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(107, 333);
            textBox3.Size = new Size(38, 34);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.BackColor = Color.FromArgb(26, 28, 28);
            textBox3.ForeColor = Color.White;
            textBox3.KeyPress += notificationTextBoxes_KeyPress;
            textBox3.Tag = 2;
            //
            //textBox4
            textBox4.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(171, 333);
            textBox4.Size = new Size(66, 34);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.BackColor = Color.FromArgb(26, 28, 28);
            textBox4.ForeColor = Color.White;
            textBox4.KeyPress += notificationTextBoxes_KeyPress;
            textBox4.Tag = 3;
            //
            //textBox5
            textBox5.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(282, 333);
            textBox5.Size = new Size(38, 34);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.BackColor = Color.FromArgb(26, 28, 28);
            textBox5.ForeColor = Color.White;
            textBox5.KeyPress += notificationTextBoxes_KeyPress;
            textBox5.Tag = 4;
            //
            //textBox6
            textBox6.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(339, 333);
            textBox6.Size = new Size(38, 34);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.BackColor = Color.FromArgb(26, 28, 28);
            textBox6.ForeColor = Color.White;
            textBox6.KeyPress += notificationTextBoxes_KeyPress;
            textBox6.Tag = 5;
            //
            //radioButton4
            radioButton4.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(3, 3);
            radioButton4.Size = new Size(172, 31);
            radioButton4.Text = "Не повторять";
            //
            //radioButton5
            radioButton5.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.ForeColor = Color.White;
            radioButton5.Location = new Point(3, 40);
            radioButton5.Size = new Size(194, 31);
            radioButton5.Text = "Ежедневно";
            //
            //radioButton6
            radioButton6.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton6.ForeColor = Color.White;
            radioButton6.Location = new Point(3, 77);
            radioButton6.Size = new Size(154, 31);
            radioButton6.Text = "Еженедельно";
            //
            //radioButton7
            radioButton7.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton7.ForeColor = Color.White;
            radioButton7.Location = new Point(4, 114);
            radioButton7.Size = new Size(171, 31);
            radioButton7.Text = "Ежемесячно";
            //
            //radioButton8
            radioButton8.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton8.ForeColor = Color.White;
            radioButton8.Location = new Point(3, 151);
            radioButton8.Size = new Size(163, 31);
            radioButton8.Text = "Ежегодно";
        }

        private void Setting_Add_TheCounter_For_Habits()
        {
            //label8
            label8.Text = "Цель выполнения за день:";
            label8.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 333);
            label8.Size = new Size(288, 27);

            //text_for_Counter
            text_for_counter.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            text_for_counter.Location = new Point(341, 333);
            text_for_counter.Size = new Size(100, 34);
            text_for_counter.BorderStyle = BorderStyle.FixedSingle;
            text_for_counter.BackColor = Color.FromArgb(26, 28, 28);
            text_for_counter.ForeColor = Color.White;
        }

        //Переключатель появления частоты и времени уведомлений
        private void ToggleNotificationSettingsUI(bool isNotificationSettingsVisible)
        {
            if (isNotificationSettingsVisible == true)
            {
                this.Controls.Add(panel);
                this.Controls.Add(label3);
                this.Controls.Add(label4);
                this.Controls.Add(label5);
                this.Controls.Add(label6);
                this.Controls.Add(label7);
                this.Controls.Add(textBox2);
                this.Controls.Add(textBox3);
                this.Controls.Add(textBox4);
                this.Controls.Add(textBox5);
                this.Controls.Add(textBox6);
                this.panel.Controls.Add(this.radioButton4);
                this.panel.Controls.Add(this.radioButton5);
                this.panel.Controls.Add(this.radioButton6);
                this.panel.Controls.Add(this.radioButton7);
                this.panel.Controls.Add(this.radioButton8);
            }
            else
            {
                this.Controls.Remove(panel);
                this.Controls.Remove(label3);
                this.Controls.Remove(label4);
                this.Controls.Remove(label5);
                this.Controls.Remove(label6);
                this.Controls.Remove(label7);
                this.Controls.Remove(textBox2);
                this.Controls.Remove(textBox3);
                this.Controls.Remove(textBox4);
                this.Controls.Remove(textBox5);
                this.Controls.Remove(textBox6);
                this.panel.Controls.Remove(this.radioButton4);
                this.panel.Controls.Remove(this.radioButton5);
                this.panel.Controls.Remove(this.radioButton6);
                this.panel.Controls.Remove(this.radioButton7);
                this.panel.Controls.Remove(this.radioButton8);
            }
        }

        private void Add_TheCounter_On_TheForm()
        {
            this.Controls.Add(label8);
            this.Controls.Add(text_for_counter);
        }

        private void Delete_TheCounter_From_theForm()
        {
            this.Controls.Remove(label8);
            this.Controls.Remove(text_for_counter);
        }

        private void MaxMinSizeForm(int width, int height)
        {
            this.MaximumSize = new Size(width, height);
            this.MinimumSize = new Size(width, height);
        }

        private void Categories_CheckedTrue()
        {
            if (planned_activities.Checked)
            {
                MaxMinSizeForm(520, 723);
                this.Size = new Size(520, 723);
                ToggleNotificationSettingsUI(true);
                Delete_TheCounter_From_theForm();
            }
            else if (habits.Checked)
            {
                MaxMinSizeForm(520, 431);
                this.Size = new Size(520, 431);
                Add_TheCounter_On_TheForm();
                ToggleNotificationSettingsUI(false);
            }
            else if (objectives.Checked)
            {
                MaxMinSizeForm(520, 332);
                this.Size = new Size(520, 332);
                Delete_TheCounter_From_theForm();
                ToggleNotificationSettingsUI(false);
            }
        }

        //Проверка на заполнение TextBoxes и RadioButtons
        private bool check_text(TextBox textBox)
        {
            if (textBox.Text.Equals(string.Empty))
            {
                return false;
            }
            return true;
        }

        private bool Validate_Text_Fields()
        {
            TextBox[] notificationTimeBoxes = { textBox2, textBox3, textBox4, textBox5, textBox6 };

            if (!planned_activities.Checked && !habits.Checked)
            {
                if (!check_text(text_name))
                {
                    return false;
                }
            }
            else if (planned_activities.Checked)
            {
                foreach (TextBox textBox in notificationTimeBoxes)
                {
                    if (!check_text(textBox))
                    {
                        return false;
                    }
                    
                    if(check_text(textBox))
                    {
                        switch (textBox.Tag)
                        {
                            case 1:
                                day = Convert.ToInt32(textBox.Text);
                                break;
                            case 2:
                                morth = Convert.ToInt32(textBox.Text);
                                break;
                            case 3:
                                year = Convert.ToInt32(textBox.Text);
                                break;
                            case 4:
                                hour = Convert.ToInt32(textBox.Text);
                                break;
                            case 5:
                                minutes = Convert.ToInt32(textBox.Text);
                                break;
                        }    
                    }
                }

                dateTime = new DateTime(year, morth, day, hour, minutes, 0);

                if (dateTime < DateTime.Now)
                {
                    return false;
                }

                if (!check_text(text_name))
                {
                    return false;
                }
            }
            else if (habits.Checked)
            {
                if (!check_text(text_for_counter))
                {
                    return false;
                }

                if (!check_text(text_name))
                {
                    return false;
                }
            }

            return true;
        }

        private bool Validate_Repeat_And_Category()
        {
            RadioButton[] repeatRadioButtons = { radioButton4, radioButton5, radioButton6, radioButton7, radioButton8};


            if (!planned_activities.Checked)
            {
                if (!habits.Checked && !objectives.Checked)
                {
                    return false;
                }
            }
            else if (planned_activities.Checked)
            {
                bool anyRepeatSelected = false;
                foreach (RadioButton radioButton in repeatRadioButtons)
                {
                    if (radioButton.Checked)
                    {
                        anyRepeatSelected = true;
                        break;
                    }
                }

                if (!anyRepeatSelected)
                {
                    return false;
                }
            }

            return true;
        }

        private void notificationTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.KeyChar = (char)Keys.None;

        }

        //Обновление изображения add_case
        private void Update_status_add_case()
        {
            if (Validate_Text_Fields() && Validate_Repeat_And_Category())
            {
                add_case.Image = Image.FromFile(Directory.GetCurrentDirectory() + "//icons//add_white.png");
                add_case.Enabled = true;
            }
            else
            {
                add_case.Image = Image.FromFile(Directory.GetCurrentDirectory() + "//icons//add_graphite_black.png");
                add_case.Enabled = false;
            }
        }

        //Проверка статуса изображения add_case при событии checkedchanged
        private void categories_and_repeats_CheckedChanged(object sender, EventArgs e)
        {
            Categories_CheckedTrue();
            Update_status_add_case();
        }


        //Проверка статуса изображения add_case при событие textchenges
        private void AllTextBoxes_TextChanged(object sender, EventArgs e)
        {
            Update_status_add_case();
        }

        private void add_case_Click(object sender, EventArgs e)
        {
            text_nameCase = Convert.ToString(text_name.Text);
            habitCategory = Convert.ToBoolean(habits.Checked);
            objectiveCategory = Convert.ToBoolean(objectives.Checked);
            plannedActivitiesCategory = Convert.ToBoolean(planned_activities.Checked);

            ClosedByAddCase = true;
            if (habitCategory)
            {
                counter_text = Convert.ToInt32(text_for_counter.Text);
            }

            this.Close();
        }


    }
}
