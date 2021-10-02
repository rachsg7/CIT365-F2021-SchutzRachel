
namespace MegaDesk_Schutz
{
    partial class ViewAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.allQuotesBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allQuotesBackButton
            // 
            this.allQuotesBackButton.Location = new System.Drawing.Point(713, 415);
            this.allQuotesBackButton.Name = "allQuotesBackButton";
            this.allQuotesBackButton.Size = new System.Drawing.Size(75, 23);
            this.allQuotesBackButton.TabIndex = 3;
            this.allQuotesBackButton.Text = "Back";
            this.allQuotesBackButton.UseVisualStyleBackColor = true;
            this.allQuotesBackButton.Click += new System.EventHandler(this.allQuotesBackButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allQuotesBackButton);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allQuotesBackButton;
    }
}