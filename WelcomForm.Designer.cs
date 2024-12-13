namespace Race
{
    partial class WelcomForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ContinueButton = new System.Windows.Forms.Button();
            UserTextBox = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(165, 90);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(542, 40);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать в игру гонки!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(181, 166);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(522, 40);
            label2.TabIndex = 1;
            label2.Text = "Напишите Ваше имя, чемпион!";
            // 
            // ContinueButton
            // 
            ContinueButton.BackColor = System.Drawing.Color.Silver;
            ContinueButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ContinueButton.Location = new System.Drawing.Point(165, 306);
            ContinueButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new System.Drawing.Size(460, 66);
            ContinueButton.TabIndex = 2;
            ContinueButton.Text = "Нажмите для продолжения";
            ContinueButton.UseVisualStyleBackColor = false;
            ContinueButton.Click += ContinueButton_Click;
            ContinueButton.MouseLeave += ContinueButton_MouseLeave;
            ContinueButton.MouseHover += ContinueButton_MouseHover;
            // 
            // UserTextBox
            // 
            UserTextBox.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            UserTextBox.Location = new System.Drawing.Point(208, 234);
            UserTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new System.Drawing.Size(356, 35);
            UserTextBox.TabIndex = 3;
            UserTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WelcomForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.RosyBrown;
            ClientSize = new System.Drawing.Size(764, 449);
            Controls.Add(UserTextBox);
            Controls.Add(ContinueButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            Name = "WelcomForm";
            Text = "Гонки ;)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.TextBox UserTextBox;
    }
}