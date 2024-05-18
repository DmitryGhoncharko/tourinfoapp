namespace WindowsFormsApp2
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox toursListBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox weatherTextBox;
        private System.Windows.Forms.TextBox transportTextBox;
        private System.Windows.Forms.TextBox eventsTextBox;
        private System.Windows.Forms.Button addTourButton;
        private System.Windows.Forms.Button updateTourButton;
        private System.Windows.Forms.Button deleteTourButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label transportLabel;
        private System.Windows.Forms.Label eventsLabel;

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
            this.weatherTextBox = new System.Windows.Forms.TextBox();
            this.transportTextBox = new System.Windows.Forms.TextBox();
            this.eventsTextBox = new System.Windows.Forms.TextBox();
            this.addTourButton = new System.Windows.Forms.Button();
            this.updateTourButton = new System.Windows.Forms.Button();
            this.deleteTourButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.transportLabel = new System.Windows.Forms.Label();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // toursListBox
            // 
            this.toursListBox.FormattingEnabled = true;
            this.toursListBox.Location = new System.Drawing.Point(12, 12);
            this.toursListBox.Name = "toursListBox";
            this.toursListBox.Size = new System.Drawing.Size(560, 225);
            this.toursListBox.TabIndex = 0;
            this.toursListBox.SelectedIndexChanged += new System.EventHandler(this.toursListBox_SelectedIndexChanged);

            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(12, 260);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(560, 20);
            this.titleTextBox.TabIndex = 1;

            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 300);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(560, 20);
            this.descriptionTextBox.TabIndex = 2;

            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(12, 340);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(560, 20);
            this.priceTextBox.TabIndex = 3;

            // 
            // weatherTextBox
            // 
            this.weatherTextBox.Location = new System.Drawing.Point(12, 380);
            this.weatherTextBox.Name = "weatherTextBox";
            this.weatherTextBox.Size = new System.Drawing.Size(560, 20);
            this.weatherTextBox.TabIndex = 10;

            // 
            // transportTextBox
            // 
            this.transportTextBox.Location = new System.Drawing.Point(12, 420);
            this.transportTextBox.Name = "transportTextBox";
            this.transportTextBox.Size = new System.Drawing.Size(560, 20);
            this.transportTextBox.TabIndex = 11;

            // 
            // eventsTextBox
            // 
            this.eventsTextBox.Location = new System.Drawing.Point(12, 460);
            this.eventsTextBox.Name = "eventsTextBox";
            this.eventsTextBox.Size = new System.Drawing.Size(560, 20);
            this.eventsTextBox.TabIndex = 12;

            // 
            // addTourButton
            // 
            this.addTourButton.Location = new System.Drawing.Point(12, 500);
            this.addTourButton.Name = "addTourButton";
            this.addTourButton.Size = new System.Drawing.Size(100, 30);
            this.addTourButton.TabIndex = 4;
            this.addTourButton.Text = "Добавить тур";
            this.addTourButton.UseVisualStyleBackColor = true;
            this.addTourButton.Click += new System.EventHandler(this.addTourButton_Click);

            // 
            // updateTourButton
            // 
            this.updateTourButton.Location = new System.Drawing.Point(240, 500);
            this.updateTourButton.Name = "updateTourButton";
            this.updateTourButton.Size = new System.Drawing.Size(100, 30);
            this.updateTourButton.TabIndex = 5;
            this.updateTourButton.Text = "Обновить тур";
            this.updateTourButton.UseVisualStyleBackColor = true;
            this.updateTourButton.Click += new System.EventHandler(this.updateTourButton_Click);

            // 
            // deleteTourButton
            // 
            this.deleteTourButton.Location = new System.Drawing.Point(472, 500);
            this.deleteTourButton.Name = "deleteTourButton";
            this.deleteTourButton.Size = new System.Drawing.Size(100, 30);
            this.deleteTourButton.TabIndex = 6;
            this.deleteTourButton.Text = "Удалить тур";
            this.deleteTourButton.UseVisualStyleBackColor = true;
            this.deleteTourButton.Click += new System.EventHandler(this.deleteTourButton_Click);

            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 240);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 13);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Название тура";

            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 280);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(91, 13);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Описание тура";

            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 320);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 9;
            this.priceLabel.Text = "Цена";

            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Location = new System.Drawing.Point(12, 360);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(45, 13);
            this.weatherLabel.TabIndex = 13;
            this.weatherLabel.Text = "Погода";

            // 
            // transportLabel
            // 
            this.transportLabel.AutoSize = true;
            this.transportLabel.Location = new System.Drawing.Point(12, 400);
            this.transportLabel.Name = "transportLabel";
            this.transportLabel.Size = new System.Drawing.Size(66, 13);
            this.transportLabel.TabIndex = 14;
            this.transportLabel.Text = "Транспорт";

            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Location = new System.Drawing.Point(12, 440);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(83, 13);
            this.eventsLabel.TabIndex = 15;
            this.eventsLabel.Text = "Мероприятия";

            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.deleteTourButton);
            this.Controls.Add(this.updateTourButton);
            this.Controls.Add(this.addTourButton);
            this.Controls.Add(this.eventsTextBox);
            this.Controls.Add(this.transportTextBox);
            this.Controls.Add(this.weatherTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.toursListBox);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.transportLabel);
            this.Controls.Add(this.weatherLabel);
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
