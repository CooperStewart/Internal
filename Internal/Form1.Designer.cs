namespace Internal
{
    partial class Form1
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
            this.gameDesigner = new System.Windows.Forms.Label();
            this.endText1 = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Titan = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Titan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // gameDesigner
            // 
            this.gameDesigner.AutoSize = true;
            this.gameDesigner.Location = new System.Drawing.Point(375, 111);
            this.gameDesigner.Name = "gameDesigner";
            this.gameDesigner.Size = new System.Drawing.Size(35, 13);
            this.gameDesigner.TabIndex = 0;
            this.gameDesigner.Text = "label1";
            // 
            // endText1
            // 
            this.endText1.AutoSize = true;
            this.endText1.Location = new System.Drawing.Point(79, 99);
            this.endText1.Name = "endText1";
            this.endText1.Size = new System.Drawing.Size(35, 13);
            this.endText1.TabIndex = 1;
            this.endText1.Text = "label2";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Location = new System.Drawing.Point(383, 119);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(35, 13);
            this.scoreText.TabIndex = 2;
            this.scoreText.Text = "label3";
            // 
            // endText2
            // 
            this.endText2.AutoSize = true;
            this.endText2.Location = new System.Drawing.Point(446, 136);
            this.endText2.Name = "endText2";
            this.endText2.Size = new System.Drawing.Size(35, 13);
            this.endText2.TabIndex = 3;
            this.endText2.Text = "label4";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick_1);
            // 
            // Titan
            // 
            this.Titan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Titan.Location = new System.Drawing.Point(170, 171);
            this.Titan.Name = "Titan";
            this.Titan.Size = new System.Drawing.Size(100, 50);
            this.Titan.TabIndex = 4;
            this.Titan.TabStop = false;
            this.Titan.Click += new System.EventHandler(this.flappyBird_Click);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.SystemColors.ControlText;
            this.ground.Location = new System.Drawing.Point(-2, 316);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(806, 134);
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Location = new System.Drawing.Point(474, 62);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 50);
            this.pipeTop.TabIndex = 6;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Location = new System.Drawing.Point(613, 158);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 50);
            this.pipeBottom.TabIndex = 7;
            this.pipeBottom.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.Titan);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.gameDesigner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inGameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Titan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameDesigner;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Titan;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
    }
}

