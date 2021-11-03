
namespace SODV_2101_Term_Project
{
    partial class InteractiveMenu1
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Timelbl = new System.Windows.Forms.Label();
            this.Detailslbl = new System.Windows.Forms.Label();
            this.timestamplbl = new System.Windows.Forms.TextBox();
            this.detailBox = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.clrbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 35);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Location = new System.Drawing.Point(51, 28);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(75, 29);
            this.Datelbl.TabIndex = 1;
            this.Datelbl.Text = "Date: ";
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Location = new System.Drawing.Point(51, 70);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(75, 29);
            this.Timelbl.TabIndex = 2;
            this.Timelbl.Text = "Time:";
            // 
            // Detailslbl
            // 
            this.Detailslbl.AutoSize = true;
            this.Detailslbl.Location = new System.Drawing.Point(37, 109);
            this.Detailslbl.Name = "Detailslbl";
            this.Detailslbl.Size = new System.Drawing.Size(99, 29);
            this.Detailslbl.TabIndex = 3;
            this.Detailslbl.Text = "Details: ";
            // 
            // timestamplbl
            // 
            this.timestamplbl.Location = new System.Drawing.Point(143, 70);
            this.timestamplbl.Name = "timestamplbl";
            this.timestamplbl.Size = new System.Drawing.Size(271, 35);
            this.timestamplbl.TabIndex = 4;
            // 
            // detailBox
            // 
            this.detailBox.Location = new System.Drawing.Point(42, 141);
            this.detailBox.Multiline = true;
            this.detailBox.Name = "detailBox";
            this.detailBox.Size = new System.Drawing.Size(372, 199);
            this.detailBox.TabIndex = 5;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(65, 346);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(139, 38);
            this.savebtn.TabIndex = 6;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // clrbtn
            // 
            this.clrbtn.Location = new System.Drawing.Point(237, 346);
            this.clrbtn.Name = "clrbtn";
            this.clrbtn.Size = new System.Drawing.Size(139, 38);
            this.clrbtn.TabIndex = 7;
            this.clrbtn.Text = "Clear";
            this.clrbtn.UseVisualStyleBackColor = true;
            // 
            // InteractiveMenu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.clrbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.Detailslbl);
            this.Controls.Add(this.detailBox);
            this.Controls.Add(this.timestamplbl);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InteractiveMenu1";
            this.Size = new System.Drawing.Size(433, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Label Timelbl;
        private System.Windows.Forms.Label Detailslbl;
        private System.Windows.Forms.TextBox timestamplbl;
        private System.Windows.Forms.TextBox detailBox;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button clrbtn;
    }
}
