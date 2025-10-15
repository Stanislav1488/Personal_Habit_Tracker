namespace Personal_Habit_Tracker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.text_name = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.add_case = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.habits = new System.Windows.Forms.RadioButton();
            this.objectives = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.planned_activities = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_case)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.text_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_name.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.text_name.ForeColor = System.Drawing.Color.White;
            this.text_name.Location = new System.Drawing.Point(88, 20);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(327, 35);
            this.text_name.TabIndex = 0;
            this.text_name.TextChanged += new System.EventHandler(this.AllTextBoxes_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // add_case
            // 
            this.add_case.Image = ((System.Drawing.Image)(resources.GetObject("add_case.Image")));
            this.add_case.Location = new System.Drawing.Point(442, 12);
            this.add_case.Name = "add_case";
            this.add_case.Size = new System.Drawing.Size(50, 50);
            this.add_case.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.add_case.TabIndex = 5;
            this.add_case.TabStop = false;
            this.add_case.Click += new System.EventHandler(this.add_case_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Категория";
            // 
            // habits
            // 
            this.habits.AutoSize = true;
            this.habits.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.habits.ForeColor = System.Drawing.Color.White;
            this.habits.Location = new System.Drawing.Point(228, 120);
            this.habits.Name = "habits";
            this.habits.Size = new System.Drawing.Size(140, 34);
            this.habits.TabIndex = 7;
            this.habits.TabStop = true;
            this.habits.Text = "Привычки";
            this.habits.UseVisualStyleBackColor = true;
            this.habits.CheckedChanged += new System.EventHandler(this.categories_and_repeats_CheckedChanged);
            // 
            // objectives
            // 
            this.objectives.AutoSize = true;
            this.objectives.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.objectives.ForeColor = System.Drawing.Color.White;
            this.objectives.Location = new System.Drawing.Point(380, 120);
            this.objectives.Name = "objectives";
            this.objectives.Size = new System.Drawing.Size(104, 34);
            this.objectives.TabIndex = 9;
            this.objectives.TabStop = true;
            this.objectives.Text = "Задачи";
            this.objectives.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 207);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Время";
            // 
            // planned_activities
            // 
            this.planned_activities.AutoSize = true;
            this.planned_activities.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.planned_activities.ForeColor = System.Drawing.Color.White;
            this.planned_activities.Location = new System.Drawing.Point(218, 217);
            this.planned_activities.Name = "planned_activities";
            this.planned_activities.Size = new System.Drawing.Size(274, 34);
            this.planned_activities.TabIndex = 13;
            this.planned_activities.TabStop = true;
            this.planned_activities.Text = "Запланированные дела";
            this.planned_activities.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(504, 293);
            this.Controls.Add(this.planned_activities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.objectives);
            this.Controls.Add(this.habits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_case);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_name);
            this.MaximumSize = new System.Drawing.Size(520, 332);
            this.MinimumSize = new System.Drawing.Size(520, 332);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Добавление";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_case)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox add_case;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton habits;
        private System.Windows.Forms.RadioButton objectives;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton planned_activities;
    }
}