namespace ChartTest.SubForms
{
    partial class SubForm_SeriesType
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
            this.cbx_SeriesType = new System.Windows.Forms.ComboBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Series의 type은?";
            // 
            // cbx_SeriesType
            // 
            this.cbx_SeriesType.FormattingEnabled = true;
            this.cbx_SeriesType.Location = new System.Drawing.Point(118, 10);
            this.cbx_SeriesType.Name = "cbx_SeriesType";
            this.cbx_SeriesType.Size = new System.Drawing.Size(159, 20);
            this.cbx_SeriesType.TabIndex = 1;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(284, 8);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "제출";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // SubForm_SeriesType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 39);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cbx_SeriesType);
            this.Controls.Add(this.label1);
            this.Name = "SubForm_SeriesType";
            this.Text = "SubForm_SeriesType";
            this.Load += new System.EventHandler(this.SubForm_SeriesType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_SeriesType;
        private System.Windows.Forms.Button btn_Submit;
    }
}