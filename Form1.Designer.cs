namespace Final_Project_Whodunnit
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
            this.roomsButton = new System.Windows.Forms.Button();
            this.evidenceButton = new System.Windows.Forms.Button();
            this.suspectsButton = new System.Windows.Forms.Button();
            this.storyButton = new System.Windows.Forms.Button();
            this.studyRoom = new System.Windows.Forms.PictureBox();
            this.victimButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studyRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsButton
            // 
            this.roomsButton.BackColor = System.Drawing.Color.Black;
            this.roomsButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.roomsButton.Location = new System.Drawing.Point(12, 202);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(127, 37);
            this.roomsButton.TabIndex = 3;
            this.roomsButton.Text = "Rooms";
            this.roomsButton.UseVisualStyleBackColor = false;
            // 
            // evidenceButton
            // 
            this.evidenceButton.BackColor = System.Drawing.Color.Black;
            this.evidenceButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evidenceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.evidenceButton.Location = new System.Drawing.Point(12, 159);
            this.evidenceButton.Name = "evidenceButton";
            this.evidenceButton.Size = new System.Drawing.Size(127, 37);
            this.evidenceButton.TabIndex = 4;
            this.evidenceButton.Text = "Evidence";
            this.evidenceButton.UseVisualStyleBackColor = false;
            this.evidenceButton.Click += new System.EventHandler(this.evidenceButton_Click);
            // 
            // suspectsButton
            // 
            this.suspectsButton.BackColor = System.Drawing.Color.Black;
            this.suspectsButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suspectsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suspectsButton.Location = new System.Drawing.Point(12, 116);
            this.suspectsButton.Name = "suspectsButton";
            this.suspectsButton.Size = new System.Drawing.Size(127, 37);
            this.suspectsButton.TabIndex = 5;
            this.suspectsButton.Text = "Suspects";
            this.suspectsButton.UseVisualStyleBackColor = false;
            this.suspectsButton.Click += new System.EventHandler(this.suspectsButton_Click);
            // 
            // storyButton
            // 
            this.storyButton.BackColor = System.Drawing.Color.Black;
            this.storyButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.storyButton.Location = new System.Drawing.Point(12, 30);
            this.storyButton.Name = "storyButton";
            this.storyButton.Size = new System.Drawing.Size(127, 37);
            this.storyButton.TabIndex = 6;
            this.storyButton.Text = "Story";
            this.storyButton.UseVisualStyleBackColor = false;
            this.storyButton.Click += new System.EventHandler(this.storyButton_Click);
            // 
            // studyRoom
            // 
            this.studyRoom.BackgroundImage = global::Final_Project_Whodunnit.Properties.Resources._5146;
            this.studyRoom.Location = new System.Drawing.Point(-3, 0);
            this.studyRoom.Name = "studyRoom";
            this.studyRoom.Size = new System.Drawing.Size(978, 865);
            this.studyRoom.TabIndex = 0;
            this.studyRoom.TabStop = false;
            // 
            // victimButton
            // 
            this.victimButton.BackColor = System.Drawing.Color.Black;
            this.victimButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victimButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.victimButton.Location = new System.Drawing.Point(12, 73);
            this.victimButton.Name = "victimButton";
            this.victimButton.Size = new System.Drawing.Size(127, 37);
            this.victimButton.TabIndex = 7;
            this.victimButton.Text = "Victim";
            this.victimButton.UseVisualStyleBackColor = false;
            this.victimButton.Click += new System.EventHandler(this.victimButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 788);
            this.Controls.Add(this.victimButton);
            this.Controls.Add(this.storyButton);
            this.Controls.Add(this.suspectsButton);
            this.Controls.Add(this.evidenceButton);
            this.Controls.Add(this.roomsButton);
            this.Controls.Add(this.studyRoom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studyRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox studyRoom;
        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Button evidenceButton;
        private System.Windows.Forms.Button suspectsButton;
        private System.Windows.Forms.Button storyButton;
        private System.Windows.Forms.Button victimButton;
    }
}

