namespace Lab22
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtWord1;
        private System.Windows.Forms.TextBox txtWord2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblText;

        // Метод для очистки ресурсов
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Инициализация компонентов
        private void InitializeComponent()
        {
            txtWord1 = new TextBox();
            txtWord2 = new TextBox();
            btnCheck = new Button();
            lblResult = new Label();
            lblText = new Label();
            SuspendLayout();
            // 
            // txtWord1
            // 
            txtWord1.Location = new Point(12, 32);
            txtWord1.Name = "txtWord1";
            txtWord1.Size = new Size(310, 23);
            txtWord1.TabIndex = 0;
            // 
            // txtWord2
            // 
            txtWord2.Location = new Point(12, 78);
            txtWord2.Multiline = true;
            txtWord2.Name = "txtWord2";
            txtWord2.Size = new Size(310, 21);
            txtWord2.TabIndex = 1;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(328, 49);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(104, 33);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Проверить";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(12, 102);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(420, 23);
            lblResult.TabIndex = 3;
            // 
            // lblText
            // 
            lblText.Location = new Point(12, 5);
            lblText.Name = "lblText";
            lblText.Size = new Size(420, 23);
            lblText.TabIndex = 3;
            lblText.Text = "Введите слова для проверки";
            // 
            // Form1
            // 
            ClientSize = new Size(454, 128);
            Controls.Add(lblText);
            Controls.Add(lblResult);
            Controls.Add(btnCheck);
            Controls.Add(txtWord2);
            Controls.Add(txtWord1);
            Name = "Form1";
            Text = "Проверка слов";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
