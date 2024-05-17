namespace WindowsFormsApp2
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox toursListBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button addTourButton;
        private System.Windows.Forms.Button updateTourButton;
        private System.Windows.Forms.Button deleteTourButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priceLabel;

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
            this.toursListBox = new System.Windows.Forms.ListBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.addTourButton = new System.Windows.Forms.Button();
            this.updateTourButton = new System.Windows.Forms.Button();
            this.deleteTourButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

       
            this.toursListBox.FormattingEnabled = true;
            this.toursListBox.Location = new System.Drawing.Point(12, 12);
            this.toursListBox.Name = "toursListBox";
            this.toursListBox.Size = new System.Drawing.Size(360, 199);
            this.toursListBox.TabIndex = 0;
            this.toursListBox.SelectedIndexChanged += new System.EventHandler(this.toursListBox_SelectedIndexChanged);

          
            this.titleTextBox.Location = new System.Drawing.Point(12, 240);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(360, 20);
            this.titleTextBox.TabIndex = 1;

          
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 280);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(360, 20);
            this.descriptionTextBox.TabIndex = 2;

          
            this.priceTextBox.Location = new System.Drawing.Point(12, 320);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(360, 20);
            this.priceTextBox.TabIndex = 3;

            
            this.addTourButton.Location = new System.Drawing.Point(297, 350);
            this.addTourButton.Name = "addTourButton";
            this.addTourButton.Size = new System.Drawing.Size(75, 23);
            this.addTourButton.TabIndex = 4;
            this.addTourButton.Text = "Добавить тур";
            this.addTourButton.UseVisualStyleBackColor = true;
            this.addTourButton.Click += new System.EventHandler(this.addTourButton_Click);

            
            this.updateTourButton.Location = new System.Drawing.Point(12, 350);
            this.updateTourButton.Name = "updateTourButton";
            this.updateTourButton.Size = new System.Drawing.Size(75, 23);
            this.updateTourButton.TabIndex = 5;
            this.updateTourButton.Text = "Обновить тур";
            this.updateTourButton.UseVisualStyleBackColor = true;
            this.updateTourButton.Click += new System.EventHandler(this.updateTourButton_Click);

           
            this.deleteTourButton.Location = new System.Drawing.Point(156, 350);
            this.deleteTourButton.Name = "deleteTourButton";
            this.deleteTourButton.Size = new System.Drawing.Size(75, 23);
            this.deleteTourButton.TabIndex = 6;
            this.deleteTourButton.Text = "Удалить тур";
            this.deleteTourButton.UseVisualStyleBackColor = true;
            this.deleteTourButton.Click += new System.EventHandler(this.deleteTourButton_Click);

          
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 220);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 13);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Название тура";

          
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 260);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Описание тура";

          
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 300);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(33, 13);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Цена";

      
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 391);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.deleteTourButton);
            this.Controls.Add(this.updateTourButton);
            this.Controls.Add(this.addTourButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.toursListBox);
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
