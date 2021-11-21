
namespace SODV_2101_Term_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.exitbtn = new System.Windows.Forms.Button();
            this.titlelbl = new System.Windows.Forms.Label();
            this.Aboutbtn = new System.Windows.Forms.Button();
            this.reminderPn = new System.Windows.Forms.Panel();
            this.UpdatePn = new System.Windows.Forms.Panel();
            this.NewReminderlbl = new System.Windows.Forms.Label();
            this.updatelbl = new System.Windows.Forms.Label();
            this.reminderlbl = new System.Windows.Forms.Label();
            this.rNameText = new System.Windows.Forms.TextBox();
            this.reminderTimelbl = new System.Windows.Forms.Label();
            this.rRepeatlbl = new System.Windows.Forms.Label();
            this.rTimeText = new System.Windows.Forms.TextBox();
            this.rCountsUpDown = new System.Windows.Forms.NumericUpDown();
            this.ReminderDateSelct = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.Delbtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.RecBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.optionslbl = new System.Windows.Forms.Label();
            this.remindertltlelbl = new System.Windows.Forms.Label();
            this.reminderText = new System.Windows.Forms.TextBox();
            this.tablelayoutpn1 = new System.Windows.Forms.TableLayoutPanel();
            this.Detailslbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newCreatebtn = new System.Windows.Forms.Button();
            this.newDelbtn = new System.Windows.Forms.Button();
            this.reminderPn.SuspendLayout();
            this.UpdatePn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rCountsUpDown)).BeginInit();
            this.tablelayoutpn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.White;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.Red;
            this.exitbtn.Location = new System.Drawing.Point(632, 11);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(96, 59);
            this.exitbtn.TabIndex = 0;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.BackColor = System.Drawing.Color.Yellow;
            this.titlelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titlelbl.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.Color.Blue;
            this.titlelbl.Location = new System.Drawing.Point(19, 9);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(295, 59);
            this.titlelbl.TabIndex = 1;
            this.titlelbl.Text = "Reminder App";
            // 
            // Aboutbtn
            // 
            this.Aboutbtn.BackColor = System.Drawing.Color.Navy;
            this.Aboutbtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aboutbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Aboutbtn.Location = new System.Drawing.Point(329, 11);
            this.Aboutbtn.Name = "Aboutbtn";
            this.Aboutbtn.Size = new System.Drawing.Size(96, 59);
            this.Aboutbtn.TabIndex = 2;
            this.Aboutbtn.Text = "About";
            this.Aboutbtn.UseVisualStyleBackColor = false;
            // 
            // reminderPn
            // 
            this.reminderPn.Controls.Add(this.newDelbtn);
            this.reminderPn.Controls.Add(this.newCreatebtn);
            this.reminderPn.Controls.Add(this.textBox1);
            this.reminderPn.Controls.Add(this.Detailslbl);
            this.reminderPn.Controls.Add(this.remindertltlelbl);
            this.reminderPn.Controls.Add(this.NewReminderlbl);
            this.reminderPn.Controls.Add(this.rNameText);
            this.reminderPn.Location = new System.Drawing.Point(12, 81);
            this.reminderPn.Name = "reminderPn";
            this.reminderPn.Size = new System.Drawing.Size(300, 420);
            this.reminderPn.TabIndex = 3;
            // 
            // UpdatePn
            // 
            this.UpdatePn.Controls.Add(this.reminderText);
            this.UpdatePn.Controls.Add(this.optionslbl);
            this.UpdatePn.Controls.Add(this.playBtn);
            this.UpdatePn.Controls.Add(this.RecBtn);
            this.UpdatePn.Controls.Add(this.label1);
            this.UpdatePn.Controls.Add(this.ReminderDateSelct);
            this.UpdatePn.Controls.Add(this.rCountsUpDown);
            this.UpdatePn.Controls.Add(this.rTimeText);
            this.UpdatePn.Controls.Add(this.rRepeatlbl);
            this.UpdatePn.Controls.Add(this.reminderTimelbl);
            this.UpdatePn.Controls.Add(this.reminderlbl);
            this.UpdatePn.Controls.Add(this.updatelbl);
            this.UpdatePn.Controls.Add(this.tablelayoutpn1);
            this.UpdatePn.Location = new System.Drawing.Point(329, 81);
            this.UpdatePn.Name = "UpdatePn";
            this.UpdatePn.Size = new System.Drawing.Size(393, 420);
            this.UpdatePn.TabIndex = 4;
            // 
            // NewReminderlbl
            // 
            this.NewReminderlbl.AutoSize = true;
            this.NewReminderlbl.BackColor = System.Drawing.Color.Yellow;
            this.NewReminderlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NewReminderlbl.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReminderlbl.ForeColor = System.Drawing.Color.Blue;
            this.NewReminderlbl.Location = new System.Drawing.Point(2, 0);
            this.NewReminderlbl.Name = "NewReminderlbl";
            this.NewReminderlbl.Size = new System.Drawing.Size(300, 59);
            this.NewReminderlbl.TabIndex = 2;
            this.NewReminderlbl.Text = "New Reminder";
            // 
            // updatelbl
            // 
            this.updatelbl.AutoSize = true;
            this.updatelbl.BackColor = System.Drawing.Color.Yellow;
            this.updatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.updatelbl.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatelbl.ForeColor = System.Drawing.Color.Blue;
            this.updatelbl.Location = new System.Drawing.Point(3, 0);
            this.updatelbl.Name = "updatelbl";
            this.updatelbl.Size = new System.Drawing.Size(396, 59);
            this.updatelbl.TabIndex = 3;
            this.updatelbl.Text = "  Update Reminder  ";
            // 
            // reminderlbl
            // 
            this.reminderlbl.AutoSize = true;
            this.reminderlbl.Location = new System.Drawing.Point(27, 73);
            this.reminderlbl.Name = "reminderlbl";
            this.reminderlbl.Size = new System.Drawing.Size(124, 20);
            this.reminderlbl.TabIndex = 4;
            this.reminderlbl.Text = "Reminder Name";
            // 
            // rNameText
            // 
            this.rNameText.Location = new System.Drawing.Point(16, 96);
            this.rNameText.Name = "rNameText";
            this.rNameText.Size = new System.Drawing.Size(264, 26);
            this.rNameText.TabIndex = 5;
            // 
            // reminderTimelbl
            // 
            this.reminderTimelbl.AutoSize = true;
            this.reminderTimelbl.Location = new System.Drawing.Point(27, 125);
            this.reminderTimelbl.Name = "reminderTimelbl";
            this.reminderTimelbl.Size = new System.Drawing.Size(116, 20);
            this.reminderTimelbl.TabIndex = 6;
            this.reminderTimelbl.Text = "Reminder Time";
            // 
            // rRepeatlbl
            // 
            this.rRepeatlbl.AutoSize = true;
            this.rRepeatlbl.Location = new System.Drawing.Point(27, 170);
            this.rRepeatlbl.Name = "rRepeatlbl";
            this.rRepeatlbl.Size = new System.Drawing.Size(143, 20);
            this.rRepeatlbl.TabIndex = 7;
            this.rRepeatlbl.Text = "Reminder Repeats";
            // 
            // rTimeText
            // 
            this.rTimeText.Location = new System.Drawing.Point(172, 125);
            this.rTimeText.Name = "rTimeText";
            this.rTimeText.Size = new System.Drawing.Size(191, 26);
            this.rTimeText.TabIndex = 8;
            // 
            // rCountsUpDown
            // 
            this.rCountsUpDown.Location = new System.Drawing.Point(267, 164);
            this.rCountsUpDown.Name = "rCountsUpDown";
            this.rCountsUpDown.Size = new System.Drawing.Size(96, 26);
            this.rCountsUpDown.TabIndex = 9;
            // 
            // ReminderDateSelct
            // 
            this.ReminderDateSelct.Location = new System.Drawing.Point(171, 214);
            this.ReminderDateSelct.Name = "ReminderDateSelct";
            this.ReminderDateSelct.Size = new System.Drawing.Size(206, 26);
            this.ReminderDateSelct.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reminder Date";
            // 
            // createbtn
            // 
            this.createbtn.BackColor = System.Drawing.Color.Navy;
            this.createbtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createbtn.Location = new System.Drawing.Point(4, 4);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(92, 59);
            this.createbtn.TabIndex = 5;
            this.createbtn.Text = "Create";
            this.createbtn.UseVisualStyleBackColor = false;
            // 
            // Delbtn
            // 
            this.Delbtn.BackColor = System.Drawing.Color.Navy;
            this.Delbtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Delbtn.Location = new System.Drawing.Point(4, 81);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(92, 59);
            this.Delbtn.TabIndex = 12;
            this.Delbtn.Text = "Delete";
            this.Delbtn.UseVisualStyleBackColor = false;
            // 
            // clrBtn
            // 
            this.clrBtn.BackColor = System.Drawing.Color.Navy;
            this.clrBtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clrBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clrBtn.Location = new System.Drawing.Point(103, 4);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(93, 59);
            this.clrBtn.TabIndex = 13;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = false;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Navy;
            this.savebtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.savebtn.Location = new System.Drawing.Point(103, 81);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(93, 59);
            this.savebtn.TabIndex = 14;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            // 
            // RecBtn
            // 
            this.RecBtn.BackColor = System.Drawing.Color.Navy;
            this.RecBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecBtn.BackgroundImage")));
            this.RecBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecBtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RecBtn.Location = new System.Drawing.Point(50, 269);
            this.RecBtn.Name = "RecBtn";
            this.RecBtn.Size = new System.Drawing.Size(65, 52);
            this.RecBtn.TabIndex = 15;
            this.RecBtn.UseVisualStyleBackColor = false;
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.Navy;
            this.playBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playBtn.BackgroundImage")));
            this.playBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playBtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.playBtn.Location = new System.Drawing.Point(58, 342);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(57, 52);
            this.playBtn.TabIndex = 6;
            this.playBtn.UseVisualStyleBackColor = false;
            // 
            // optionslbl
            // 
            this.optionslbl.AutoSize = true;
            this.optionslbl.Location = new System.Drawing.Point(32, 246);
            this.optionslbl.Name = "optionslbl";
            this.optionslbl.Size = new System.Drawing.Size(64, 20);
            this.optionslbl.TabIndex = 16;
            this.optionslbl.Text = "Options";
            // 
            // remindertltlelbl
            // 
            this.remindertltlelbl.AutoSize = true;
            this.remindertltlelbl.Location = new System.Drawing.Point(21, 70);
            this.remindertltlelbl.Name = "remindertltlelbl";
            this.remindertltlelbl.Size = new System.Drawing.Size(38, 20);
            this.remindertltlelbl.TabIndex = 5;
            this.remindertltlelbl.Text = "Title";
            // 
            // reminderText
            // 
            this.reminderText.Location = new System.Drawing.Point(170, 70);
            this.reminderText.Name = "reminderText";
            this.reminderText.Size = new System.Drawing.Size(192, 26);
            this.reminderText.TabIndex = 17;
            // 
            // tablelayoutpn1
            // 
            this.tablelayoutpn1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tablelayoutpn1.ColumnCount = 2;
            this.tablelayoutpn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelayoutpn1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelayoutpn1.Controls.Add(this.Delbtn, 0, 1);
            this.tablelayoutpn1.Controls.Add(this.savebtn, 1, 1);
            this.tablelayoutpn1.Controls.Add(this.createbtn, 0, 0);
            this.tablelayoutpn1.Controls.Add(this.clrBtn, 1, 0);
            this.tablelayoutpn1.Location = new System.Drawing.Point(177, 246);
            this.tablelayoutpn1.Margin = new System.Windows.Forms.Padding(2);
            this.tablelayoutpn1.Name = "tablelayoutpn1";
            this.tablelayoutpn1.RowCount = 2;
            this.tablelayoutpn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelayoutpn1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelayoutpn1.Size = new System.Drawing.Size(200, 155);
            this.tablelayoutpn1.TabIndex = 18;
            // 
            // Detailslbl
            // 
            this.Detailslbl.AutoSize = true;
            this.Detailslbl.Location = new System.Drawing.Point(21, 143);
            this.Detailslbl.Name = "Detailslbl";
            this.Detailslbl.Size = new System.Drawing.Size(58, 20);
            this.Detailslbl.TabIndex = 6;
            this.Detailslbl.Text = "Details";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 169);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 148);
            this.textBox1.TabIndex = 7;
            // 
            // newCreatebtn
            // 
            this.newCreatebtn.BackColor = System.Drawing.Color.Navy;
            this.newCreatebtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCreatebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newCreatebtn.Location = new System.Drawing.Point(35, 342);
            this.newCreatebtn.Name = "newCreatebtn";
            this.newCreatebtn.Size = new System.Drawing.Size(96, 59);
            this.newCreatebtn.TabIndex = 8;
            this.newCreatebtn.Text = "Create";
            this.newCreatebtn.UseVisualStyleBackColor = false;
            // 
            // newDelbtn
            // 
            this.newDelbtn.BackColor = System.Drawing.Color.Navy;
            this.newDelbtn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDelbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newDelbtn.Location = new System.Drawing.Point(156, 342);
            this.newDelbtn.Name = "newDelbtn";
            this.newDelbtn.Size = new System.Drawing.Size(92, 59);
            this.newDelbtn.TabIndex = 15;
            this.newDelbtn.Text = "Delete";
            this.newDelbtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 525);
            this.Controls.Add(this.UpdatePn);
            this.Controls.Add(this.reminderPn);
            this.Controls.Add(this.Aboutbtn);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.exitbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "SODV 2101 Term Project Reminder App ";
            this.reminderPn.ResumeLayout(false);
            this.reminderPn.PerformLayout();
            this.UpdatePn.ResumeLayout(false);
            this.UpdatePn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rCountsUpDown)).EndInit();
            this.tablelayoutpn1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Button Aboutbtn;
        private System.Windows.Forms.Panel reminderPn;
        private System.Windows.Forms.Label NewReminderlbl;
        private System.Windows.Forms.Panel UpdatePn;
        private System.Windows.Forms.Label updatelbl;
        private System.Windows.Forms.DateTimePicker ReminderDateSelct;
        private System.Windows.Forms.NumericUpDown rCountsUpDown;
        private System.Windows.Forms.TextBox rTimeText;
        private System.Windows.Forms.Label rRepeatlbl;
        private System.Windows.Forms.Label reminderTimelbl;
        private System.Windows.Forms.TextBox rNameText;
        private System.Windows.Forms.Label reminderlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button RecBtn;
        private System.Windows.Forms.Label optionslbl;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label remindertltlelbl;
        private System.Windows.Forms.TextBox reminderText;
        private System.Windows.Forms.TableLayoutPanel tablelayoutpn1;
        private System.Windows.Forms.Button newDelbtn;
        private System.Windows.Forms.Button newCreatebtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Detailslbl;
    }
}

