namespace Subsidized_Fueling_System
{
    partial class Display_info
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.category_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.video_list_combobox = new System.Windows.Forms.ComboBox();
            this.log_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.video_input = new System.Windows.Forms.Label();
            this.start_video = new System.Windows.Forms.Button();
            this.thread_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 263);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // category_textbox
            // 
            this.category_textbox.Location = new System.Drawing.Point(617, 110);
            this.category_textbox.Name = "category_textbox";
            this.category_textbox.Size = new System.Drawing.Size(141, 20);
            this.category_textbox.TabIndex = 1;
            // 
            // price_textbox
            // 
            this.price_textbox.Location = new System.Drawing.Point(617, 179);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(141, 20);
            this.price_textbox.TabIndex = 2;
            // 
            // video_list_combobox
            // 
            this.video_list_combobox.FormattingEnabled = true;
            this.video_list_combobox.Location = new System.Drawing.Point(35, 49);
            this.video_list_combobox.Name = "video_list_combobox";
            this.video_list_combobox.Size = new System.Drawing.Size(154, 21);
            this.video_list_combobox.TabIndex = 3;
            // 
            // log_btn
            // 
            this.log_btn.Location = new System.Drawing.Point(617, 312);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(141, 23);
            this.log_btn.TabIndex = 4;
            this.log_btn.Text = "Log";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(628, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // video_input
            // 
            this.video_input.AutoSize = true;
            this.video_input.Location = new System.Drawing.Point(41, 30);
            this.video_input.Name = "video_input";
            this.video_input.Size = new System.Drawing.Size(68, 13);
            this.video_input.TabIndex = 7;
            this.video_input.Text = "Input Source";
            // 
            // start_video
            // 
            this.start_video.Location = new System.Drawing.Point(330, 373);
            this.start_video.Name = "start_video";
            this.start_video.Size = new System.Drawing.Size(141, 23);
            this.start_video.TabIndex = 8;
            this.start_video.Text = "Start Video";
            this.start_video.UseVisualStyleBackColor = true;
            this.start_video.Click += new System.EventHandler(this.start_video_Click);
            // 
            // thread_btn
            // 
            this.thread_btn.Location = new System.Drawing.Point(617, 373);
            this.thread_btn.Name = "thread_btn";
            this.thread_btn.Size = new System.Drawing.Size(141, 23);
            this.thread_btn.TabIndex = 9;
            this.thread_btn.Text = "save frame";
            this.thread_btn.UseVisualStyleBackColor = true;
            this.thread_btn.Click += new System.EventHandler(this.thread_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(519, 202);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 107);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Display_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.thread_btn);
            this.Controls.Add(this.start_video);
            this.Controls.Add(this.video_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.video_list_combobox);
            this.Controls.Add(this.price_textbox);
            this.Controls.Add(this.category_textbox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Display_info";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Display_info_FormClosing);
            this.Load += new System.EventHandler(this.Display_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox category_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.ComboBox video_list_combobox;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label video_input;
        private System.Windows.Forms.Button start_video;
        private System.Windows.Forms.Button thread_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

