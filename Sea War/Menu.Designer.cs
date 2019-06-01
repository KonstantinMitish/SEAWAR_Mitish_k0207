namespace Sea_War
{
    partial class Menu_frm
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
            this.components = new System.ComponentModel.Container();
            this.btn_Play = new System.Windows.Forms.Button();
            this.pic_Russian = new System.Windows.Forms.PictureBox();
            this.panel_own = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_Pirate = new System.Windows.Forms.PictureBox();
            this.pic_Britan = new System.Windows.Forms.PictureBox();
            this.pic_Spanish = new System.Windows.Forms.PictureBox();
            this.panel_enemy = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_Russian2 = new System.Windows.Forms.PictureBox();
            this.pic_Prirate2 = new System.Windows.Forms.PictureBox();
            this.pic_Britan2 = new System.Windows.Forms.PictureBox();
            this.pic_Spanish2 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Play_toGame = new System.Windows.Forms.Button();
            this.btn_score = new System.Windows.Forms.Button();
            this.lst_score_name = new System.Windows.Forms.ListBox();
            this.lst_score_score = new System.Windows.Forms.ListBox();
            this.btn_back_score = new System.Windows.Forms.Button();
            this.btn_score_clear = new System.Windows.Forms.Button();
            this.btn_back_score_delay = new System.Windows.Forms.Timer(this.components);
            this.btn_load = new System.Windows.Forms.Button();
            this.dlg_load = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Russian)).BeginInit();
            this.panel_own.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pirate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Britan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Spanish)).BeginInit();
            this.panel_enemy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Russian2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Prirate2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Britan2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Spanish2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_Play.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Play.FlatAppearance.BorderSize = 10;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Play.ForeColor = System.Drawing.Color.White;
            this.btn_Play.Location = new System.Drawing.Point(20, 423);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(854, 107);
            this.btn_Play.TabIndex = 4;
            this.btn_Play.Text = "НОВАЯ ИГРА";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // pic_Russian
            // 
            this.pic_Russian.BackgroundImage = global::Sea_War.Properties.Resources.Flag_Russian;
            this.pic_Russian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Russian.Location = new System.Drawing.Point(3, 3);
            this.pic_Russian.Name = "pic_Russian";
            this.pic_Russian.Size = new System.Drawing.Size(330, 165);
            this.pic_Russian.TabIndex = 5;
            this.pic_Russian.TabStop = false;
            this.pic_Russian.Tag = "Russian";
            this.pic_Russian.Click += new System.EventHandler(this.pic_Spanish_Click);
            // 
            // panel_own
            // 
            this.panel_own.Controls.Add(this.pic_Russian);
            this.panel_own.Controls.Add(this.pic_Pirate);
            this.panel_own.Controls.Add(this.pic_Britan);
            this.panel_own.Controls.Add(this.pic_Spanish);
            this.panel_own.Location = new System.Drawing.Point(1090, 537);
            this.panel_own.Name = "panel_own";
            this.panel_own.Size = new System.Drawing.Size(672, 343);
            this.panel_own.TabIndex = 6;
            this.panel_own.Visible = false;
            // 
            // pic_Pirate
            // 
            this.pic_Pirate.BackgroundImage = global::Sea_War.Properties.Resources.Flag_Pirate;
            this.pic_Pirate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Pirate.Location = new System.Drawing.Point(339, 3);
            this.pic_Pirate.Name = "pic_Pirate";
            this.pic_Pirate.Size = new System.Drawing.Size(330, 165);
            this.pic_Pirate.TabIndex = 5;
            this.pic_Pirate.TabStop = false;
            this.pic_Pirate.Tag = "Pirate";
            this.pic_Pirate.Click += new System.EventHandler(this.pic_Spanish_Click);
            // 
            // pic_Britan
            // 
            this.pic_Britan.BackgroundImage = global::Sea_War.Properties.Resources.Flag_Britan;
            this.pic_Britan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Britan.Location = new System.Drawing.Point(3, 174);
            this.pic_Britan.Name = "pic_Britan";
            this.pic_Britan.Size = new System.Drawing.Size(330, 165);
            this.pic_Britan.TabIndex = 5;
            this.pic_Britan.TabStop = false;
            this.pic_Britan.Tag = "Britan";
            this.pic_Britan.Click += new System.EventHandler(this.pic_Spanish_Click);
            // 
            // pic_Spanish
            // 
            this.pic_Spanish.BackgroundImage = global::Sea_War.Properties.Resources.Flag_Spanish1;
            this.pic_Spanish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Spanish.Location = new System.Drawing.Point(339, 174);
            this.pic_Spanish.Name = "pic_Spanish";
            this.pic_Spanish.Size = new System.Drawing.Size(330, 165);
            this.pic_Spanish.TabIndex = 5;
            this.pic_Spanish.TabStop = false;
            this.pic_Spanish.Tag = "Spanish";
            this.pic_Spanish.Click += new System.EventHandler(this.pic_Spanish_Click);
            // 
            // panel_enemy
            // 
            this.panel_enemy.Controls.Add(this.pic_Russian2);
            this.panel_enemy.Controls.Add(this.pic_Prirate2);
            this.panel_enemy.Controls.Add(this.pic_Britan2);
            this.panel_enemy.Controls.Add(this.pic_Spanish2);
            this.panel_enemy.Location = new System.Drawing.Point(1141, 148);
            this.panel_enemy.Name = "panel_enemy";
            this.panel_enemy.Size = new System.Drawing.Size(672, 343);
            this.panel_enemy.TabIndex = 6;
            this.panel_enemy.Visible = false;
            // 
            // pic_Russian2
            // 
            this.pic_Russian2.BackgroundImage = global::Sea_War.Properties.Resources.Flag_Russian;
            this.pic_Russian2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Russian2.Location = new System.Drawing.Point(3, 3);
            this.pic_Russian2.Name = "pic_Russian2";
            this.pic_Russian2.Size = new System.Drawing.Size(330, 165);
            this.pic_Russian2.TabIndex = 5;
            this.pic_Russian2.TabStop = false;
            this.pic_Russian2.Tag = "Russian";
            this.pic_Russian2.Click += new System.EventHandler(this.pic_Russian2_Click);
            // 
            // pic_Prirate2
            // 
            this.pic_Prirate2.BackgroundImage = global::Sea_War.Properties.Resources.Flag_Pirate;
            this.pic_Prirate2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Prirate2.Location = new System.Drawing.Point(339, 3);
            this.pic_Prirate2.Name = "pic_Prirate2";
            this.pic_Prirate2.Size = new System.Drawing.Size(330, 165);
            this.pic_Prirate2.TabIndex = 5;
            this.pic_Prirate2.TabStop = false;
            this.pic_Prirate2.Tag = "Pirate";
            this.pic_Prirate2.Click += new System.EventHandler(this.pic_Russian2_Click);
            // 
            // pic_Britan2
            // 
            this.pic_Britan2.BackgroundImage = global::Sea_War.Properties.Resources.Flag_Britan1;
            this.pic_Britan2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Britan2.Location = new System.Drawing.Point(3, 174);
            this.pic_Britan2.Name = "pic_Britan2";
            this.pic_Britan2.Size = new System.Drawing.Size(330, 165);
            this.pic_Britan2.TabIndex = 5;
            this.pic_Britan2.TabStop = false;
            this.pic_Britan2.Tag = "Britan";
            this.pic_Britan2.Click += new System.EventHandler(this.pic_Russian2_Click);
            // 
            // pic_Spanish2
            // 
            this.pic_Spanish2.BackgroundImage = global::Sea_War.Properties.Resources.Flag_Spanish;
            this.pic_Spanish2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Spanish2.Location = new System.Drawing.Point(339, 174);
            this.pic_Spanish2.Name = "pic_Spanish2";
            this.pic_Spanish2.Size = new System.Drawing.Size(330, 165);
            this.pic_Spanish2.TabIndex = 5;
            this.pic_Spanish2.TabStop = false;
            this.pic_Spanish2.Tag = "Spanish";
            this.pic_Spanish2.Click += new System.EventHandler(this.pic_Russian2_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back.FlatAppearance.BorderSize = 10;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(30, 213);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(403, 176);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Visible = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Exit.FlatAppearance.BorderSize = 10;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(-27, 491);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(854, 214);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "ВЫХОД";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 100);
            this.label1.TabIndex = 7;
            this.label1.Tag = "";
            this.label1.Text = "Выберите команду";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(657, 94);
            this.label2.TabIndex = 7;
            this.label2.Tag = "";
            this.label2.Text = "Свою";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(900, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 94);
            this.label3.TabIndex = 7;
            this.label3.Tag = "";
            this.label3.Text = "Врага";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // btn_Play_toGame
            // 
            this.btn_Play_toGame.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_Play_toGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Play_toGame.FlatAppearance.BorderSize = 10;
            this.btn_Play_toGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play_toGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Play_toGame.ForeColor = System.Drawing.Color.White;
            this.btn_Play_toGame.Location = new System.Drawing.Point(164, 292);
            this.btn_Play_toGame.Name = "btn_Play_toGame";
            this.btn_Play_toGame.Size = new System.Drawing.Size(403, 176);
            this.btn_Play_toGame.TabIndex = 4;
            this.btn_Play_toGame.Text = "Играть";
            this.btn_Play_toGame.UseVisualStyleBackColor = true;
            this.btn_Play_toGame.Visible = false;
            this.btn_Play_toGame.Click += new System.EventHandler(this.btn_Play_toGame_Click);
            // 
            // btn_score
            // 
            this.btn_score.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_score.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_score.FlatAppearance.BorderSize = 10;
            this.btn_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_score.ForeColor = System.Drawing.Color.White;
            this.btn_score.Location = new System.Drawing.Point(12, 66);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(907, 127);
            this.btn_score.TabIndex = 4;
            this.btn_score.Text = "ПОСЛЕДНИЕ ИГРОКИ";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // lst_score_name
            // 
            this.lst_score_name.BackColor = System.Drawing.Color.SaddleBrown;
            this.lst_score_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_score_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lst_score_name.ForeColor = System.Drawing.Color.White;
            this.lst_score_name.FormattingEnabled = true;
            this.lst_score_name.ItemHeight = 38;
            this.lst_score_name.Location = new System.Drawing.Point(52, 112);
            this.lst_score_name.Name = "lst_score_name";
            this.lst_score_name.Size = new System.Drawing.Size(152, 152);
            this.lst_score_name.TabIndex = 8;
            this.lst_score_name.Visible = false;
            this.lst_score_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lst_score_name_MouseDown);
            this.lst_score_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lst_score_name_MouseMove);
            this.lst_score_name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lst_score_score_MouseUp);
            // 
            // lst_score_score
            // 
            this.lst_score_score.BackColor = System.Drawing.Color.SaddleBrown;
            this.lst_score_score.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lst_score_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lst_score_score.ForeColor = System.Drawing.Color.White;
            this.lst_score_score.FormattingEnabled = true;
            this.lst_score_score.ItemHeight = 38;
            this.lst_score_score.Location = new System.Drawing.Point(200, 112);
            this.lst_score_score.Name = "lst_score_score";
            this.lst_score_score.Size = new System.Drawing.Size(152, 152);
            this.lst_score_score.TabIndex = 8;
            this.lst_score_score.Visible = false;
            this.lst_score_score.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lst_score_name_MouseDown);
            this.lst_score_score.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lst_score_name_MouseMove);
            this.lst_score_score.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lst_score_score_MouseUp);
            // 
            // btn_back_score
            // 
            this.btn_back_score.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_back_score.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back_score.FlatAppearance.BorderSize = 10;
            this.btn_back_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back_score.ForeColor = System.Drawing.Color.White;
            this.btn_back_score.Location = new System.Drawing.Point(-42, 241);
            this.btn_back_score.Name = "btn_back_score";
            this.btn_back_score.Size = new System.Drawing.Size(907, 190);
            this.btn_back_score.TabIndex = 4;
            this.btn_back_score.Text = "Назад";
            this.btn_back_score.UseVisualStyleBackColor = true;
            this.btn_back_score.Visible = false;
            this.btn_back_score.Click += new System.EventHandler(this.btn_back_score_Click);
            // 
            // btn_score_clear
            // 
            this.btn_score_clear.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_score_clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_score_clear.FlatAppearance.BorderSize = 10;
            this.btn_score_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_score_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_score_clear.ForeColor = System.Drawing.Color.White;
            this.btn_score_clear.Location = new System.Drawing.Point(-2, 171);
            this.btn_score_clear.Name = "btn_score_clear";
            this.btn_score_clear.Size = new System.Drawing.Size(907, 176);
            this.btn_score_clear.TabIndex = 4;
            this.btn_score_clear.Text = "Очистить";
            this.btn_score_clear.UseVisualStyleBackColor = true;
            this.btn_score_clear.Visible = false;
            this.btn_score_clear.Click += new System.EventHandler(this.btn_score_clear_Click);
            // 
            // btn_back_score_delay
            // 
            this.btn_back_score_delay.Interval = 1000;
            this.btn_back_score_delay.Tick += new System.EventHandler(this.btn_back_score_delay_Tick);
            // 
            // btn_load
            // 
            this.btn_load.BackgroundImage = global::Sea_War.Properties.Resources.Button;
            this.btn_load.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_load.FlatAppearance.BorderSize = 10;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(164, 474);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(854, 107);
            this.btn_load.TabIndex = 4;
            this.btn_load.Text = "ЗАГРУЗИТЬ ИГРУ";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // dlg_load
            // 
            this.dlg_load.Filter = "Файлы сохранений|*.sws";
            this.dlg_load.FileOk += new System.ComponentModel.CancelEventHandler(this.dlg_load_FileOk);
            // 
            // Menu_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sea_War.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 727);
            this.Controls.Add(this.lst_score_score);
            this.Controls.Add(this.lst_score_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_score_clear);
            this.Controls.Add(this.btn_back_score);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.btn_Play_toGame);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel_enemy);
            this.Controls.Add(this.panel_own);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_Play);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_frm";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Russian)).EndInit();
            this.panel_own.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pirate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Britan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Spanish)).EndInit();
            this.panel_enemy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Russian2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Prirate2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Britan2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Spanish2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.PictureBox pic_Russian;
        private System.Windows.Forms.FlowLayoutPanel panel_own;
        private System.Windows.Forms.PictureBox pic_Pirate;
        private System.Windows.Forms.PictureBox pic_Britan;
        private System.Windows.Forms.PictureBox pic_Spanish;
        private System.Windows.Forms.FlowLayoutPanel panel_enemy;
        private System.Windows.Forms.PictureBox pic_Russian2;
        private System.Windows.Forms.PictureBox pic_Prirate2;
        private System.Windows.Forms.PictureBox pic_Britan2;
        private System.Windows.Forms.PictureBox pic_Spanish2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Play_toGame;
        private System.Windows.Forms.Button btn_score;
        private System.Windows.Forms.ListBox lst_score_name;
        private System.Windows.Forms.ListBox lst_score_score;
        private System.Windows.Forms.Button btn_back_score;
        private System.Windows.Forms.Button btn_score_clear;
        private System.Windows.Forms.Timer btn_back_score_delay;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.OpenFileDialog dlg_load;

    }
}