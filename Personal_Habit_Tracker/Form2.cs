using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Personal_Habit_Tracker
{
    public partial class Form2 : Form
    {
        Panel panel = new Panel();
        Label label3 = new Label();
        Label label4 = new Label();
        Label label5 = new Label();
        Label label6 = new Label();
        Label label7 = new Label();
        TextBox textBox2 = new TextBox();
        TextBox textBox3 = new TextBox();
        TextBox textBox4 = new TextBox();
        TextBox textBox5 = new TextBox();
        TextBox textBox6 = new TextBox();
        RadioButton radioButton3 = new RadioButton();
        RadioButton radioButton4 = new RadioButton();
        RadioButton radioButton5 = new RadioButton();
        RadioButton radioButton6 = new RadioButton();
        RadioButton radioButton7 = new RadioButton();
        RadioButton radioButton8 = new RadioButton();

        public Form2()
        {
            InitializeComponent();
            Setting_NotificationTime_and_Repeat();

            radioButton2.CheckedChanged += categories_CheckedChanged;
        }

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
            label6.Location = new Point(292, 333);
            label6.Size = new Size(19, 27);
            label6.ForeColor = Color.White;

            //label7
            label7.Text = "Повторение";
            label7.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(12, 400);
            label7.Size = new Size(135, 27);
            label7.ForeColor = Color.White;

            //textBox2
            textBox2.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(39, 333);
            textBox2.Size = new Size(38, 34);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.BackColor = Color.FromArgb(26, 28, 28);
            textBox2.ForeColor = Color.White;
            //
            //textBox3
            textBox3.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(107, 333);
            textBox3.Size = new Size(38, 34);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.BackColor = Color.FromArgb(26, 28, 28);
            textBox3.ForeColor = Color.White;
            //
            //textBox4
            textBox4.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(171, 333);
            textBox4.Size = new Size(38, 34);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.BackColor = Color.FromArgb(26, 28, 28);
            textBox4.ForeColor = Color.White;
            //
            //textBox5
            textBox5.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(254, 333);
            textBox5.Size = new Size(38, 34);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.BackColor = Color.FromArgb(26, 28, 28);
            textBox5.ForeColor = Color.White;
            //
            //textBox6
            textBox6.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox6.Location = new Point(311, 333);
            textBox6.Size = new Size(38, 34);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.BackColor = Color.FromArgb(26, 28, 28);
            textBox6.ForeColor = Color.White;
            //
            //radioButton3
            radioButton3.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(3, 3);
            radioButton3.Size = new Size(172, 31);
            radioButton3.Text = "Не повторять";

            //radioButton4
            radioButton4.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(3, 40);
            radioButton4.Size = new Size(194, 31);
            radioButton4.Text = "Каждую минуту";

            //radioButton5
            radioButton5.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton5.ForeColor = Color.White;
            radioButton5.Location = new Point(3, 77);
            radioButton5.Size = new Size(154, 31);
            radioButton5.Text = "Каждый час";

            //radioButton6
            radioButton6.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton6.ForeColor = Color.White;
            radioButton6.Location = new Point(4, 114);
            radioButton6.Size = new Size(171, 31);
            radioButton6.Text = "Еженедельно";

            //radioButton7
            radioButton7.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton7.ForeColor = Color.White;
            radioButton7.Location = new Point(3, 151);
            radioButton7.Size = new Size(163, 31);
            radioButton7.Text = "Ежемесячно";

            //radioButton8
            radioButton8.Font = new Font("Segoe MDL2 Assets", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton8.ForeColor = Color.White;
            radioButton8.Location = new Point(4, 188);
            radioButton8.Size = new Size(132, 31);
            radioButton8.Text = "Ежегодно";

        }

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
                this.panel.Controls.Add(this.radioButton3);
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
                this.panel.Controls.Remove(this.radioButton3);
                this.panel.Controls.Remove(this.radioButton4);
                this.panel.Controls.Remove(this.radioButton5);
                this.panel.Controls.Remove(this.radioButton6);
                this.panel.Controls.Remove(this.radioButton7);
                this.panel.Controls.Remove(this.radioButton8);
            }
        }

        private void add_time_CheckedChanged(object sender, System.EventArgs e)
        {
            if (add_time.Checked)
            {
                this.Size = new Size(520, 723);
                ToggleNotificationSettingsUI(true);
                radioButton3.Checked = true;
            }
            else
            {
                this.Size = new Size(520, 332);
                ToggleNotificationSettingsUI(false);
            }
        }

        private bool check_text(TextBox textBox)
        {
            if (textBox.Text.Equals(string.Empty))
            {
                return false;
            }
            return true;
        }

        private bool check_checked(RadioButton radioButton)
        {
            if (!radioButton.Checked)
            {
                return false;
            }
            return true;
        }

        private bool Validate_Text_Fields()
        {
            TextBox[] notificationTimeBoxes = { textBox2, textBox3, textBox4, textBox5, textBox6 };

            if (!add_time.Checked)
            {
                if (!check_text(text_name))
                {
                    return false;
                }
            }
            else
            {
                foreach (TextBox textBox in notificationTimeBoxes)
                {
                    if (!check_text(textBox))
                    {
                        return false;
                    }
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
            RadioButton[] repeatRadioButtons = { radioButton3, radioButton4, radioButton5, radioButton6, radioButton7, radioButton8 };


            if (!add_time.Checked)
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                    return false;
                }
            }
            else
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

                if (!anyRepeatSelected && !radioButton1.Checked && !radioButton2.Checked)
                {
                    return false;
                }
            }

            return true;
        }

        private void Update_status_add_case()
        {
            if (Validate_Text_Fields() && Validate_Repeat_And_Category())
            {
                add_case.Image = Image.FromFile(Directory.GetCurrentDirectory() + "//icons//add_white.png");
            }
            else
            {
                add_case.Image = Image.FromFile(Directory.GetCurrentDirectory() + "//icons//add_graphite_black.png");
            }
        }

        private void categories_CheckedChanged(object sender, System.EventArgs e)
        {
            Update_status_add_case();
        }

        private void text_name_TextChanged(object sender, System.EventArgs e)
        {
            Update_status_add_case();
        }

    }
}
