namespace WindowsFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.loginButton.Location = new System.Drawing.Point(100, 50);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 50);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
         
            this.registerButton.Location = new System.Drawing.Point(100, 150);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(200, 50);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Зарегистрироваться";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Главная страница";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
    }
}
