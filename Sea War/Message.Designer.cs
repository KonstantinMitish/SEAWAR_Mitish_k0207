namespace Sea_War
{
    partial class Message_FRM
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
            this.lbl_MSg = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Again = new System.Windows.Forms.Button();
            this.btn_res = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.dlg_save = new System.Windows.Forms.SaveFileDialog();
            this.dlg_load = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbl_MSg
            // 
            this.lbl_MSg.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MSg.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_MSg.Location = new System.Drawing.Point(145, 23);
            this.lbl_MSg.Name = "lbl_MSg";
            this.lbl_MSg.Size = new System.Drawing.Size(54, 292);
            this.lbl_MSg.TabIndex = 1;
            this.lbl_MSg.Text = "message Error";
            this.lbl_MSg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_Menu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Menu.FlatAppearance.BorderSize = 3;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Menu.ForeColor = System.Drawing.Color.White;
            this.btn_Menu.Location = new System.Drawing.Point(12, 261);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(327, 123);
            this.btn_Menu.TabIndex = 2;
            this.btn_Menu.Text = "Меню";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Again
            // 
            this.btn_Again.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_Again.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Again.FlatAppearance.BorderSize = 3;
            this.btn_Again.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Again.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Again.ForeColor = System.Drawing.Color.White;
            this.btn_Again.Location = new System.Drawing.Point(12, 119);
            this.btn_Again.Name = "btn_Again";
            this.btn_Again.Size = new System.Drawing.Size(327, 123);
            this.btn_Again.TabIndex = 2;
            this.btn_Again.Text = "Заново";
            this.btn_Again.UseVisualStyleBackColor = true;
            this.btn_Again.Click += new System.EventHandler(this.btn_Again_Click);
            // 
            // btn_res
            // 
            this.btn_res.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_res.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_res.FlatAppearance.BorderSize = 3;
            this.btn_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_res.ForeColor = System.Drawing.Color.White;
            this.btn_res.Location = new System.Drawing.Point(12, 390);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(327, 123);
            this.btn_res.TabIndex = 2;
            this.btn_res.Text = "Продолжить";
            this.btn_res.UseVisualStyleBackColor = true;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 202);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 53);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Введите имя";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Save.FlatAppearance.BorderSize = 3;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(12, 38);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(327, 74);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_Load.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Load.FlatAppearance.BorderSize = 3;
            this.btn_Load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Load.ForeColor = System.Drawing.Color.White;
            this.btn_Load.Location = new System.Drawing.Point(12, 216);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(327, 74);
            this.btn_Load.TabIndex = 2;
            this.btn_Load.Text = "Загрузить";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // dlg_save
            // 
            this.dlg_save.DereferenceLinks = false;
            this.dlg_save.Filter = "Файлы сохранений|*.sws";
            this.dlg_save.FileOk += new System.ComponentModel.CancelEventHandler(this.dlg_save_FileOk);
            // 
            // dlg_load
            // 
            this.dlg_load.Filter = "Файлы сохранений|*.sws";
            this.dlg_load.FileOk += new System.ComponentModel.CancelEventHandler(this.dlg_load_FileOk);
            // 
            // Message_FRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::Sea_War.Properties.Resources.msg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(299, 531);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Again);
            this.Controls.Add(this.lbl_MSg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message_FRM";
            this.Text = "Message";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MSg;
        private System.Windows.Forms.Button btn_Again;
        private System.Windows.Forms.Button btn_Menu;
        public System.Windows.Forms.Button btn_res;
        public System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.SaveFileDialog dlg_save;
        private System.Windows.Forms.OpenFileDialog dlg_load;
    }
}