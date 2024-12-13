using System;
using System.Windows.Forms;

namespace Race
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserStorage.GetUserResults();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.score, result.AmountOfCoins, result.DateOfgame);
            }
            Hide();
        }       
    }
}
