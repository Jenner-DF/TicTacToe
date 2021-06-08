namespace Calculator_Test_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.backspace = new System.Windows.Forms.Button();
            this.clearAll = new System.Windows.Forms.Button();
            this.clearEntry = new System.Windows.Forms.Button();
            this._percent = new System.Windows.Forms.Button();
            this._divide = new System.Windows.Forms.Button();
            this._sqrroot = new System.Windows.Forms.Button();
            this._sqr = new System.Windows.Forms.Button();
            this._reciprocal = new System.Windows.Forms.Button();
            this._multiply = new System.Windows.Forms.Button();
            this.num_9 = new System.Windows.Forms.Button();
            this.num_8 = new System.Windows.Forms.Button();
            this.num_7 = new System.Windows.Forms.Button();
            this._subtract = new System.Windows.Forms.Button();
            this.num_6 = new System.Windows.Forms.Button();
            this.num_5 = new System.Windows.Forms.Button();
            this.num_4 = new System.Windows.Forms.Button();
            this._add = new System.Windows.Forms.Button();
            this.num_3 = new System.Windows.Forms.Button();
            this.num_2 = new System.Windows.Forms.Button();
            this.num_1 = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this._decimal = new System.Windows.Forms.Button();
            this.num_0 = new System.Windows.Forms.Button();
            this._Sign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.test_label = new System.Windows.Forms.Label();
            this.test_label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.but_group1 = new System.Windows.Forms.Panel();
            this.but_group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 55);
            this.label1.TabIndex = 52;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // backspace
            // 
            this.backspace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backspace.AutoSize = true;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.Image = ((System.Drawing.Image)(resources.GetObject("backspace.Image")));
            this.backspace.Location = new System.Drawing.Point(226, 6);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(78, 58);
            this.backspace.TabIndex = 51;
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this._backspace_Click);
            // 
            // clearAll
            // 
            this.clearAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearAll.AutoSize = true;
            this.clearAll.FlatAppearance.BorderSize = 0;
            this.clearAll.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAll.Location = new System.Drawing.Point(150, 6);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(78, 58);
            this.clearAll.TabIndex = 50;
            this.clearAll.Text = "C";
            this.clearAll.UseVisualStyleBackColor = true;
            this.clearAll.Click += new System.EventHandler(this._clearAll_Click);
            // 
            // clearEntry
            // 
            this.clearEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearEntry.FlatAppearance.BorderSize = 0;
            this.clearEntry.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntry.Location = new System.Drawing.Point(75, 6);
            this.clearEntry.Name = "clearEntry";
            this.clearEntry.Size = new System.Drawing.Size(78, 58);
            this.clearEntry.TabIndex = 49;
            this.clearEntry.Text = "CE";
            this.clearEntry.UseVisualStyleBackColor = true;
            this.clearEntry.Click += new System.EventHandler(this._clearEntry_Click);
            // 
            // _percent
            // 
            this._percent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._percent.FlatAppearance.BorderSize = 0;
            this._percent.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._percent.Location = new System.Drawing.Point(-1, 6);
            this._percent.Name = "_percent";
            this._percent.Size = new System.Drawing.Size(78, 58);
            this._percent.TabIndex = 48;
            this._percent.Text = "%";
            this._percent.UseVisualStyleBackColor = true;
            this._percent.Click += new System.EventHandler(this._percent_Click);
            // 
            // _divide
            // 
            this._divide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._divide.FlatAppearance.BorderSize = 0;
            this._divide.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._divide.Location = new System.Drawing.Point(226, 59);
            this._divide.Name = "_divide";
            this._divide.Size = new System.Drawing.Size(78, 58);
            this._divide.TabIndex = 47;
            this._divide.Text = "÷";
            this._divide.UseVisualStyleBackColor = true;
            this._divide.Click += new System.EventHandler(this.Operator);
            // 
            // _sqrroot
            // 
            this._sqrroot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._sqrroot.FlatAppearance.BorderSize = 0;
            this._sqrroot.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sqrroot.Image = ((System.Drawing.Image)(resources.GetObject("_sqrroot.Image")));
            this._sqrroot.Location = new System.Drawing.Point(150, 59);
            this._sqrroot.Name = "_sqrroot";
            this._sqrroot.Size = new System.Drawing.Size(78, 58);
            this._sqrroot.TabIndex = 46;
            this._sqrroot.UseVisualStyleBackColor = true;
            this._sqrroot.Click += new System.EventHandler(this._sqrroot_Click);
            // 
            // _sqr
            // 
            this._sqr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._sqr.FlatAppearance.BorderSize = 0;
            this._sqr.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sqr.Image = ((System.Drawing.Image)(resources.GetObject("_sqr.Image")));
            this._sqr.Location = new System.Drawing.Point(75, 59);
            this._sqr.Name = "_sqr";
            this._sqr.Size = new System.Drawing.Size(78, 58);
            this._sqr.TabIndex = 45;
            this._sqr.UseVisualStyleBackColor = true;
            this._sqr.Click += new System.EventHandler(this._sqr_Click);
            // 
            // _reciprocal
            // 
            this._reciprocal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._reciprocal.FlatAppearance.BorderSize = 0;
            this._reciprocal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._reciprocal.Image = ((System.Drawing.Image)(resources.GetObject("_reciprocal.Image")));
            this._reciprocal.Location = new System.Drawing.Point(-1, 59);
            this._reciprocal.Name = "_reciprocal";
            this._reciprocal.Size = new System.Drawing.Size(78, 58);
            this._reciprocal.TabIndex = 44;
            this._reciprocal.UseVisualStyleBackColor = true;
            this._reciprocal.Click += new System.EventHandler(this._reciprocal_Click);
            // 
            // _multiply
            // 
            this._multiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._multiply.FlatAppearance.BorderSize = 0;
            this._multiply.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._multiply.Location = new System.Drawing.Point(226, 113);
            this._multiply.Name = "_multiply";
            this._multiply.Size = new System.Drawing.Size(78, 58);
            this._multiply.TabIndex = 43;
            this._multiply.Text = "x";
            this._multiply.UseVisualStyleBackColor = true;
            this._multiply.Click += new System.EventHandler(this.Operator);
            // 
            // num_9
            // 
            this.num_9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_9.FlatAppearance.BorderSize = 0;
            this.num_9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_9.Location = new System.Drawing.Point(150, 113);
            this.num_9.Name = "num_9";
            this.num_9.Size = new System.Drawing.Size(78, 58);
            this.num_9.TabIndex = 42;
            this.num_9.Text = "9";
            this.num_9.UseVisualStyleBackColor = false;
            this.num_9.Click += new System.EventHandler(this.num_click);
            // 
            // num_8
            // 
            this.num_8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_8.FlatAppearance.BorderSize = 0;
            this.num_8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_8.Location = new System.Drawing.Point(75, 113);
            this.num_8.Name = "num_8";
            this.num_8.Size = new System.Drawing.Size(78, 58);
            this.num_8.TabIndex = 41;
            this.num_8.Text = "8";
            this.num_8.UseVisualStyleBackColor = false;
            this.num_8.Click += new System.EventHandler(this.num_click);
            // 
            // num_7
            // 
            this.num_7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_7.FlatAppearance.BorderSize = 0;
            this.num_7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_7.Location = new System.Drawing.Point(-1, 113);
            this.num_7.Name = "num_7";
            this.num_7.Size = new System.Drawing.Size(78, 58);
            this.num_7.TabIndex = 40;
            this.num_7.Text = "7";
            this.num_7.UseVisualStyleBackColor = false;
            this.num_7.Click += new System.EventHandler(this.num_click);
            // 
            // _subtract
            // 
            this._subtract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._subtract.FlatAppearance.BorderSize = 0;
            this._subtract.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._subtract.Location = new System.Drawing.Point(226, 166);
            this._subtract.Name = "_subtract";
            this._subtract.Size = new System.Drawing.Size(78, 58);
            this._subtract.TabIndex = 39;
            this._subtract.Text = "-";
            this._subtract.UseVisualStyleBackColor = true;
            this._subtract.Click += new System.EventHandler(this.Operator);
            // 
            // num_6
            // 
            this.num_6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_6.FlatAppearance.BorderSize = 0;
            this.num_6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_6.Location = new System.Drawing.Point(150, 166);
            this.num_6.Name = "num_6";
            this.num_6.Size = new System.Drawing.Size(78, 58);
            this.num_6.TabIndex = 38;
            this.num_6.Text = "6";
            this.num_6.UseVisualStyleBackColor = false;
            this.num_6.Click += new System.EventHandler(this.num_click);
            // 
            // num_5
            // 
            this.num_5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_5.FlatAppearance.BorderSize = 0;
            this.num_5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_5.Location = new System.Drawing.Point(74, 166);
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(78, 58);
            this.num_5.TabIndex = 37;
            this.num_5.Text = "5";
            this.num_5.UseVisualStyleBackColor = false;
            this.num_5.Click += new System.EventHandler(this.num_click);
            // 
            // num_4
            // 
            this.num_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_4.FlatAppearance.BorderSize = 0;
            this.num_4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_4.Location = new System.Drawing.Point(-1, 166);
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(78, 58);
            this.num_4.TabIndex = 36;
            this.num_4.Text = "4";
            this.num_4.UseVisualStyleBackColor = false;
            this.num_4.Click += new System.EventHandler(this.num_click);
            // 
            // _add
            // 
            this._add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._add.FlatAppearance.BorderSize = 0;
            this._add.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._add.Location = new System.Drawing.Point(226, 222);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(78, 58);
            this._add.TabIndex = 35;
            this._add.Text = "+";
            this._add.UseVisualStyleBackColor = true;
            this._add.Click += new System.EventHandler(this.Operator);
            // 
            // num_3
            // 
            this.num_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_3.FlatAppearance.BorderSize = 0;
            this.num_3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_3.Location = new System.Drawing.Point(150, 222);
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(78, 58);
            this.num_3.TabIndex = 34;
            this.num_3.Text = "3";
            this.num_3.UseVisualStyleBackColor = false;
            this.num_3.Click += new System.EventHandler(this.num_click);
            // 
            // num_2
            // 
            this.num_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_2.FlatAppearance.BorderSize = 0;
            this.num_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_2.Location = new System.Drawing.Point(74, 222);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(78, 58);
            this.num_2.TabIndex = 33;
            this.num_2.Text = "2";
            this.num_2.UseVisualStyleBackColor = false;
            this.num_2.Click += new System.EventHandler(this.num_click);
            // 
            // num_1
            // 
            this.num_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_1.FlatAppearance.BorderSize = 0;
            this.num_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_1.Location = new System.Drawing.Point(-1, 222);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(78, 58);
            this.num_1.TabIndex = 32;
            this.num_1.Text = "1";
            this.num_1.UseVisualStyleBackColor = false;
            this.num_1.Click += new System.EventHandler(this.num_click);
            // 
            // equals
            // 
            this.equals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.equals.AutoSize = true;
            this.equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(163)))), ((int)(((byte)(202)))));
            this.equals.FlatAppearance.BorderSize = 0;
            this.equals.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.Location = new System.Drawing.Point(226, 275);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(78, 58);
            this.equals.TabIndex = 31;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this._equals_Click);
            // 
            // _decimal
            // 
            this._decimal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._decimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this._decimal.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this._decimal.FlatAppearance.BorderSize = 0;
            this._decimal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._decimal.Location = new System.Drawing.Point(151, 275);
            this._decimal.Name = "_decimal";
            this._decimal.Size = new System.Drawing.Size(78, 58);
            this._decimal.TabIndex = 30;
            this._decimal.Text = ".";
            this._decimal.UseVisualStyleBackColor = false;
            this._decimal.Click += new System.EventHandler(this._decimal_Click);
            // 
            // num_0
            // 
            this.num_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.num_0.FlatAppearance.BorderSize = 0;
            this.num_0.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_0.Location = new System.Drawing.Point(74, 275);
            this.num_0.Name = "num_0";
            this.num_0.Size = new System.Drawing.Size(78, 58);
            this.num_0.TabIndex = 29;
            this.num_0.Text = "0";
            this.num_0.UseVisualStyleBackColor = false;
            this.num_0.Click += new System.EventHandler(this.num_click);
            // 
            // _Sign
            // 
            this._Sign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._Sign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this._Sign.FlatAppearance.BorderSize = 0;
            this._Sign.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Sign.Location = new System.Drawing.Point(-1, 275);
            this._Sign.Name = "_Sign";
            this._Sign.Size = new System.Drawing.Size(78, 58);
            this._Sign.TabIndex = 28;
            this._Sign.Text = "+/-";
            this._Sign.UseVisualStyleBackColor = false;
            this._Sign.Click += new System.EventHandler(this._Sign_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(-1, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 37);
            this.label2.TabIndex = 53;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // test_label
            // 
            this.test_label.AutoSize = true;
            this.test_label.Location = new System.Drawing.Point(27, 27);
            this.test_label.Name = "test_label";
            this.test_label.Size = new System.Drawing.Size(36, 13);
            this.test_label.TabIndex = 54;
            this.test_label.Text = "test_1";
            // 
            // test_label2
            // 
            this.test_label2.AutoSize = true;
            this.test_label2.Location = new System.Drawing.Point(104, 27);
            this.test_label2.Name = "test_label2";
            this.test_label2.Size = new System.Drawing.Size(36, 13);
            this.test_label2.TabIndex = 55;
            this.test_label2.Text = "test_2";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 26);
            this.label4.TabIndex = 56;
            this.label4.Text = "Standard";
            // 
            // but_group1
            // 
            this.but_group1.Controls.Add(this.backspace);
            this.but_group1.Controls.Add(this.clearAll);
            this.but_group1.Controls.Add(this.clearEntry);
            this.but_group1.Controls.Add(this._percent);
            this.but_group1.Controls.Add(this._divide);
            this.but_group1.Controls.Add(this._sqrroot);
            this.but_group1.Controls.Add(this._sqr);
            this.but_group1.Controls.Add(this._reciprocal);
            this.but_group1.Controls.Add(this._multiply);
            this.but_group1.Controls.Add(this.num_9);
            this.but_group1.Controls.Add(this.num_8);
            this.but_group1.Controls.Add(this.num_7);
            this.but_group1.Controls.Add(this._subtract);
            this.but_group1.Controls.Add(this.num_6);
            this.but_group1.Controls.Add(this.num_5);
            this.but_group1.Controls.Add(this.num_4);
            this.but_group1.Controls.Add(this._add);
            this.but_group1.Controls.Add(this.num_3);
            this.but_group1.Controls.Add(this.num_2);
            this.but_group1.Controls.Add(this.num_1);
            this.but_group1.Controls.Add(this.equals);
            this.but_group1.Controls.Add(this._decimal);
            this.but_group1.Controls.Add(this.num_0);
            this.but_group1.Controls.Add(this._Sign);
            this.but_group1.Location = new System.Drawing.Point(3, 147);
            this.but_group1.Name = "but_group1";
            this.but_group1.Size = new System.Drawing.Size(316, 350);
            this.but_group1.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(304, 477);
            this.Controls.Add(this.but_group1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.test_label2);
            this.Controls.Add(this.test_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Calc_v190521";
            this.Load += new System.EventHandler(this.test_2_Load);
            this.but_group1.ResumeLayout(false);
            this.but_group1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clearAll;
        private System.Windows.Forms.Button clearEntry;
        private System.Windows.Forms.Button _percent;
        private System.Windows.Forms.Button _divide;
        private System.Windows.Forms.Button _sqrroot;
        private System.Windows.Forms.Button _sqr;
        private System.Windows.Forms.Button _reciprocal;
        private System.Windows.Forms.Button _multiply;
        private System.Windows.Forms.Button num_9;
        private System.Windows.Forms.Button num_8;
        private System.Windows.Forms.Button num_7;
        private System.Windows.Forms.Button _subtract;
        private System.Windows.Forms.Button num_6;
        private System.Windows.Forms.Button num_5;
        private System.Windows.Forms.Button num_4;
        private System.Windows.Forms.Button _add;
        private System.Windows.Forms.Button num_3;
        private System.Windows.Forms.Button num_2;
        private System.Windows.Forms.Button num_1;
        private System.Windows.Forms.Button equals;
        private System.Windows.Forms.Button _decimal;
        private System.Windows.Forms.Button num_0;
        private System.Windows.Forms.Button _Sign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label test_label;
        private System.Windows.Forms.Label test_label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel but_group1;
    }
}

