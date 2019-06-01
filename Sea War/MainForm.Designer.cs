namespace Sea_War
{
    partial class MainForm
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
            this.lbl_score_O = new System.Windows.Forms.Label();
            this.lbl_Layout = new System.Windows.Forms.Label();
            this.CommandLine = new System.Windows.Forms.TextBox();
            this.lbl_score_E = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_flag_O = new System.Windows.Forms.PictureBox();
            this.pic_flag_E = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.PictureBox();
            this.pic_ships_own = new System.Windows.Forms.PictureBox();
            this.pic_ships_enemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_flag_O)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_flag_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ships_own)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ships_enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_score_O
            // 
            this.lbl_score_O.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_score_O.ForeColor = System.Drawing.Color.White;
            this.lbl_score_O.Location = new System.Drawing.Point(236, 161);
            this.lbl_score_O.Name = "lbl_score_O";
            this.lbl_score_O.Size = new System.Drawing.Size(200, 100);
            this.lbl_score_O.TabIndex = 1;
            this.lbl_score_O.Text = "10";
            this.lbl_score_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Layout
            // 
            this.lbl_Layout.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Layout.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Layout.ForeColor = System.Drawing.Color.Black;
            this.lbl_Layout.Location = new System.Drawing.Point(95, 411);
            this.lbl_Layout.Name = "lbl_Layout";
            this.lbl_Layout.Size = new System.Drawing.Size(306, 177);
            this.lbl_Layout.TabIndex = 3;
            this.lbl_Layout.Text = "label1";
            this.lbl_Layout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommandLine
            // 
            this.CommandLine.BackColor = System.Drawing.Color.Black;
            this.CommandLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommandLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommandLine.ForeColor = System.Drawing.Color.White;
            this.CommandLine.Location = new System.Drawing.Point(1, 1);
            this.CommandLine.Name = "CommandLine";
            this.CommandLine.Size = new System.Drawing.Size(100, 16);
            this.CommandLine.TabIndex = 4;
            this.CommandLine.Visible = false;
            this.CommandLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            // 
            // lbl_score_E
            // 
            this.lbl_score_E.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score_E.Font = new System.Drawing.Font("Microsoft Sans Serif", 69.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_score_E.ForeColor = System.Drawing.Color.White;
            this.lbl_score_E.Location = new System.Drawing.Point(252, 364);
            this.lbl_score_E.Name = "lbl_score_E";
            this.lbl_score_E.Size = new System.Drawing.Size(200, 100);
            this.lbl_score_E.TabIndex = 1;
            this.lbl_score_E.Text = "10";
            this.lbl_score_E.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(355, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 152);
            this.label1.TabIndex = 1;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_flag_O
            // 
            this.pic_flag_O.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_flag_O.Location = new System.Drawing.Point(1, 117);
            this.pic_flag_O.Name = "pic_flag_O";
            this.pic_flag_O.Size = new System.Drawing.Size(200, 100);
            this.pic_flag_O.TabIndex = 5;
            this.pic_flag_O.TabStop = false;
            // 
            // pic_flag_E
            // 
            this.pic_flag_E.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_flag_E.Location = new System.Drawing.Point(421, 254);
            this.pic_flag_E.Name = "pic_flag_E";
            this.pic_flag_E.Size = new System.Drawing.Size(200, 100);
            this.pic_flag_E.TabIndex = 5;
            this.pic_flag_E.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BackgroundImage = global::Sea_War.Properties.Resources.Pausepng;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.Location = new System.Drawing.Point(304, 41);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(50, 50);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.TabStop = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pic_ships_own
            // 
            this.pic_ships_own.BackColor = System.Drawing.Color.Lime;
            this.pic_ships_own.Location = new System.Drawing.Point(-90, 288);
            this.pic_ships_own.Name = "pic_ships_own";
            this.pic_ships_own.Size = new System.Drawing.Size(300, 300);
            this.pic_ships_own.TabIndex = 0;
            this.pic_ships_own.TabStop = false;
            this.pic_ships_own.Tag = "own";
            this.pic_ships_own.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_ships_own_Paint);
            this.pic_ships_own.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_ships_own_MouseDown);
            // 
            // pic_ships_enemy
            // 
            this.pic_ships_enemy.BackColor = System.Drawing.Color.Blue;
            this.pic_ships_enemy.Location = new System.Drawing.Point(1, 213);
            this.pic_ships_enemy.Name = "pic_ships_enemy";
            this.pic_ships_enemy.Size = new System.Drawing.Size(300, 300);
            this.pic_ships_enemy.TabIndex = 0;
            this.pic_ships_enemy.TabStop = false;
            this.pic_ships_enemy.Tag = "enemy";
            this.pic_ships_enemy.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_ships_enemy_Paint);
            this.pic_ships_enemy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_ships_enemy_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(473, 650);
            this.Controls.Add(this.pic_flag_O);
            this.Controls.Add(this.pic_flag_E);
            this.Controls.Add(this.CommandLine);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_score_E);
            this.Controls.Add(this.lbl_score_O);
            this.Controls.Add(this.pic_ships_own);
            this.Controls.Add(this.pic_ships_enemy);
            this.Controls.Add(this.lbl_Layout);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_flag_O)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_flag_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ships_own)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ships_enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_ships_enemy;
        private System.Windows.Forms.PictureBox pic_ships_own;
        private System.Windows.Forms.Label lbl_score_O;
        private System.Windows.Forms.PictureBox btn_Exit;
        private System.Windows.Forms.Label lbl_Layout;
        private System.Windows.Forms.TextBox CommandLine;
        private System.Windows.Forms.PictureBox pic_flag_E;
        private System.Windows.Forms.PictureBox pic_flag_O;
        private System.Windows.Forms.Label lbl_score_E;
        private System.Windows.Forms.Label label1;
    }
}

