namespace ChartTest.SubForms
{
    partial class SubForm_MinMax
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
            this.txtBox_Min = new System.Windows.Forms.TextBox();
            this.txtBox_Max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Min";
            // 
            // txtBox_Min
            // 
            this.txtBox_Min.Location = new System.Drawing.Point(46, 9);
            this.txtBox_Min.Name = "txtBox_Min";
            this.txtBox_Min.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Min.TabIndex = 1;
            // 
            // txtBox_Max
            // 
            this.txtBox_Max.Location = new System.Drawing.Point(197, 8);
            this.txtBox_Max.Name = "txtBox_Max";
            this.txtBox_Max.Size = new System.Drawing.Size(100, 21);
            this.txtBox_Max.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(312, 8);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "제출";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // SubForm_MinMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 38);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtBox_Max);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_Min);
            this.Controls.Add(this.label1);
            this.Name = "SubForm_MinMax";
            this.Text = "SubForm_MinMax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Min;
        private System.Windows.Forms.TextBox txtBox_Max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Submit;
    }
}