namespace Final_Project_Whodunnit
{
    partial class storyForm
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
            this.storyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Story So Far...";
            // 
            // storyLabel
            // 
            this.storyLabel.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storyLabel.Location = new System.Drawing.Point(39, 111);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(510, 532);
            this.storyLabel.TabIndex = 2;
            this.storyLabel.Click += new System.EventHandler(this.storyLabel_Click);
            // 
            // storyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(590, 675);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.label1);
            this.Name = "storyForm";
            this.Text = "storyForm";
            this.Load += new System.EventHandler(this.storyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label storyLabel;
    }
}