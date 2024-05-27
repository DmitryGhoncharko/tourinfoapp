namespace WindowsFormsApp2
{
    partial class ClientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox toursListBox;
        private System.Windows.Forms.ListBox favoritesListBox;
        private System.Windows.Forms.Button addFavoriteButton;
        private System.Windows.Forms.Button removeFavoriteButton;
        private System.Windows.Forms.Label toursLabel;
        private System.Windows.Forms.Label favoritesLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox priceMinTextBox;
        private System.Windows.Forms.TextBox priceMaxTextBox;
        private System.Windows.Forms.Button searchPriceButton;
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
            this.favoritesListBox = new System.Windows.Forms.ListBox();
            this.addFavoriteButton = new System.Windows.Forms.Button();
            this.removeFavoriteButton = new System.Windows.Forms.Button();
            this.toursLabel = new System.Windows.Forms.Label();
            this.favoritesLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.priceMinTextBox = new System.Windows.Forms.TextBox();
            this.priceMaxTextBox = new System.Windows.Forms.TextBox();
            this.searchPriceButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.toursLabel.AutoSize = true;
            this.toursLabel.Location = new System.Drawing.Point(12, 12);
            this.toursLabel.Name = "toursLabel";
            this.toursLabel.Size = new System.Drawing.Size(32, 13);
            this.toursLabel.TabIndex = 4;
            this.toursLabel.Text = "Туры";
            this.toursListBox.FormattingEnabled = true;
            this.toursListBox.Location = new System.Drawing.Point(12, 28);
            this.toursListBox.Name = "toursListBox";
            this.toursListBox.Size = new System.Drawing.Size(560, 186);
            this.toursListBox.TabIndex = 0;
            this.toursListBox.SelectedIndexChanged += new System.EventHandler(this.toursListBox_SelectedIndexChanged);
            this.addFavoriteButton.Location = new System.Drawing.Point(472, 220);
            this.addFavoriteButton.Name = "addFavoriteButton";
            this.addFavoriteButton.Size = new System.Drawing.Size(100, 30);
            this.addFavoriteButton.TabIndex = 2;
            this.addFavoriteButton.Text = "В избранное";
            this.addFavoriteButton.UseVisualStyleBackColor = true;
            this.addFavoriteButton.Click += new System.EventHandler(this.addFavoriteButton_Click);
            this.favoritesLabel.AutoSize = true;
            this.favoritesLabel.Location = new System.Drawing.Point(12, 263);
            this.favoritesLabel.Name = "favoritesLabel";
            this.favoritesLabel.Size = new System.Drawing.Size(67, 13);
            this.favoritesLabel.TabIndex = 5;
            this.favoritesLabel.Text = "Избранное";
            this.favoritesListBox.FormattingEnabled = true;
            this.favoritesListBox.Location = new System.Drawing.Point(12, 279);
            this.favoritesListBox.Name = "favoritesListBox";
            this.favoritesListBox.Size = new System.Drawing.Size(560, 186);
            this.favoritesListBox.TabIndex = 1;
            this.favoritesListBox.SelectedIndexChanged += new System.EventHandler(this.favoritesListBox_SelectedIndexChanged);
            this.removeFavoriteButton.Location = new System.Drawing.Point(12, 220);
            this.removeFavoriteButton.Name = "removeFavoriteButton";
            this.removeFavoriteButton.Size = new System.Drawing.Size(150, 30);
            this.removeFavoriteButton.TabIndex = 3;
            this.removeFavoriteButton.Text = "Удалить из избранного";
            this.removeFavoriteButton.UseVisualStyleBackColor = true;
            this.removeFavoriteButton.Click += new System.EventHandler(this.removeFavoriteButton_Click);
            this.priceMinTextBox.Location = new System.Drawing.Point(12, 522);
            this.priceMinTextBox.Name = "priceMinTextBox";
            this.priceMinTextBox.Size = new System.Drawing.Size(75, 20);
            this.priceMinTextBox.TabIndex = 9;
            this.priceMaxTextBox.Location = new System.Drawing.Point(102, 522);
            this.priceMaxTextBox.Name = "priceMaxTextBox";
            this.priceMaxTextBox.Size = new System.Drawing.Size(75, 20);
            this.priceMaxTextBox.TabIndex = 10;
            this.searchPriceButton.Location = new System.Drawing.Point(210, 520);
            this.searchPriceButton.Name = "searchPriceButton";
            this.searchPriceButton.Size = new System.Drawing.Size(75, 23);
            this.searchPriceButton.TabIndex = 11;
            this.searchPriceButton.Text = "Поиск по цене";
            this.searchPriceButton.UseVisualStyleBackColor = true;
            this.searchPriceButton.Click += new System.EventHandler(this.searchPriceButton_Click);
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 506);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(124, 13);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "Поиск по цене (мин - макс)";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.searchPriceButton);
            this.Controls.Add(this.priceMaxTextBox);
            this.Controls.Add(this.priceMinTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.favoritesLabel);
            this.Controls.Add(this.toursLabel);
            this.Controls.Add(this.removeFavoriteButton);
            this.Controls.Add(this.addFavoriteButton);
            this.Controls.Add(this.favoritesListBox);
            this.Controls.Add(this.toursListBox);
            this.Name = "ClientForm";
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
