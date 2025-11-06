namespace ToDoManager.UI
{
    partial class RegisterForm
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
            label2 = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnRegister = new Button();
            txtPassword = new TextBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.Size = new Size(99, 31);
            label2.TabIndex = 10;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(74, 11);
            label1.Name = "label1";
            label1.Size = new Size(59, 31);
            label1.TabIndex = 9;
            label1.Text = "Ім'я";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Cyan;
            btnBack.Location = new Point(182, 195);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(111, 37);
            btnBack.TabIndex = 8;
            btnBack.Text = "Повернутись";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Cyan;
            btnRegister.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnRegister.Location = new Point(16, 195);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(117, 37);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Регестрація";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(74, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(156, 34);
            txtPassword.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(74, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(156, 34);
            txtName.TabIndex = 6;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(305, 244);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnBack;
        private Button btnRegister;
        private TextBox txtPassword;
        private TextBox txtName;
    }
}