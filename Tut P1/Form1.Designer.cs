namespace Tut_P1
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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 20;
            this.listBoxData.Location = new System.Drawing.Point(12, 12);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(458, 304);
            this.listBoxData.TabIndex = 1;
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Location = new System.Drawing.Point(265, 336);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculator.TabIndex = 2;
            this.buttonCalculator.Text = "Calculator";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.Location = new System.Drawing.Point(109, 336);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonStudent.TabIndex = 3;
            this.buttonStudent.Text = "Student";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 382);
            this.Controls.Add(this.buttonStudent);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.listBoxData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonStudent;
    }
}

