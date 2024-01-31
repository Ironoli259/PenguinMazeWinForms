namespace Penguin_Maze
{
    partial class FormGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameOver));
            this.label_GameOver = new System.Windows.Forms.Label();
            this.RetryButton = new System.Windows.Forms.PictureBox();
            this.QuitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RetryButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label_GameOver
            // 
            this.label_GameOver.AutoSize = true;
            this.label_GameOver.Font = new System.Drawing.Font("Goudy Stout", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GameOver.ForeColor = System.Drawing.Color.White;
            this.label_GameOver.Location = new System.Drawing.Point(2, 26);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(552, 66);
            this.label_GameOver.TabIndex = 0;
            this.label_GameOver.Text = "Game Over";
            this.label_GameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RetryButton
            // 
            this.RetryButton.Image = ((System.Drawing.Image)(resources.GetObject("RetryButton.Image")));
            this.RetryButton.Location = new System.Drawing.Point(155, 129);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(236, 106);
            this.RetryButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RetryButton.TabIndex = 1;
            this.RetryButton.TabStop = false;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Image = ((System.Drawing.Image)(resources.GetObject("QuitButton.Image")));
            this.QuitButton.Location = new System.Drawing.Point(155, 271);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(236, 106);
            this.QuitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuitButton.TabIndex = 2;
            this.QuitButton.TabStop = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(554, 430);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.label_GameOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormGameOver";
            ((System.ComponentModel.ISupportInitialize)(this.RetryButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_GameOver;
        private System.Windows.Forms.PictureBox RetryButton;
        private System.Windows.Forms.PictureBox QuitButton;
    }
}