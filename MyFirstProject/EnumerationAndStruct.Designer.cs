namespace MyFirstProject
{
    partial class EnumerationAndStruct
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLoadColor = new System.Windows.Forms.Button();
            this.listBoxByEnumData = new System.Windows.Forms.ListBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(68, 67);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Loading List using enum.";
            // 
            // btnLoadColor
            // 
            this.btnLoadColor.Location = new System.Drawing.Point(116, 212);
            this.btnLoadColor.Name = "btnLoadColor";
            this.btnLoadColor.Size = new System.Drawing.Size(75, 23);
            this.btnLoadColor.TabIndex = 2;
            this.btnLoadColor.Text = "Load Color";
            this.btnLoadColor.UseVisualStyleBackColor = true;
            this.btnLoadColor.Click += new System.EventHandler(this.btnLoadColor_Click);
            // 
            // listBoxByEnumData
            // 
            this.listBoxByEnumData.FormattingEnabled = true;
            this.listBoxByEnumData.Location = new System.Drawing.Point(71, 86);
            this.listBoxByEnumData.Name = "listBoxByEnumData";
            this.listBoxByEnumData.Size = new System.Drawing.Size(120, 95);
            this.listBoxByEnumData.TabIndex = 0;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(245, 222);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            this.lblColor.UseWaitCursor = true;
            // 
            // EnumerationAndStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 399);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.btnLoadColor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBoxByEnumData);
            this.Name = "EnumerationAndStruct";
            this.Text = "EnumerationAndStruct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoadColor;
        private System.Windows.Forms.ListBox listBoxByEnumData;
        private System.Windows.Forms.Label lblColor;
    }
}