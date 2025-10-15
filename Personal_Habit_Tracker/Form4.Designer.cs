namespace Personal_Habit_Tracker
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.finished_icon = new System.Windows.Forms.PictureBox();
            this.task_with_notice_icon = new System.Windows.Forms.PictureBox();
            this.habit_icon = new System.Windows.Forms.PictureBox();
            this.task_icon = new System.Windows.Forms.PictureBox();
            this.delete_icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_with_notice_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habit_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 662);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // finished_icon
            // 
            this.finished_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.finished_icon.Image = ((System.Drawing.Image)(resources.GetObject("finished_icon.Image")));
            this.finished_icon.Location = new System.Drawing.Point(6, 6);
            this.finished_icon.Margin = new System.Windows.Forms.Padding(6);
            this.finished_icon.Name = "finished_icon";
            this.finished_icon.Size = new System.Drawing.Size(50, 50);
            this.finished_icon.TabIndex = 28;
            this.finished_icon.TabStop = false;
            this.finished_icon.Click += new System.EventHandler(this.icons_Click);
            this.finished_icon.MouseLeave += new System.EventHandler(this.icons_MouseLeave);
            this.finished_icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icons_MouseMove);
            // 
            // task_with_notice_icon
            // 
            this.task_with_notice_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.task_with_notice_icon.Image = ((System.Drawing.Image)(resources.GetObject("task_with_notice_icon.Image")));
            this.task_with_notice_icon.Location = new System.Drawing.Point(6, 68);
            this.task_with_notice_icon.Margin = new System.Windows.Forms.Padding(6);
            this.task_with_notice_icon.Name = "task_with_notice_icon";
            this.task_with_notice_icon.Size = new System.Drawing.Size(50, 50);
            this.task_with_notice_icon.TabIndex = 29;
            this.task_with_notice_icon.TabStop = false;
            // 
            // habit_icon
            // 
            this.habit_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.habit_icon.Image = ((System.Drawing.Image)(resources.GetObject("habit_icon.Image")));
            this.habit_icon.Location = new System.Drawing.Point(6, 130);
            this.habit_icon.Margin = new System.Windows.Forms.Padding(6);
            this.habit_icon.Name = "habit_icon";
            this.habit_icon.Size = new System.Drawing.Size(50, 50);
            this.habit_icon.TabIndex = 30;
            this.habit_icon.TabStop = false;
            // 
            // task_icon
            // 
            this.task_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.task_icon.Image = ((System.Drawing.Image)(resources.GetObject("task_icon.Image")));
            this.task_icon.Location = new System.Drawing.Point(6, 192);
            this.task_icon.Margin = new System.Windows.Forms.Padding(6);
            this.task_icon.Name = "task_icon";
            this.task_icon.Size = new System.Drawing.Size(50, 50);
            this.task_icon.TabIndex = 31;
            this.task_icon.TabStop = false;
            // 
            // delete_icon
            // 
            this.delete_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.delete_icon.Image = ((System.Drawing.Image)(resources.GetObject("delete_icon.Image")));
            this.delete_icon.Location = new System.Drawing.Point(6, 254);
            this.delete_icon.Margin = new System.Windows.Forms.Padding(6);
            this.delete_icon.Name = "delete_icon";
            this.delete_icon.Size = new System.Drawing.Size(50, 50);
            this.delete_icon.TabIndex = 32;
            this.delete_icon.TabStop = false;
            this.delete_icon.Click += new System.EventHandler(this.delete_icon_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(534, 661);
            this.Controls.Add(this.delete_icon);
            this.Controls.Add(this.task_icon);
            this.Controls.Add(this.habit_icon);
            this.Controls.Add(this.task_with_notice_icon);
            this.Controls.Add(this.finished_icon);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(550, 700);
            this.MinimumSize = new System.Drawing.Size(550, 700);
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Просмотр дел";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finished_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_with_notice_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habit_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.task_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox finished_icon;
        private System.Windows.Forms.PictureBox task_with_notice_icon;
        private System.Windows.Forms.PictureBox habit_icon;
        private System.Windows.Forms.PictureBox task_icon;
        private System.Windows.Forms.PictureBox delete_icon;
    }
}