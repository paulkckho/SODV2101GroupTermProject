
namespace SODV_2101_Term_Project
{
    partial class TermProjectpg2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermProjectpg2));
            this.nextpgbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.interactiveMenu11 = new SODV_2101_Term_Project.InteractiveMenu1();
            this.SuspendLayout();
            // 
            // nextpgbtn
            // 
            this.nextpgbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nextpgbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextpgbtn.ForeColor = System.Drawing.Color.Blue;
            this.nextpgbtn.Location = new System.Drawing.Point(718, 592);
            this.nextpgbtn.Name = "nextpgbtn";
            this.nextpgbtn.Size = new System.Drawing.Size(146, 46);
            this.nextpgbtn.TabIndex = 6;
            this.nextpgbtn.Text = "Next page";
            this.nextpgbtn.UseVisualStyleBackColor = false;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.Blue;
            this.backbtn.Location = new System.Drawing.Point(12, 592);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(199, 46);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Previous page";
            this.backbtn.UseVisualStyleBackColor = false;
            // 
            // interactiveMenu11
            // 
            this.interactiveMenu11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.interactiveMenu11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.interactiveMenu11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactiveMenu11.Location = new System.Drawing.Point(14, 1);
            this.interactiveMenu11.Margin = new System.Windows.Forms.Padding(5);
            this.interactiveMenu11.Name = "interactiveMenu11";
            this.interactiveMenu11.Size = new System.Drawing.Size(454, 494);
            this.interactiveMenu11.TabIndex = 0;
            // 
            // TermProjectpg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 650);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.nextpgbtn);
            this.Controls.Add(this.interactiveMenu11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TermProjectpg2";
            this.Text = "SODV 2101 Term Project page 2";
            this.Load += new System.EventHandler(this.TermProjectpg2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private InteractiveMenu1 interactiveMenu11;
        private System.Windows.Forms.Button nextpgbtn;
        private System.Windows.Forms.Button backbtn;
    }
}