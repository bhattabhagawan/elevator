using System;

namespace Elevator
{
    partial class Elevator 
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elevator));
            this.lift = new System.Windows.Forms.PictureBox();
            this.ldr = new System.Windows.Forms.PictureBox();
            this.ldl = new System.Windows.Forms.PictureBox();
            this.lur = new System.Windows.Forms.PictureBox();
            this.lul = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.alarm1 = new System.Windows.Forms.PictureBox();
            this.alarm = new System.Windows.Forms.PictureBox();
            this.up = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.PictureBox();
            this.oup = new System.Windows.Forms.PictureBox();
            this.odown = new System.Windows.Forms.PictureBox();
            this.cdown = new System.Windows.Forms.PictureBox();
            this.cup = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.t2 = new System.Windows.Forms.Timer(this.components);
            this.t3 = new System.Windows.Forms.Timer(this.components);
            this.t4 = new System.Windows.Forms.Timer(this.components);
            this.t5 = new System.Windows.Forms.Timer(this.components);
            this.t6 = new System.Windows.Forms.Timer(this.components);
            this.database_listbox = new System.Windows.Forms.ListBox();
            this.first = new System.Windows.Forms.TextBox();
            this.ground = new System.Windows.Forms.TextBox();
            this.middle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cup)).BeginInit();
            this.SuspendLayout();
            // 
            // lift
            // 
            this.lift.Image = ((System.Drawing.Image)(resources.GetObject("lift.Image")));
            this.lift.Location = new System.Drawing.Point(47, 310);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(142, 230);
            this.lift.TabIndex = 10;
            this.lift.TabStop = false;
            // 
            // ldr
            // 
            this.ldr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ldr.BackgroundImage")));
            this.ldr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ldr.Location = new System.Drawing.Point(121, 310);
            this.ldr.Name = "ldr";
            this.ldr.Size = new System.Drawing.Size(70, 230);
            this.ldr.TabIndex = 14;
            this.ldr.TabStop = false;
            this.ldr.Click += new System.EventHandler(this.ldr_Click);
            // 
            // ldl
            // 
            this.ldl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ldl.BackgroundImage")));
            this.ldl.Location = new System.Drawing.Point(47, 310);
            this.ldl.Name = "ldl";
            this.ldl.Size = new System.Drawing.Size(77, 230);
            this.ldl.TabIndex = 13;
            this.ldl.TabStop = false;
            // 
            // lur
            // 
            this.lur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lur.BackgroundImage")));
            this.lur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lur.Location = new System.Drawing.Point(121, 28);
            this.lur.Name = "lur";
            this.lur.Size = new System.Drawing.Size(70, 230);
            this.lur.TabIndex = 12;
            this.lur.TabStop = false;
            this.lur.Click += new System.EventHandler(this.lur_Click);
            // 
            // lul
            // 
            this.lul.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lul.BackgroundImage")));
            this.lul.Location = new System.Drawing.Point(47, 28);
            this.lul.Name = "lul";
            this.lul.Size = new System.Drawing.Size(77, 230);
            this.lul.TabIndex = 11;
            this.lul.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox5.Location = new System.Drawing.Point(1, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(396, 559);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 559);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 540);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // alarm1
            // 
            this.alarm1.BackColor = System.Drawing.Color.White;
            this.alarm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alarm1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarm1.Image = ((System.Drawing.Image)(resources.GetObject("alarm1.Image")));
            this.alarm1.Location = new System.Drawing.Point(273, 184);
            this.alarm1.Name = "alarm1";
            this.alarm1.Size = new System.Drawing.Size(36, 35);
            this.alarm1.TabIndex = 25;
            this.alarm1.TabStop = false;
            this.alarm1.Click += new System.EventHandler(this.alarm1_Click);
            // 
            // alarm
            // 
            this.alarm.BackColor = System.Drawing.Color.White;
            this.alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alarm.Image = ((System.Drawing.Image)(resources.GetObject("alarm.Image")));
            this.alarm.Location = new System.Drawing.Point(273, 467);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(36, 35);
            this.alarm.TabIndex = 24;
            this.alarm.TabStop = false;
            this.alarm.Click += new System.EventHandler(this.alarm_Click);
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.White;
            this.up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.up.Image = ((System.Drawing.Image)(resources.GetObject("up.Image")));
            this.up.Location = new System.Drawing.Point(274, 344);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(36, 35);
            this.up.TabIndex = 23;
            this.up.TabStop = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.White;
            this.down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.down.Image = ((System.Drawing.Image)(resources.GetObject("down.Image")));
            this.down.Location = new System.Drawing.Point(274, 61);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(36, 35);
            this.down.TabIndex = 22;
            this.down.TabStop = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // oup
            // 
            this.oup.BackColor = System.Drawing.Color.White;
            this.oup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.oup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oup.Image = ((System.Drawing.Image)(resources.GetObject("oup.Image")));
            this.oup.Location = new System.Drawing.Point(274, 144);
            this.oup.Name = "oup";
            this.oup.Size = new System.Drawing.Size(36, 35);
            this.oup.TabIndex = 21;
            this.oup.TabStop = false;
            this.oup.Click += new System.EventHandler(this.oup_Click);
            // 
            // odown
            // 
            this.odown.BackColor = System.Drawing.Color.White;
            this.odown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.odown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odown.Image = ((System.Drawing.Image)(resources.GetObject("odown.Image")));
            this.odown.Location = new System.Drawing.Point(274, 427);
            this.odown.Name = "odown";
            this.odown.Size = new System.Drawing.Size(36, 35);
            this.odown.TabIndex = 20;
            this.odown.TabStop = false;
            this.odown.Click += new System.EventHandler(this.odown_Click);
            // 
            // cdown
            // 
            this.cdown.BackColor = System.Drawing.Color.White;
            this.cdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cdown.Image = ((System.Drawing.Image)(resources.GetObject("cdown.Image")));
            this.cdown.Location = new System.Drawing.Point(274, 386);
            this.cdown.Name = "cdown";
            this.cdown.Size = new System.Drawing.Size(36, 35);
            this.cdown.TabIndex = 19;
            this.cdown.TabStop = false;
            this.cdown.Click += new System.EventHandler(this.cdown_Click);
            // 
            // cup
            // 
            this.cup.BackColor = System.Drawing.Color.White;
            this.cup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cup.Image = ((System.Drawing.Image)(resources.GetObject("cup.Image")));
            this.cup.Location = new System.Drawing.Point(274, 103);
            this.cup.Name = "cup";
            this.cup.Size = new System.Drawing.Size(36, 35);
            this.cup.TabIndex = 18;
            this.cup.TabStop = false;
            this.cup.Click += new System.EventHandler(this.cup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Event Log";
            // 
            // t1
            // 
            this.t1.Interval = 5;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // t2
            // 
            this.t2.Interval = 5;
            this.t2.Tick += new System.EventHandler(this.t2_Tick);
            // 
            // t3
            // 
            this.t3.Interval = 5;
            this.t3.Tick += new System.EventHandler(this.t3_Tick);
            // 
            // t4
            // 
            this.t4.Interval = 5;
            this.t4.Tick += new System.EventHandler(this.t4_Tick);
            // 
            // t5
            // 
            this.t5.Interval = 5;
            this.t5.Tick += new System.EventHandler(this.t5_Tick);
            // 
            // t6
            // 
            this.t6.Interval = 5;
            this.t6.Tick += new System.EventHandler(this.t6_Tick);
            // 
            // database_listbox
            // 
            this.database_listbox.FormattingEnabled = true;
            this.database_listbox.Location = new System.Drawing.Point(403, 30);
            this.database_listbox.Name = "database_listbox";
            this.database_listbox.Size = new System.Drawing.Size(451, 511);
            this.database_listbox.TabIndex = 28;
            // 
            // first
            // 
            this.first.BackColor = System.Drawing.SystemColors.InfoText;
            this.first.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.ForeColor = System.Drawing.Color.Red;
            this.first.Location = new System.Drawing.Point(105, 17);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(29, 15);
            this.first.TabIndex = 30;
            this.first.Text = "1";
            this.first.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.SystemColors.InfoText;
            this.ground.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ground.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ground.ForeColor = System.Drawing.Color.Red;
            this.ground.Location = new System.Drawing.Point(104, 298);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(29, 15);
            this.ground.TabIndex = 31;
            this.ground.Text = "G";
            this.ground.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // middle
            // 
            this.middle.BackColor = System.Drawing.SystemColors.InfoText;
            this.middle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.middle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middle.ForeColor = System.Drawing.Color.Red;
            this.middle.Location = new System.Drawing.Point(273, 268);
            this.middle.Name = "middle";
            this.middle.Size = new System.Drawing.Size(46, 24);
            this.middle.TabIndex = 32;
            this.middle.Text = "G";
            this.middle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(858, 541);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.first);
            this.Controls.Add(this.database_listbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alarm1);
            this.Controls.Add(this.alarm);
            this.Controls.Add(this.up);
            this.Controls.Add(this.down);
            this.Controls.Add(this.oup);
            this.Controls.Add(this.odown);
            this.Controls.Add(this.cdown);
            this.Controls.Add(this.cup);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ldr);
            this.Controls.Add(this.ldl);
            this.Controls.Add(this.lur);
            this.Controls.Add(this.lul);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Elevator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ldl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ldr_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lur_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox lift;
        private System.Windows.Forms.PictureBox ldr;
        private System.Windows.Forms.PictureBox ldl;
        private System.Windows.Forms.PictureBox lur;
        private System.Windows.Forms.PictureBox lul;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox alarm1;
        private System.Windows.Forms.PictureBox alarm;
        private System.Windows.Forms.PictureBox up;
        private System.Windows.Forms.PictureBox down;
        private System.Windows.Forms.PictureBox oup;
        private System.Windows.Forms.PictureBox odown;
        private System.Windows.Forms.PictureBox cdown;
        private System.Windows.Forms.PictureBox cup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.Timer t2;
        private System.Windows.Forms.Timer t3;
        private System.Windows.Forms.Timer t4;
        private System.Windows.Forms.Timer t5;
        private System.Windows.Forms.Timer t6;
        private System.Windows.Forms.ListBox database_listbox;
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox ground;
        private System.Windows.Forms.TextBox middle;
    }
}

