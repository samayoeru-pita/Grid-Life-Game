namespace GridLife
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectedItemLabel = new Label();
            messageLabel = new Label();
            SuspendLayout();
            // 
            // SelectedItemLabel
            // 
            SelectedItemLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SelectedItemLabel.AutoSize = true;
            SelectedItemLabel.BackColor = Color.Transparent;
            SelectedItemLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemLabel.ForeColor = Color.White;
            SelectedItemLabel.Location = new Point(12, 1041);
            SelectedItemLabel.Name = "SelectedItemLabel";
            SelectedItemLabel.Size = new Size(380, 30);
            SelectedItemLabel.TabIndex = 0;
            SelectedItemLabel.Text = "Interact with blocks using arrow keys";
            SelectedItemLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            messageLabel.BackColor = Color.FromArgb(210, 20, 20, 60);
            messageLabel.BorderStyle = BorderStyle.Fixed3D;
            messageLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            messageLabel.ForeColor = Color.White;
            messageLabel.Location = new Point(634, 109);
            messageLabel.Margin = new Padding(625, 100, 625, 100);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(670, 244);
            messageLabel.TabIndex = 1;
            messageLabel.Text = "text";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1920, 1080);
            Controls.Add(messageLabel);
            Controls.Add(SelectedItemLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "Form1";
            Text = "Grid Life";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedItemLabel;
        private Label messageLabel;
    }
}