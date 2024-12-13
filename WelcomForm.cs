using System;
using System.Drawing;
using System.Windows.Forms;

namespace Race
{
    public partial class WelcomForm : Form
    {
        public WelcomForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ContinueButton_Click(object sender, EventArgs e)
        {
            var name = Convert.ToString(UserTextBox.Text);
            if (name == string.Empty)
            {
                MessageBox.Show("Пожалуйста, обязательно введите свое имя! Попробуйте еще раз.");
            }
            else
            {
                var user = new User(name);
                RaceGame raceGame = new RaceGame();
                raceGame.user = new User(name);
                raceGame.ShowDialog();
                this.Close();
            }
        }
        private void ContinueButton_MouseHover(object sender, EventArgs e)
        {
            ContinueButton.BackColor = Color.Gray;
        }
        private void ContinueButton_MouseLeave(object sender, EventArgs e)
        {
            ContinueButton.BackColor = Color.Silver;
        }         
    }
}
