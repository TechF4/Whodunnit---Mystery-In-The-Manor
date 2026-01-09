namespace Final_Project_Whodunnit
{
    partial class TitleForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.firstImage = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.storyLabel = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstImage)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startButton.Location = new System.Drawing.Point(358, 468);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(325, 59);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstImage
            // 
            this.firstImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstImage.BackgroundImage = global::Final_Project_Whodunnit.Properties.Resources.finalProject1;
            this.firstImage.Image = global::Final_Project_Whodunnit.Properties.Resources.finalProject;
            this.firstImage.Location = new System.Drawing.Point(-20, -8);
            this.firstImage.Name = "firstImage";
            this.firstImage.Size = new System.Drawing.Size(1010, 876);
            this.firstImage.TabIndex = 0;
            this.firstImage.TabStop = false;
            this.firstImage.Click += new System.EventHandler(this.firstImage_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Font = new System.Drawing.Font("Chiller", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(115, 272);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(719, 92);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "The Mystery At The Manor";
            // 
            // storyLabel
            // 
            this.storyLabel.BackColor = System.Drawing.Color.Black;
            this.storyLabel.Font = new System.Drawing.Font("Chiller", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storyLabel.Location = new System.Drawing.Point(12, 18);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(910, 762);
            this.storyLabel.TabIndex = 4;
            this.storyLabel.Text = "The Mystery At The Ravenwood Manor\r\n\r\n";
            this.storyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.storyLabel.Visible = false;
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.Black;
            this.beginButton.Font = new System.Drawing.Font("Chiller", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.beginButton.Location = new System.Drawing.Point(358, 774);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(222, 56);
            this.beginButton.TabIndex = 5;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Visible = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // TitleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(934, 842);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.firstImage);
            this.Name = "TitleForm";
            this.Text = "TitleForm";
            ((System.ComponentModel.ISupportInitialize)(this.firstImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox firstImage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Button beginButton;
    }
}