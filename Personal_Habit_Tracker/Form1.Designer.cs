namespace Personal_Habit_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icon_add = new System.Windows.Forms.PictureBox();
            this.icon_statistics = new System.Windows.Forms.PictureBox();
            this.icon_history = new System.Windows.Forms.PictureBox();
            this.icon_setting = new System.Windows.Forms.PictureBox();
            this.icon_delete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_statistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // icon_add
            // 
            this.icon_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            resources.ApplyResources(this.icon_add, "icon_add");
            this.icon_add.Name = "icon_add";
            this.icon_add.TabStop = false;
            this.icon_add.Click += new System.EventHandler(this.icons_Click);
            this.icon_add.MouseLeave += new System.EventHandler(this.icons_MouseLeave);
            this.icon_add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.icons_MouseMove);
            // 
            // icon_statistics
            // 
            this.icon_statistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            resources.ApplyResources(this.icon_statistics, "icon_statistics");
            this.icon_statistics.Name = "icon_statistics";
            this.icon_statistics.TabStop = false;
            // 
            // icon_history
            // 
            this.icon_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            resources.ApplyResources(this.icon_history, "icon_history");
            this.icon_history.Name = "icon_history";
            this.icon_history.TabStop = false;
            // 
            // icon_setting
            // 
            this.icon_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            resources.ApplyResources(this.icon_setting, "icon_setting");
            this.icon_setting.Name = "icon_setting";
            this.icon_setting.TabStop = false;
            // 
            // icon_delete
            // 
            this.icon_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            resources.ApplyResources(this.icon_delete, "icon_delete");
            this.icon_delete.Name = "icon_delete";
            this.icon_delete.TabStop = false;
            this.icon_delete.Click += new System.EventHandler(this.icon_delete_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.icon_delete);
            this.Controls.Add(this.icon_setting);
            this.Controls.Add(this.icon_history);
            this.Controls.Add(this.icon_statistics);
            this.Controls.Add(this.icon_add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_statistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox icon_add;
        private System.Windows.Forms.PictureBox icon_statistics;
        private System.Windows.Forms.PictureBox icon_history;
        private System.Windows.Forms.PictureBox icon_setting;
        private System.Windows.Forms.PictureBox icon_delete;
        private System.Windows.Forms.Label label2;
    }
}

