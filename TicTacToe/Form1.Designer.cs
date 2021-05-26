namespace TicTacToe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_checkwin = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Panel = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.score_reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.score_blue = new System.Windows.Forms.Label();
            this.score_red = new System.Windows.Forms.Label();
            this.panel_newgame = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.score_tie = new System.Windows.Forms.Label();
            this.new_game = new System.Windows.Forms.Button();
            this.label_whowill = new System.Windows.Forms.Label();
            this.label_qmark = new System.Windows.Forms.Label();
            this.label_win = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // label_checkwin
            // 
            this.label_checkwin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_checkwin.Location = new System.Drawing.Point(636, 430);
            this.label_checkwin.Name = "label_checkwin";
            this.label_checkwin.Size = new System.Drawing.Size(147, 31);
            this.label_checkwin.TabIndex = 20;
            this.label_checkwin.Text = "_donotremove";
            this.label_checkwin.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(397, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 125);
            this.button3.TabIndex = 29;
            this.button3.Text = "3";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel.Controls.Add(this.button9);
            this.Panel.Controls.Add(this.button6);
            this.Panel.Controls.Add(this.button8);
            this.Panel.Controls.Add(this.button5);
            this.Panel.Controls.Add(this.button7);
            this.Panel.Controls.Add(this.button4);
            this.Panel.Controls.Add(this.button3);
            this.Panel.Controls.Add(this.button1);
            this.Panel.Controls.Add(this.button2);
            this.Panel.Controls.Add(this.pictureBox7);
            this.Panel.Controls.Add(this.pictureBox8);
            this.Panel.Controls.Add(this.pictureBox9);
            this.Panel.Controls.Add(this.pictureBox4);
            this.Panel.Controls.Add(this.pictureBox6);
            this.Panel.Controls.Add(this.pictureBox1);
            this.Panel.Controls.Add(this.pictureBox5);
            this.Panel.Controls.Add(this.pictureBox3);
            this.Panel.Controls.Add(this.pictureBox2);
            this.Panel.Controls.Add(this.pictureBox10);
            this.Panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel.Location = new System.Drawing.Point(28, 26);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(565, 545);
            this.Panel.TabIndex = 36;
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(397, 395);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 125);
            this.button9.TabIndex = 51;
            this.button9.Text = "9";
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(397, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 125);
            this.button6.TabIndex = 50;
            this.button6.Text = "6";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(166, 372);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(194, 137);
            this.button8.TabIndex = 49;
            this.button8.Text = "8";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(166, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 137);
            this.button5.TabIndex = 48;
            this.button5.Text = "5";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.AutoEllipsis = true;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(17, 383);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(113, 137);
            this.button7.TabIndex = 47;
            this.button7.Text = "7";
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(17, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 137);
            this.button4.TabIndex = 46;
            this.button4.Text = "4";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 137);
            this.button1.TabIndex = 38;
            this.button1.Text = "1";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Desktop;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(166, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 137);
            this.button2.TabIndex = 28;
            this.button2.Text = "2";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Location = new System.Drawing.Point(20, 404);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(108, 105);
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox8.Location = new System.Drawing.Point(206, 395);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(117, 114);
            this.pictureBox8.TabIndex = 43;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox9.Location = new System.Drawing.Point(405, 395);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(117, 114);
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(20, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 105);
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Location = new System.Drawing.Point(405, 212);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(117, 114);
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 114);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(211, 212);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 105);
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(405, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 114);
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(211, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 105);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(3, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(552, 533);
            this.pictureBox10.TabIndex = 45;
            this.pictureBox10.TabStop = false;
            // 
            // score_reset
            // 
            this.score_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.score_reset.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.score_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.score_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.score_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score_reset.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_reset.ForeColor = System.Drawing.Color.Khaki;
            this.score_reset.Location = new System.Drawing.Point(625, 71);
            this.score_reset.Name = "score_reset";
            this.score_reset.Size = new System.Drawing.Size(143, 34);
            this.score_reset.TabIndex = 38;
            this.score_reset.Text = "Reset";
            this.score_reset.UseVisualStyleBackColor = true;
            this.score_reset.Click += new System.EventHandler(this.score_reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(730, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 60);
            this.label3.TabIndex = 40;
            this.label3.Text = "RED\r\n(O)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(600, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 60);
            this.label4.TabIndex = 41;
            this.label4.Text = "BLUE \r\n(X)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_blue
            // 
            this.score_blue.AutoSize = true;
            this.score_blue.BackColor = System.Drawing.Color.Transparent;
            this.score_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_blue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.score_blue.Location = new System.Drawing.Point(620, 69);
            this.score_blue.Name = "score_blue";
            this.score_blue.Size = new System.Drawing.Size(24, 25);
            this.score_blue.TabIndex = 42;
            this.score_blue.Text = "0";
            // 
            // score_red
            // 
            this.score_red.AutoSize = true;
            this.score_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_red.ForeColor = System.Drawing.Color.Firebrick;
            this.score_red.Location = new System.Drawing.Point(744, 69);
            this.score_red.Name = "score_red";
            this.score_red.Size = new System.Drawing.Size(24, 25);
            this.score_red.TabIndex = 43;
            this.score_red.Text = "0";
            // 
            // panel_newgame
            // 
            this.panel_newgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_newgame.Enabled = false;
            this.panel_newgame.Location = new System.Drawing.Point(20, 16);
            this.panel_newgame.Name = "panel_newgame";
            this.panel_newgame.Size = new System.Drawing.Size(584, 564);
            this.panel_newgame.TabIndex = 44;
            this.panel_newgame.Click += new System.EventHandler(this.Panel_clicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(675, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "TIE";
            // 
            // score_tie
            // 
            this.score_tie.AutoSize = true;
            this.score_tie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_tie.ForeColor = System.Drawing.SystemColors.Info;
            this.score_tie.Location = new System.Drawing.Point(683, 41);
            this.score_tie.Name = "score_tie";
            this.score_tie.Size = new System.Drawing.Size(24, 25);
            this.score_tie.TabIndex = 47;
            this.score_tie.Text = "0";
            // 
            // new_game
            // 
            this.new_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_game.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.new_game.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.new_game.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkKhaki;
            this.new_game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_game.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_game.ForeColor = System.Drawing.Color.Khaki;
            this.new_game.Location = new System.Drawing.Point(635, 104);
            this.new_game.Name = "new_game";
            this.new_game.Size = new System.Drawing.Size(122, 34);
            this.new_game.TabIndex = 48;
            this.new_game.Text = "New Game";
            this.new_game.UseVisualStyleBackColor = true;
            this.new_game.Click += new System.EventHandler(this.Panel_clicked);
            // 
            // label_whowill
            // 
            this.label_whowill.AutoSize = true;
            this.label_whowill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_whowill.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_whowill.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_whowill.Location = new System.Drawing.Point(646, 219);
            this.label_whowill.Name = "label_whowill";
            this.label_whowill.Size = new System.Drawing.Size(84, 19);
            this.label_whowill.TabIndex = 50;
            this.label_whowill.Text = "WHO WILL";
            this.label_whowill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_qmark
            // 
            this.label_qmark.AutoEllipsis = true;
            this.label_qmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_qmark.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_qmark.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_qmark.Location = new System.Drawing.Point(610, 224);
            this.label_qmark.Name = "label_qmark";
            this.label_qmark.Size = new System.Drawing.Size(158, 103);
            this.label_qmark.TabIndex = 52;
            this.label_qmark.Text = "?";
            this.label_qmark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_win
            // 
            this.label_win.AutoSize = true;
            this.label_win.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_win.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_win.ForeColor = System.Drawing.Color.SpringGreen;
            this.label_win.Location = new System.Drawing.Point(662, 322);
            this.label_win.Name = "label_win";
            this.label_win.Size = new System.Drawing.Size(41, 19);
            this.label_win.TabIndex = 53;
            this.label_win.Text = "WIN";
            this.label_win.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 571);
            this.Controls.Add(this.label_whowill);
            this.Controls.Add(this.label_win);
            this.Controls.Add(this.label_qmark);
            this.Controls.Add(this.score_tie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.score_red);
            this.Controls.Add(this.score_blue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.label_checkwin);
            this.Controls.Add(this.panel_newgame);
            this.Controls.Add(this.score_reset);
            this.Controls.Add(this.new_game);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_checkwin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button score_reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label score_blue;
        private System.Windows.Forms.Label score_red;
        private System.Windows.Forms.Panel panel_newgame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label score_tie;
        private System.Windows.Forms.Button new_game;
        private System.Windows.Forms.Label label_whowill;
        private System.Windows.Forms.Label label_qmark;
        private System.Windows.Forms.Label label_win;
    }
}

