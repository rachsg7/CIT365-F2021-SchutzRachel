
namespace MegaDesk_Schutz
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.searchQuotesBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchQuotesBackButton
            // 
            this.searchQuotesBackButton.Location = new System.Drawing.Point(713, 415);
            this.searchQuotesBackButton.Name = "searchQuotesBackButton";
            this.searchQuotesBackButton.Size = new System.Drawing.Size(75, 23);
            this.searchQuotesBackButton.TabIndex = 2;
            this.searchQuotesBackButton.Text = "Back";
            this.searchQuotesBackButton.UseVisualStyleBackColor = true;
            this.searchQuotesBackButton.Click += new System.EventHandler(this.searchQuotesBackButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchQuotesBackButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchQuotesBackButton;
    }
}