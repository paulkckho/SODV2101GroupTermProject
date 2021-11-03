
namespace SODV_2101_Term_Project
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TermProjectTitle = new System.Windows.Forms.Label();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.creditbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TermProjectTitle
            // 
            this.TermProjectTitle.AutoSize = true;
            this.TermProjectTitle.BackColor = System.Drawing.Color.DarkRed;
            this.TermProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermProjectTitle.ForeColor = System.Drawing.Color.Yellow;
            this.TermProjectTitle.Location = new System.Drawing.Point(152, 9);
            this.TermProjectTitle.Name = "TermProjectTitle";
            this.TermProjectTitle.Size = new System.Drawing.Size(604, 55);
            this.TermProjectTitle.TabIndex = 1;
            this.TermProjectTitle.Text = "SODV 2101 Term Project ";
            // 
            // aboutbtn
            // 
            this.aboutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aboutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutbtn.ForeColor = System.Drawing.Color.Blue;
            this.aboutbtn.Location = new System.Drawing.Point(162, 67);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(130, 61);
            this.aboutbtn.TabIndex = 2;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = false;
            // 
            // creditbtn
            // 
            this.creditbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.creditbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditbtn.ForeColor = System.Drawing.Color.Blue;
            this.creditbtn.Location = new System.Drawing.Point(398, 67);
            this.creditbtn.Name = "creditbtn";
            this.creditbtn.Size = new System.Drawing.Size(130, 61);
            this.creditbtn.TabIndex = 3;
            this.creditbtn.Text = "Credit";
            this.creditbtn.UseVisualStyleBackColor = false;
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.Blue;
            this.Exitbtn.Location = new System.Drawing.Point(626, 67);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(130, 61);
            this.Exitbtn.TabIndex = 4;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.creditbtn);
            this.Controls.Add(this.aboutbtn);
            this.Controls.Add(this.TermProjectTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LandingPage";
            this.Text = "SODV 2101 Term Project Notification App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TermProjectTitle;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button creditbtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

