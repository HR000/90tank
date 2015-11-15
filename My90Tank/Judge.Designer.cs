namespace My90Tank
{
    partial class Judge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Judge));
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.btnPlayer2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay1
            // 
            this.btnPlay1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay1.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay1.Image")));
            this.btnPlay1.Location = new System.Drawing.Point(69, 44);
            this.btnPlay1.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(150, 63);
            this.btnPlay1.TabIndex = 0;
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // btnPlayer2
            // 
            this.btnPlayer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayer2.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayer2.Image")));
            this.btnPlayer2.Location = new System.Drawing.Point(69, 133);
            this.btnPlayer2.Name = "btnPlayer2";
            this.btnPlayer2.Size = new System.Drawing.Size(150, 63);
            this.btnPlayer2.TabIndex = 1;
            this.btnPlayer2.UseVisualStyleBackColor = true;
            this.btnPlayer2.Click += new System.EventHandler(this.btnPlayer2_Click);
            // 
            // Judge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPlayer2);
            this.Controls.Add(this.btnPlay1);
            this.Name = "Judge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Judge";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.Button btnPlayer2;

    }
}