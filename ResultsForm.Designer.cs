namespace Race
{
    partial class ResultsForm
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
            resultsDataGridView = new System.Windows.Forms.DataGridView();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Scores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Coins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Name, Scores, Coins, Date });
            resultsDataGridView.Location = new System.Drawing.Point(-2, 1);
            resultsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 51;
            resultsDataGridView.RowTemplate.Height = 25;
            resultsDataGridView.Size = new System.Drawing.Size(685, 333);
            resultsDataGridView.TabIndex = 1;
            // 
            // Name
            // 
            Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Имя";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Scores
            // 
            Scores.HeaderText = "Очки";
            Scores.MinimumWidth = 6;
            Scores.Name = "Scores";
            Scores.Width = 125;
            // 
            // Coins
            // 
            Coins.HeaderText = "Монеты";
            Coins.MinimumWidth = 6;
            Coins.Name = "Coins";
            Coins.Width = 125;
            // 
            // Date
            // 
            Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Date.HeaderText = "Время и дата игры";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(686, 335);
            Controls.Add(resultsDataGridView);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            //Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}