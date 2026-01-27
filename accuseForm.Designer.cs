namespace Final_Project_Whodunnit
{
    partial class accuseForm
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
            this.accuseLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.evelynButton = new System.Windows.Forms.Button();
            this.marcusButton = new System.Windows.Forms.Button();
            this.ninaButton = new System.Windows.Forms.Button();
            this.oliverButton = new System.Windows.Forms.Button();
            this.finaleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accuseLabel
            // 
            this.accuseLabel.Font = new System.Drawing.Font("Chiller", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuseLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accuseLabel.Location = new System.Drawing.Point(111, 24);
            this.accuseLabel.Name = "accuseLabel";
            this.accuseLabel.Size = new System.Drawing.Size(713, 167);
            this.accuseLabel.TabIndex = 3;
            this.accuseLabel.Text = "The Time Has Come...\r\nPick The Murderer.";
            this.accuseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(285, 580);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(348, 39);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "The End";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // evelynButton
            // 
            this.evelynButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evelynButton.Location = new System.Drawing.Point(27, 222);
            this.evelynButton.Name = "evelynButton";
            this.evelynButton.Size = new System.Drawing.Size(194, 55);
            this.evelynButton.TabIndex = 31;
            this.evelynButton.Text = "Evelyn Hale";
            this.evelynButton.UseVisualStyleBackColor = true;
            this.evelynButton.Click += new System.EventHandler(this.evelynButton_Click);
            // 
            // marcusButton
            // 
            this.marcusButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcusButton.Location = new System.Drawing.Point(257, 222);
            this.marcusButton.Name = "marcusButton";
            this.marcusButton.Size = new System.Drawing.Size(194, 55);
            this.marcusButton.TabIndex = 32;
            this.marcusButton.Text = "Marcus Hale";
            this.marcusButton.UseVisualStyleBackColor = true;
            this.marcusButton.Click += new System.EventHandler(this.marcusButton_Click);
            // 
            // ninaButton
            // 
            this.ninaButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ninaButton.Location = new System.Drawing.Point(487, 222);
            this.ninaButton.Name = "ninaButton";
            this.ninaButton.Size = new System.Drawing.Size(194, 55);
            this.ninaButton.TabIndex = 33;
            this.ninaButton.Text = "Nina Brooks";
            this.ninaButton.UseVisualStyleBackColor = true;
            this.ninaButton.Click += new System.EventHandler(this.ninaButton_Click);
            // 
            // oliverButton
            // 
            this.oliverButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oliverButton.Location = new System.Drawing.Point(708, 222);
            this.oliverButton.Name = "oliverButton";
            this.oliverButton.Size = new System.Drawing.Size(194, 55);
            this.oliverButton.TabIndex = 34;
            this.oliverButton.Text = "Oliver Grant";
            this.oliverButton.UseVisualStyleBackColor = true;
            this.oliverButton.Click += new System.EventHandler(this.oliverButton_Click);
            // 
            // finaleLabel
            // 
            this.finaleLabel.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finaleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finaleLabel.Location = new System.Drawing.Point(27, 318);
            this.finaleLabel.Name = "finaleLabel";
            this.finaleLabel.Size = new System.Drawing.Size(875, 233);
            this.finaleLabel.TabIndex = 35;
            this.finaleLabel.Visible = false;
            // 
            // accuseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(926, 649);
            this.Controls.Add(this.finaleLabel);
            this.Controls.Add(this.oliverButton);
            this.Controls.Add(this.ninaButton);
            this.Controls.Add(this.marcusButton);
            this.Controls.Add(this.evelynButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.accuseLabel);
            this.Name = "accuseForm";
            this.Text = "accuseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label accuseLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button evelynButton;
        private System.Windows.Forms.Button marcusButton;
        private System.Windows.Forms.Button ninaButton;
        private System.Windows.Forms.Button oliverButton;
        private System.Windows.Forms.Label finaleLabel;
    }
}