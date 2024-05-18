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

          
            this.removeFavoriteButton.Location = new System.Drawing.Point(12, 220);
            this.removeFavoriteButton.Name = "removeFavoriteButton";
            this.removeFavoriteButton.Size = new System.Drawing.Size(150, 30);
            this.removeFavoriteButton.TabIndex = 3;
            this.removeFavoriteButton.Text = "Удалить из избранного";
            this.removeFavoriteButton.UseVisualStyleBackColor = true;
            this.removeFavoriteButton.Click += new System.EventHandler(this.removeFavoriteButton_Click);

           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 481);
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
