
namespace TimerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Time_List = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.PictureBox();
            this.start_hovered = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.stop_hovered = new System.Windows.Forms.PictureBox();
            this.pause = new System.Windows.Forms.PictureBox();
            this.pause_hovered = new System.Windows.Forms.PictureBox();
            this.flag = new System.Windows.Forms.PictureBox();
            this.flag_hovered = new System.Windows.Forms.PictureBox();
            this.hour_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minute_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.second_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_hovered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_hovered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_hovered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag_hovered)).BeginInit();
            this.SuspendLayout();
            // 
            // Time_List
            // 
            this.Time_List.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Time_List.AutoScroll = true;
            this.Time_List.BackColor = System.Drawing.Color.Transparent;
            this.Time_List.Location = new System.Drawing.Point(24, 291);
            this.Time_List.Name = "Time_List";
            this.Time_List.Size = new System.Drawing.Size(240, 288);
            this.Time_List.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-15, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 416);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start.BackgroundImage")));
            this.start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start.Location = new System.Drawing.Point(344, 353);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(150, 150);
            this.start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start.TabIndex = 12;
            this.start.TabStop = false;
            this.start.MouseEnter += new System.EventHandler(this.start_MouseEnter);
            // 
            // start_hovered
            // 
            this.start_hovered.BackColor = System.Drawing.Color.Transparent;
            this.start_hovered.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start_hovered.BackgroundImage")));
            this.start_hovered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_hovered.Location = new System.Drawing.Point(344, 353);
            this.start_hovered.Name = "start_hovered";
            this.start_hovered.Size = new System.Drawing.Size(150, 150);
            this.start_hovered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start_hovered.TabIndex = 13;
            this.start_hovered.TabStop = false;
            this.start_hovered.Visible = false;
            this.start_hovered.MouseClick += new System.Windows.Forms.MouseEventHandler(this.start_hovered_MouseClick);
            this.start_hovered.MouseLeave += new System.EventHandler(this.start_hovered_MouseLeave);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.Location = new System.Drawing.Point(561, 353);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(150, 150);
            this.stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stop.TabIndex = 14;
            this.stop.TabStop = false;
            this.stop.MouseEnter += new System.EventHandler(this.stop_MouseEnter);
            // 
            // stop_hovered
            // 
            this.stop_hovered.BackColor = System.Drawing.Color.Transparent;
            this.stop_hovered.Image = ((System.Drawing.Image)(resources.GetObject("stop_hovered.Image")));
            this.stop_hovered.Location = new System.Drawing.Point(561, 353);
            this.stop_hovered.Name = "stop_hovered";
            this.stop_hovered.Size = new System.Drawing.Size(150, 150);
            this.stop_hovered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stop_hovered.TabIndex = 15;
            this.stop_hovered.TabStop = false;
            this.stop_hovered.Visible = false;
            this.stop_hovered.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stop_hovered_MouseClick);
            this.stop_hovered.MouseLeave += new System.EventHandler(this.stop_hovered_MouseLeave);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(344, 353);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(150, 150);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pause.TabIndex = 16;
            this.pause.TabStop = false;
            this.pause.Visible = false;
            this.pause.MouseEnter += new System.EventHandler(this.pause_MouseEnter);
            // 
            // pause_hovered
            // 
            this.pause_hovered.BackColor = System.Drawing.Color.Transparent;
            this.pause_hovered.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pause_hovered.BackgroundImage")));
            this.pause_hovered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause_hovered.Location = new System.Drawing.Point(344, 353);
            this.pause_hovered.Name = "pause_hovered";
            this.pause_hovered.Size = new System.Drawing.Size(150, 150);
            this.pause_hovered.TabIndex = 17;
            this.pause_hovered.TabStop = false;
            this.pause_hovered.Visible = false;
            this.pause_hovered.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pause_hovered_MouseClick);
            this.pause_hovered.MouseLeave += new System.EventHandler(this.pause_hovored_MouseLeave);
            // 
            // flag
            // 
            this.flag.BackColor = System.Drawing.Color.Transparent;
            this.flag.Image = ((System.Drawing.Image)(resources.GetObject("flag.Image")));
            this.flag.InitialImage = null;
            this.flag.Location = new System.Drawing.Point(283, 230);
            this.flag.Name = "flag";
            this.flag.Size = new System.Drawing.Size(109, 78);
            this.flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flag.TabIndex = 18;
            this.flag.TabStop = false;
            this.flag.Visible = false;
            this.flag.MouseEnter += new System.EventHandler(this.flag_MouseEnter);
            // 
            // flag_hovered
            // 
            this.flag_hovered.BackColor = System.Drawing.Color.Transparent;
            this.flag_hovered.Image = ((System.Drawing.Image)(resources.GetObject("flag_hovered.Image")));
            this.flag_hovered.InitialImage = null;
            this.flag_hovered.Location = new System.Drawing.Point(283, 230);
            this.flag_hovered.Name = "flag_hovered";
            this.flag_hovered.Size = new System.Drawing.Size(109, 78);
            this.flag_hovered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flag_hovered.TabIndex = 19;
            this.flag_hovered.TabStop = false;
            this.flag_hovered.Visible = false;
            this.flag_hovered.Click += new System.EventHandler(this.flag_hovered_Click);
            this.flag_hovered.MouseLeave += new System.EventHandler(this.flag_hovered_MouseLeave);
            // 
            // hour_lbl
            // 
            this.hour_lbl.BackColor = System.Drawing.Color.Transparent;
            this.hour_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hour_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hour_lbl.Image = ((System.Drawing.Image)(resources.GetObject("hour_lbl.Image")));
            this.hour_lbl.Location = new System.Drawing.Point(66, 33);
            this.hour_lbl.Name = "hour_lbl";
            this.hour_lbl.Size = new System.Drawing.Size(178, 167);
            this.hour_lbl.TabIndex = 27;
            this.hour_lbl.Text = "00";
            this.hour_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(233, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 101);
            this.label2.TabIndex = 28;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minute_lbl
            // 
            this.minute_lbl.BackColor = System.Drawing.Color.Transparent;
            this.minute_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minute_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minute_lbl.Image = ((System.Drawing.Image)(resources.GetObject("minute_lbl.Image")));
            this.minute_lbl.Location = new System.Drawing.Point(271, 32);
            this.minute_lbl.Name = "minute_lbl";
            this.minute_lbl.Size = new System.Drawing.Size(178, 167);
            this.minute_lbl.TabIndex = 30;
            this.minute_lbl.Text = "00";
            this.minute_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(434, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 101);
            this.label1.TabIndex = 31;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // second_lbl
            // 
            this.second_lbl.BackColor = System.Drawing.Color.Transparent;
            this.second_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.second_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.second_lbl.Image = ((System.Drawing.Image)(resources.GetObject("second_lbl.Image")));
            this.second_lbl.Location = new System.Drawing.Point(483, 33);
            this.second_lbl.Name = "second_lbl";
            this.second_lbl.Size = new System.Drawing.Size(178, 167);
            this.second_lbl.TabIndex = 29;
            this.second_lbl.Text = "00";
            this.second_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(748, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hour_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flag_hovered);
            this.Controls.Add(this.flag);
            this.Controls.Add(this.start);
            this.Controls.Add(this.Time_List);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start_hovered);
            this.Controls.Add(this.pause_hovered);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.stop_hovered);
            this.Controls.Add(this.minute_lbl);
            this.Controls.Add(this.second_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_hovered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop_hovered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pause_hovered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flag_hovered)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel Time_List;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox start;
        private System.Windows.Forms.PictureBox start_hovered;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.PictureBox stop_hovered;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox pause_hovered;
        private System.Windows.Forms.PictureBox flag;
        private System.Windows.Forms.PictureBox flag_hovered;
        private System.Windows.Forms.Label hour_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minute_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label second_lbl;
        private System.Windows.Forms.Timer timer1;
    }
}

