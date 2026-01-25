namespace Final_Project_Whodunnit
{
    partial class evidenceForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.wineGlassLabel = new System.Windows.Forms.Label();
            this.openWindowLabel = new System.Windows.Forms.Label();
            this.medicalCabinetLabel = new System.Windows.Forms.Label();
            this.journalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(320, 444);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(184, 36);
            this.closeButton.TabIndex = 29;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // wineGlassLabel
            // 
            this.wineGlassLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wineGlassLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wineGlassLabel.Location = new System.Drawing.Point(64, 45);
            this.wineGlassLabel.Name = "wineGlassLabel";
            this.wineGlassLabel.Size = new System.Drawing.Size(247, 92);
            this.wineGlassLabel.TabIndex = 30;
            // 
            // openWindowLabel
            // 
            this.openWindowLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openWindowLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openWindowLabel.Location = new System.Drawing.Point(431, 45);
            this.openWindowLabel.Name = "openWindowLabel";
            this.openWindowLabel.Size = new System.Drawing.Size(247, 92);
            this.openWindowLabel.TabIndex = 31;
            // 
            // medicalCabinetLabel
            // 
            this.medicalCabinetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medicalCabinetLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalCabinetLabel.Location = new System.Drawing.Point(64, 223);
            this.medicalCabinetLabel.Name = "medicalCabinetLabel";
            this.medicalCabinetLabel.Size = new System.Drawing.Size(247, 92);
            this.medicalCabinetLabel.TabIndex = 32;
            // 
            // journalLabel
            // 
            this.journalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.journalLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journalLabel.Location = new System.Drawing.Point(431, 223);
            this.journalLabel.Name = "journalLabel";
            this.journalLabel.Size = new System.Drawing.Size(247, 92);
            this.journalLabel.TabIndex = 33;
            // 
            // evidenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(845, 509);
            this.Controls.Add(this.journalLabel);
            this.Controls.Add(this.medicalCabinetLabel);
            this.Controls.Add(this.openWindowLabel);
            this.Controls.Add(this.wineGlassLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "evidenceForm";
            this.Text = "evidenceForm";
            this.Activated += new System.EventHandler(this.evidenceForm_Activated_1);
            this.Load += new System.EventHandler(this.evidenceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label wineGlassLabel;
        private System.Windows.Forms.Label openWindowLabel;
        private System.Windows.Forms.Label medicalCabinetLabel;
        private System.Windows.Forms.Label journalLabel;
    }
}