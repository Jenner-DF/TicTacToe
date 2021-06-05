namespace ContactTracing
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
            this.text_data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_data
            // 
            this.text_data.Location = new System.Drawing.Point(12, 12);
            this.text_data.Multiline = true;
            this.text_data.Name = "text_data";
            this.text_data.ReadOnly = true;
            this.text_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_data.Size = new System.Drawing.Size(184, 372);
            this.text_data.TabIndex = 72;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.text_data);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_data;
    }
}