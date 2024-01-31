namespace Penguin_Maze
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.timer_Penguin = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Map = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_Lives = new System.Windows.Forms.Label();
            this.label_Hammers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Energy = new System.Windows.Forms.Label();
            this.HintButton = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintButton)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_Penguin
            // 
            this.timer_Penguin.Enabled = true;
            this.timer_Penguin.Interval = 200;
            this.timer_Penguin.Tick += new System.EventHandler(this.timer_Penguin_Tick);
            // 
            // pictureBox_Map
            // 
            this.pictureBox_Map.Location = new System.Drawing.Point(2, 45);
            this.pictureBox_Map.Name = "pictureBox_Map";
            this.pictureBox_Map.Size = new System.Drawing.Size(194, 140);
            this.pictureBox_Map.TabIndex = 0;
            this.pictureBox_Map.TabStop = false;
            this.pictureBox_Map.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Map_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(163, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(95, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label_Lives
            // 
            this.label_Lives.AutoSize = true;
            this.label_Lives.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lives.ForeColor = System.Drawing.Color.Red;
            this.label_Lives.Location = new System.Drawing.Point(61, 9);
            this.label_Lives.Name = "label_Lives";
            this.label_Lives.Size = new System.Drawing.Size(28, 29);
            this.label_Lives.TabIndex = 4;
            this.label_Lives.Text = "0";
            // 
            // label_Hammers
            // 
            this.label_Hammers.AutoSize = true;
            this.label_Hammers.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Hammers.ForeColor = System.Drawing.Color.Blue;
            this.label_Hammers.Location = new System.Drawing.Point(129, 9);
            this.label_Hammers.Name = "label_Hammers";
            this.label_Hammers.Size = new System.Drawing.Size(28, 29);
            this.label_Hammers.TabIndex = 5;
            this.label_Hammers.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "HP:";
            // 
            // label_Energy
            // 
            this.label_Energy.AutoSize = true;
            this.label_Energy.Font = new System.Drawing.Font("Unispace", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Energy.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label_Energy.Location = new System.Drawing.Point(247, 9);
            this.label_Energy.Name = "label_Energy";
            this.label_Energy.Size = new System.Drawing.Size(58, 29);
            this.label_Energy.TabIndex = 7;
            this.label_Energy.Text = "100";
            // 
            // HintButton
            // 
            this.HintButton.Image = ((System.Drawing.Image)(resources.GetObject("HintButton.Image")));
            this.HintButton.Location = new System.Drawing.Point(311, 5);
            this.HintButton.Name = "HintButton";
            this.HintButton.Size = new System.Drawing.Size(67, 33);
            this.HintButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HintButton.TabIndex = 8;
            this.HintButton.TabStop = false;
            this.HintButton.Click += new System.EventHandler(this.HintButton_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HintButton);
            this.Controls.Add(this.label_Energy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Hammers);
            this.Controls.Add(this.label_Lives);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_Map);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HintButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_Penguin;
        private System.Windows.Forms.PictureBox pictureBox_Map;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_Lives;
        private System.Windows.Forms.Label label_Hammers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Energy;
        private System.Windows.Forms.PictureBox HintButton;
        private System.Windows.Forms.Timer GameTimer;
    }
}

