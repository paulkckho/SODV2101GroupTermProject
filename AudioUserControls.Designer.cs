
namespace SODV_2101_Term_Project
{
    partial class AudioUserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioUserControls));
            this.audiobtn = new System.Windows.Forms.Button();
            this.RecordBtn = new System.Windows.Forms.Button();
            this.TimerBtn = new System.Windows.Forms.Button();
            this.AlertOnBtn = new System.Windows.Forms.Button();
            this.AlertOffbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // audiobtn
            // 
            this.audiobtn.BackColor = System.Drawing.Color.White;
            this.audiobtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("audiobtn.BackgroundImage")));
            this.audiobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.audiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.audiobtn.ForeColor = System.Drawing.Color.DarkRed;
            this.audiobtn.Location = new System.Drawing.Point(587, 179);
            this.audiobtn.Name = "audiobtn";
            this.audiobtn.Size = new System.Drawing.Size(48, 47);
            this.audiobtn.TabIndex = 0;
            this.audiobtn.UseVisualStyleBackColor = false;
            this.audiobtn.Click += new System.EventHandler(this.audiobtn_Click);
            // 
            // RecordBtn
            // 
            this.RecordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecordBtn.BackgroundImage")));
            this.RecordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecordBtn.Location = new System.Drawing.Point(587, 130);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(48, 43);
            this.RecordBtn.TabIndex = 1;
            this.RecordBtn.UseVisualStyleBackColor = true;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // TimerBtn
            // 
            this.TimerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TimerBtn.Location = new System.Drawing.Point(587, 88);
            this.TimerBtn.Name = "TimerBtn";
            this.TimerBtn.Size = new System.Drawing.Size(48, 36);
            this.TimerBtn.TabIndex = 2;
            this.TimerBtn.Text = "Timer";
            this.TimerBtn.UseVisualStyleBackColor = true;
            this.TimerBtn.Click += new System.EventHandler(this.TimerBtn_Click);
            // 
            // AlertOnBtn
            // 
            this.AlertOnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlertOnBtn.Location = new System.Drawing.Point(587, 3);
            this.AlertOnBtn.Name = "AlertOnBtn";
            this.AlertOnBtn.Size = new System.Drawing.Size(48, 35);
            this.AlertOnBtn.TabIndex = 3;
            this.AlertOnBtn.Text = "On";
            this.AlertOnBtn.UseVisualStyleBackColor = true;
            this.AlertOnBtn.Click += new System.EventHandler(this.AlertOnBtn_Click);
            // 
            // AlertOffbtn
            // 
            this.AlertOffbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AlertOffbtn.Location = new System.Drawing.Point(587, 44);
            this.AlertOffbtn.Name = "AlertOffbtn";
            this.AlertOffbtn.Size = new System.Drawing.Size(48, 38);
            this.AlertOffbtn.TabIndex = 4;
            this.AlertOffbtn.Text = "OFF";
            this.AlertOffbtn.UseVisualStyleBackColor = true;
            this.AlertOffbtn.Click += new System.EventHandler(this.AlertOffbtn_Click);
            // 
            // AudioUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.AlertOffbtn);
            this.Controls.Add(this.AlertOnBtn);
            this.Controls.Add(this.TimerBtn);
            this.Controls.Add(this.RecordBtn);
            this.Controls.Add(this.audiobtn);
            this.Name = "AudioUserControls";
            this.Size = new System.Drawing.Size(661, 329);
            this.Load += new System.EventHandler(this.AudioUserControls_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button audiobtn;
        private System.Windows.Forms.Button RecordBtn;
        private System.Windows.Forms.Button TimerBtn;
        private System.Windows.Forms.Button AlertOnBtn;
        private System.Windows.Forms.Button AlertOffbtn;
    }
}
