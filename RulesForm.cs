using System;
using System.Drawing;
using System.Windows.Forms;

namespace Race
{
    public partial class RulesForm : Form
    {
        public RulesForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Silver;
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Gray;
        }
    }
}
