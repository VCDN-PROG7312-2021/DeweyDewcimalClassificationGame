using System.ComponentModel;

namespace DeweyDewcimalClassificationGame
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.btnFindingCallNumbers = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.XP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnReplacingBooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReplacingBooks.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReplacingBooks.Location = new System.Drawing.Point(47, 109);
            this.btnReplacingBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(163, 40);
            this.btnReplacingBooks.TabIndex = 0;
            this.btnReplacingBooks.Text = "Replacing Books";
            this.btnReplacingBooks.UseVisualStyleBackColor = true;
            this.btnReplacingBooks.Click += new System.EventHandler(this.btnReplacingBooks_Click);
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(253, 109);
            this.btnIdentifyingAreas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(163, 40);
            this.btnIdentifyingAreas.TabIndex = 1;
            this.btnIdentifyingAreas.Text = "Identifying Areas";
            this.btnIdentifyingAreas.UseVisualStyleBackColor = true;
            this.btnIdentifyingAreas.Click += new System.EventHandler(this.btnIdentifyingAreas_Click);
            // 
            // btnFindingCallNumbers
            // 
            this.btnFindingCallNumbers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnFindingCallNumbers.Location = new System.Drawing.Point(457, 109);
            this.btnFindingCallNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindingCallNumbers.Name = "btnFindingCallNumbers";
            this.btnFindingCallNumbers.Size = new System.Drawing.Size(163, 40);
            this.btnFindingCallNumbers.TabIndex = 2;
            this.btnFindingCallNumbers.Text = "Finding Call Numbers";
            this.btnFindingCallNumbers.UseVisualStyleBackColor = true;
            this.btnFindingCallNumbers.Click += new System.EventHandler(this.btnFindingCallNumbers_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(81, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(493, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Welcome to Dewey Decimal Classification Game. Click any minigame below.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // XP
            // 
            this.XP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.XP.Location = new System.Drawing.Point(302, 177);
            this.XP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.XP.Name = "XP";
            this.XP.ReadOnly = true;
            this.XP.Size = new System.Drawing.Size(129, 25);
            this.XP.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(233, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total XP:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(655, 235);
            this.Controls.Add(this.btnReplacingBooks);
            this.Controls.Add(this.btnIdentifyingAreas);
            this.Controls.Add(this.btnFindingCallNumbers);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.XP);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Home";
            this.Text = "Dewey Decimal Classification Game";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Button btnIdentifyingAreas;
        private System.Windows.Forms.Button btnFindingCallNumbers;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox XP;
        private System.Windows.Forms.Label label5;
    }
}