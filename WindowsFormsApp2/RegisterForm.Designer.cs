using System.ComponentModel;

namespace WindowsFormsApp2
{
   partial class RegisterForm
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
        this.usernameLabel = new System.Windows.Forms.Label();
        this.passwordLabel = new System.Windows.Forms.Label();
        this.usernameTextBox = new System.Windows.Forms.TextBox();
        this.passwordTextBox = new System.Windows.Forms.TextBox();
        this.registerButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        
      
        this.usernameLabel.AutoSize = true;
        this.usernameLabel.Location = new System.Drawing.Point(12, 15);
        this.usernameLabel.Name = "usernameLabel";
        this.usernameLabel.Size = new System.Drawing.Size(38, 13);
        this.usernameLabel.TabIndex = 0;
        this.usernameLabel.Text = "Логин";
        
      
        this.passwordLabel.AutoSize = true;
        this.passwordLabel.Location = new System.Drawing.Point(12, 41);
        this.passwordLabel.Name = "passwordLabel";
        this.passwordLabel.Size = new System.Drawing.Size(45, 13);
        this.passwordLabel.TabIndex = 1;
        this.passwordLabel.Text = "Пароль";
        
       
        this.usernameTextBox.Location = new System.Drawing.Point(76, 12);
        this.usernameTextBox.Name = "usernameTextBox";
        this.usernameTextBox.Size = new System.Drawing.Size(196, 20);
        this.usernameTextBox.TabIndex = 2;
        
       
        this.passwordTextBox.Location = new System.Drawing.Point(76, 38);
        this.passwordTextBox.Name = "passwordTextBox";
        this.passwordTextBox.PasswordChar = '*';
        this.passwordTextBox.Size = new System.Drawing.Size(196, 20);
        this.passwordTextBox.TabIndex = 3;
        
      
        this.registerButton.Location = new System.Drawing.Point(197, 64);
        this.registerButton.Name = "registerButton";
        this.registerButton.Size = new System.Drawing.Size(75, 23);
        this.registerButton.TabIndex = 4;
        this.registerButton.Text = "Регистрация";
        this.registerButton.UseVisualStyleBackColor = true;
        this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
        
       
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 101);
        this.Controls.Add(this.registerButton);
        this.Controls.Add(this.passwordTextBox);
        this.Controls.Add(this.usernameTextBox);
        this.Controls.Add(this.passwordLabel);
        this.Controls.Add(this.usernameLabel);
        this.Name = "RegisterForm";
        this.Text = "Регистрация";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label usernameLabel;
    private System.Windows.Forms.Label passwordLabel;
    private System.Windows.Forms.TextBox usernameTextBox;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Button registerButton;
}

}