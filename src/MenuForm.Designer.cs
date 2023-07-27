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
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
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
            label1 = new Label();
            PlayButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(891, 49);
            label1.Margin = new Padding(3, 40, 3, 80);
            label1.Name = "label1";
            label1.Size = new Size(250, 65);
            label1.TabIndex = 0;
            label1.Text = "Grid Life";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayButton
            // 
            PlayButton.AccessibleName = "ExitButton";
            PlayButton.AutoSize = true;
            PlayButton.BackColor = Color.Black;
            PlayButton.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            PlayButton.ForeColor = Color.Crimson;
            PlayButton.Location = new Point(891, 195);
            PlayButton.Margin = new Padding(1, 1, 1, 50);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(250, 75);
            PlayButton.TabIndex = 2;
            PlayButton.TabStop = false;
            PlayButton.Text = "Play";
            PlayButton.UseVisualStyleBackColor = false;
            PlayButton.Click += PlayButton_Click;
            // 
            // button1
            // 
            button1.AccessibleName = "ExitButton";
            button1.AutoSize = true;
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(891, 321);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(250, 75);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1920, 1080);
            Controls.Add(button1);
            Controls.Add(PlayButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Text = "Grid Life";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button PlayButton;
        private Button button1;
    }
}