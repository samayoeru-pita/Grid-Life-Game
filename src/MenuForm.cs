using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridLife
{
    public partial class MenuForm : Form
    {
        public MenuForm() {
            InitializeComponent();
            nameLabel.Location = new Point((this.Size.Width - nameLabel.Width) / 2, (int)(this.Size.Height * 0.1));
            playButton.Location = new Point((this.Size.Width - playButton.Width) / 2, (int)(this.Size.Height * 0.2));
            exitButton.Location = new Point((this.Size.Width - exitButton.Width) / 2, (int)(this.Size.Height * 0.3));
        }

        private void Button1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void PlayButton_Click(object sender, EventArgs e) {
            Form gameForm = new Form1();
            gameForm.Show();
            this.Hide();
        }
    }
}
