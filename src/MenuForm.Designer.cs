namespace GridLife
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            nameLabel = new Label();
            playButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AccessibleName = "nameLabel";
            nameLabel.Anchor = AnchorStyles.None;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.Crimson;
            nameLabel.Location = new Point(891, 49);
            nameLabel.Margin = new Padding(3, 40, 3, 80);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(250, 65);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Grid Life";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            playButton.AccessibleName = "playButton";
            playButton.AutoSize = true;
            playButton.BackColor = Color.Black;
            playButton.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            playButton.ForeColor = Color.Crimson;
            playButton.Location = new Point(891, 195);
            playButton.Margin = new Padding(1, 1, 1, 50);
            playButton.Name = "playButton";
            playButton.Size = new Size(250, 75);
            playButton.TabIndex = 2;
            playButton.TabStop = false;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = false;
            playButton.Click += PlayButton_Click;
            // 
            // exitButton
            // 
            exitButton.AccessibleName = "exitButton";
            exitButton.AutoSize = true;
            exitButton.BackColor = Color.Black;
            exitButton.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.ForeColor = Color.Crimson;
            exitButton.Location = new Point(891, 321);
            exitButton.Margin = new Padding(1);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(250, 75);
            exitButton.TabIndex = 1;
            exitButton.TabStop = false;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += Button1_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1920, 1080);
            Controls.Add(exitButton);
            Controls.Add(playButton);
            Controls.Add(nameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Text = "Grid Life";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Button playButton;
        private Button exitButton;
    }
}