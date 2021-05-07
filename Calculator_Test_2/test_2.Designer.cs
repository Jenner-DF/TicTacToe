namespace Calculator_Test_2
{
    partial class test_label2
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
            this.label1 = new System.Windows.Forms.Label();
            this._backspace = new System.Windows.Forms.Button();
            this._clearAll = new System.Windows.Forms.Button();
            this._clearEntry = new System.Windows.Forms.Button();
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
            this._equals = new System.Windows.Forms.Button();
            this._decimal = new System.Windows.Forms.Button();
            this.num_0 = new System.Windows.Forms.Button();
            this._Sign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.test_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 55);
            this.label1.TabIndex = 52;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _backspace
            // 
            this._backspace.Location = new System.Drawing.Point(226, 180);
            this._backspace.Name = "_backspace";
            this._backspace.Size = new System.Drawing.Size(78, 58);
            this._backspace.TabIndex = 51;
            this._backspace.Text = "<-";
            this._backspace.UseVisualStyleBackColor = true;
            this._backspace.Click += new System.EventHandler(this._backspace_Click);
            // 
            // _clearAll
            // 
            this._clearAll.Location = new System.Drawing.Point(150, 180);
            this._clearAll.Name = "_clearAll";
            this._clearAll.Size = new System.Drawing.Size(78, 58);
            this._clearAll.TabIndex = 50;
            this._clearAll.Text = "C";
            this._clearAll.UseVisualStyleBackColor = true;
            this._clearAll.Click += new System.EventHandler(this._clearAll_Click);
            // 
            // _clearEntry
            // 
            this._clearEntry.Location = new System.Drawing.Point(75, 180);
            this._clearEntry.Name = "_clearEntry";
            this._clearEntry.Size = new System.Drawing.Size(78, 58);
            this._clearEntry.TabIndex = 49;
            this._clearEntry.Text = "CE";
            this._clearEntry.UseVisualStyleBackColor = true;
            this._clearEntry.Click += new System.EventHandler(this._clearEntry_Click);
            // 
            // _percent
            // 
            this._percent.Location = new System.Drawing.Point(-1, 180);
            this._percent.Name = "_percent";
            this._percent.Size = new System.Drawing.Size(78, 58);
            this._percent.TabIndex = 48;
            this._percent.Text = "%";
            this._percent.UseVisualStyleBackColor = true;
            // 
            // _divide
            // 
            this._divide.Location = new System.Drawing.Point(226, 233);
            this._divide.Name = "_divide";
            this._divide.Size = new System.Drawing.Size(78, 58);
            this._divide.TabIndex = 47;
            this._divide.Text = "÷";
            this._divide.UseVisualStyleBackColor = true;
            this._divide.Click += new System.EventHandler(this.Operator);
            // 
            // _sqrroot
            // 
            this._sqrroot.Location = new System.Drawing.Point(150, 233);
            this._sqrroot.Name = "_sqrroot";
            this._sqrroot.Size = new System.Drawing.Size(78, 58);
            this._sqrroot.TabIndex = 46;
            this._sqrroot.Text = "*sqrroot(x)";
            this._sqrroot.UseVisualStyleBackColor = true;
            // 
            // _sqr
            // 
            this._sqr.Location = new System.Drawing.Point(75, 233);
            this._sqr.Name = "_sqr";
            this._sqr.Size = new System.Drawing.Size(78, 58);
            this._sqr.TabIndex = 45;
            this._sqr.Text = "*x^2";
            this._sqr.UseVisualStyleBackColor = true;
            // 
            // _reciprocal
            // 
            this._reciprocal.Location = new System.Drawing.Point(-1, 233);
            this._reciprocal.Name = "_reciprocal";
            this._reciprocal.Size = new System.Drawing.Size(78, 58);
            this._reciprocal.TabIndex = 44;
            this._reciprocal.Text = "*1/x";
            this._reciprocal.UseVisualStyleBackColor = true;
            // 
            // _multiply
            // 
            this._multiply.Location = new System.Drawing.Point(226, 287);
            this._multiply.Name = "_multiply";
            this._multiply.Size = new System.Drawing.Size(78, 58);
            this._multiply.TabIndex = 43;
            this._multiply.Text = "x";
            this._multiply.UseVisualStyleBackColor = true;
            this._multiply.Click += new System.EventHandler(this.Operator);
            // 
            // num_9
            // 
            this.num_9.Location = new System.Drawing.Point(150, 287);
            this.num_9.Name = "num_9";
            this.num_9.Size = new System.Drawing.Size(78, 58);
            this.num_9.TabIndex = 42;
            this.num_9.Text = "9";
            this.num_9.UseVisualStyleBackColor = true;
            this.num_9.Click += new System.EventHandler(this.sass);
            // 
            // num_8
            // 
            this.num_8.Location = new System.Drawing.Point(75, 287);
            this.num_8.Name = "num_8";
            this.num_8.Size = new System.Drawing.Size(78, 58);
            this.num_8.TabIndex = 41;
            this.num_8.Text = "8";
            this.num_8.UseVisualStyleBackColor = true;
            this.num_8.Click += new System.EventHandler(this.sass);
            // 
            // num_7
            // 
            this.num_7.Location = new System.Drawing.Point(-1, 287);
            this.num_7.Name = "num_7";
            this.num_7.Size = new System.Drawing.Size(78, 58);
            this.num_7.TabIndex = 40;
            this.num_7.Text = "7";
            this.num_7.UseVisualStyleBackColor = true;
            this.num_7.Click += new System.EventHandler(this.sass);
            // 
            // _subtract
            // 
            this._subtract.Location = new System.Drawing.Point(226, 340);
            this._subtract.Name = "_subtract";
            this._subtract.Size = new System.Drawing.Size(78, 58);
            this._subtract.TabIndex = 39;
            this._subtract.Text = "-";
            this._subtract.UseVisualStyleBackColor = true;
            this._subtract.Click += new System.EventHandler(this.Operator);
            // 
            // num_6
            // 
            this.num_6.Location = new System.Drawing.Point(150, 340);
            this.num_6.Name = "num_6";
            this.num_6.Size = new System.Drawing.Size(78, 58);
            this.num_6.TabIndex = 38;
            this.num_6.Text = "6";
            this.num_6.UseVisualStyleBackColor = true;
            this.num_6.Click += new System.EventHandler(this.sass);
            // 
            // num_5
            // 
            this.num_5.Location = new System.Drawing.Point(75, 340);
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(78, 58);
            this.num_5.TabIndex = 37;
            this.num_5.Text = "5";
            this.num_5.UseVisualStyleBackColor = true;
            this.num_5.Click += new System.EventHandler(this.sass);
            // 
            // num_4
            // 
            this.num_4.Location = new System.Drawing.Point(-1, 340);
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(78, 58);
            this.num_4.TabIndex = 36;
            this.num_4.Text = "4";
            this.num_4.UseVisualStyleBackColor = true;
            this.num_4.Click += new System.EventHandler(this.sass);
            // 
            // _add
            // 
            this._add.Location = new System.Drawing.Point(226, 396);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(78, 58);
            this._add.TabIndex = 35;
            this._add.Text = "+";
            this._add.UseVisualStyleBackColor = true;
            this._add.Click += new System.EventHandler(this.Operator);
            // 
            // num_3
            // 
            this.num_3.Location = new System.Drawing.Point(150, 396);
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(78, 58);
            this.num_3.TabIndex = 34;
            this.num_3.Text = "3";
            this.num_3.UseVisualStyleBackColor = true;
            this.num_3.Click += new System.EventHandler(this.sass);
            // 
            // num_2
            // 
            this.num_2.Location = new System.Drawing.Point(75, 396);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(78, 58);
            this.num_2.TabIndex = 33;
            this.num_2.Text = "2";
            this.num_2.UseVisualStyleBackColor = true;
            this.num_2.Click += new System.EventHandler(this.sass);
            // 
            // num_1
            // 
            this.num_1.Location = new System.Drawing.Point(-1, 396);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(78, 58);
            this.num_1.TabIndex = 32;
            this.num_1.Text = "1";
            this.num_1.UseVisualStyleBackColor = true;
            this.num_1.Click += new System.EventHandler(this.sass);
            // 
            // _equals
            // 
            this._equals.Location = new System.Drawing.Point(226, 449);
            this._equals.Name = "_equals";
            this._equals.Size = new System.Drawing.Size(78, 58);
            this._equals.TabIndex = 31;
            this._equals.Text = "=";
            this._equals.UseVisualStyleBackColor = true;
            // 
            // _decimal
            // 
            this._decimal.Location = new System.Drawing.Point(150, 449);
            this._decimal.Name = "_decimal";
            this._decimal.Size = new System.Drawing.Size(78, 58);
            this._decimal.TabIndex = 30;
            this._decimal.Text = ".";
            this._decimal.UseVisualStyleBackColor = true;
            this._decimal.Click += new System.EventHandler(this._decimal_Click);
            // 
            // num_0
            // 
            this.num_0.Location = new System.Drawing.Point(75, 449);
            this.num_0.Name = "num_0";
            this.num_0.Size = new System.Drawing.Size(78, 58);
            this.num_0.TabIndex = 29;
            this.num_0.Text = "0";
            this.num_0.UseVisualStyleBackColor = true;
            this.num_0.Click += new System.EventHandler(this.sass);
            // 
            // _Sign
            // 
            this._Sign.Location = new System.Drawing.Point(-1, 449);
            this._Sign.Name = "_Sign";
            this._Sign.Size = new System.Drawing.Size(78, 58);
            this._Sign.TabIndex = 28;
            this._Sign.Text = "+/-";
            this._Sign.UseVisualStyleBackColor = true;
            this._Sign.Click += new System.EventHandler(this._Sign_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(-1, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 37);
            this.label2.TabIndex = 53;
            this.label2.Text = "history";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // test_label
            // 
            this.test_label.AutoSize = true;
            this.test_label.Location = new System.Drawing.Point(25, 27);
            this.test_label.Name = "test_label";
            this.test_label.Size = new System.Drawing.Size(36, 13);
            this.test_label.TabIndex = 54;
            this.test_label.Text = "test_1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "test_2";
            // 
            // test_label2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 507);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.test_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._backspace);
            this.Controls.Add(this._clearAll);
            this.Controls.Add(this._clearEntry);
            this.Controls.Add(this._percent);
            this.Controls.Add(this._divide);
            this.Controls.Add(this._sqrroot);
            this.Controls.Add(this._sqr);
            this.Controls.Add(this._reciprocal);
            this.Controls.Add(this._multiply);
            this.Controls.Add(this.num_9);
            this.Controls.Add(this.num_8);
            this.Controls.Add(this.num_7);
            this.Controls.Add(this._subtract);
            this.Controls.Add(this.num_6);
            this.Controls.Add(this.num_5);
            this.Controls.Add(this.num_4);
            this.Controls.Add(this._add);
            this.Controls.Add(this.num_3);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_1);
            this.Controls.Add(this._equals);
            this.Controls.Add(this._decimal);
            this.Controls.Add(this.num_0);
            this.Controls.Add(this._Sign);
            this.Name = "test_label2";
            this.Text = "Calc_v080521";
            this.Load += new System.EventHandler(this.test_2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _backspace;
        private System.Windows.Forms.Button _clearAll;
        private System.Windows.Forms.Button _clearEntry;
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
        private System.Windows.Forms.Button _equals;
        private System.Windows.Forms.Button _decimal;
        private System.Windows.Forms.Button num_0;
        private System.Windows.Forms.Button _Sign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label test_label;
        private System.Windows.Forms.Label label3;
    }
}

