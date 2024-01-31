namespace Penguin_Maze
{
    partial class GameWinner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWinner));
            this.QuitButton = new System.Windows.Forms.PictureBox();
            this.RetryButton = new System.Windows.Forms.PictureBox();
            this.label_GameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetryButton)).BeginInit();
            this.SuspendLayout();
            // 
            // QuitButton
            // 
            this.QuitButton.Image = ((System.Drawing.Image)(resources.GetObject("QuitButton.Image")));
            this.QuitButton.Location = new System.Drawing.Point(154, 285);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(236, 106);
            this.QuitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QuitButton.TabIndex = 5;
            this.QuitButton.TabStop = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // RetryButton
            // 
            this.RetryButton.Image = ((System.Drawing.Image)(resources.GetObject("RetryButton.Image")));
            this.RetryButton.Location = new System.Drawing.Point(154, 143);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(236, 106);
            this.RetryButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RetryButton.TabIndex = 4;
            this.RetryButton.TabStop = false;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // label_GameOver
            // 
            this.label_GameOver.AutoSize = true;
            this.label_GameOver.Font = new System.Drawing.Font("Goudy Stout", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GameOver.ForeColor = System.Drawing.Color.White;
            this.label_GameOver.Location = new System.Drawing.Point(75, 31);
            this.label_GameOver.Name = "label_GameOver";
            this.label_GameOver.Size = new System.Drawing.Size(394, 66);
            this.label_GameOver.TabIndex = 3;
            this.label_GameOver.Text = "Winner";
            this.label_GameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameWinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(554, 430);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.label_GameOver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameWinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameWinner";
            ((System.ComponentModel.ISupportInitialize)(this.QuitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RetryButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QuitButton;
        private System.Windows.Forms.PictureBox RetryButton;
        private System.Windows.Forms.Label label_GameOver;
    }
}