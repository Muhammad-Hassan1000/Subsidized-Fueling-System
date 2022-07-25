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
            System.Windows.Forms.Button log_btn;
            System.Windows.Forms.Button save_btn;
            System.Windows.Forms.Button start_btn;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.category_textbox = new System.Windows.Forms.TextBox();
            this.price_textbox = new System.Windows.Forms.TextBox();
            this.video_list_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.video_input = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            log_btn = new System.Windows.Forms.Button();
            save_btn = new System.Windows.Forms.Button();
            start_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // category_textbox
            // 
            this.category_textbox.Enabled = false;
            this.category_textbox.Location = new System.Drawing.Point(3, 32);
            this.category_textbox.Name = "category_textbox";
            this.category_textbox.Size = new System.Drawing.Size(129, 20);
            this.category_textbox.TabIndex = 4;
            this.category_textbox.TextChanged += new System.EventHandler(this.category_textbox_TextChanged);
            // 
            // price_textbox
            // 
            this.price_textbox.Enabled = false;
            this.price_textbox.Location = new System.Drawing.Point(3, 138);
            this.price_textbox.Name = "price_textbox";
            this.price_textbox.Size = new System.Drawing.Size(129, 20);
            this.price_textbox.TabIndex = 3;
            // 
            // video_list_combobox
            // 
            this.video_list_combobox.FormattingEnabled = true;
            this.video_list_combobox.Location = new System.Drawing.Point(109, 33);
            this.video_list_combobox.Name = "video_list_combobox";
            this.video_list_combobox.Size = new System.Drawing.Size(154, 21);
            this.video_list_combobox.TabIndex = 0;
            // 
            // log_btn
            // 
            log_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(10)))));
            log_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            log_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            log_btn.ForeColor = System.Drawing.SystemColors.Control;
            log_btn.Location = new System.Drawing.Point(3, 215);
            log_btn.Name = "log_btn";
            log_btn.Size = new System.Drawing.Size(129, 23);
            log_btn.TabIndex = 2;
            log_btn.Text = "Log";
            log_btn.UseVisualStyleBackColor = true;
            log_btn.Visible = false;
            log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // video_input
            // 
            this.video_input.AutoSize = true;
            this.video_input.ForeColor = System.Drawing.SystemColors.Control;
            this.video_input.Location = new System.Drawing.Point(115, 14);
            this.video_input.Name = "video_input";
            this.video_input.Size = new System.Drawing.Size(68, 13);
            this.video_input.TabIndex = 7;
            this.video_input.Text = "Input Source";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(start_btn, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.price_textbox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(log_btn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.category_textbox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(save_btn, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(796, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.65742F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.65742F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(135, 445);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // save_btn
            // 
            save_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(10)))));
            save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            save_btn.ForeColor = System.Drawing.SystemColors.Control;
            save_btn.Location = new System.Drawing.Point(3, 292);
            save_btn.Name = "save_btn";
            save_btn.Size = new System.Drawing.Size(129, 23);
            save_btn.TabIndex = 1;
            save_btn.Text = "save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(934, 523);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // start_btn
            // 
            start_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(4)))), ((int)(((byte)(10)))));
            start_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            start_btn.ForeColor = System.Drawing.SystemColors.Control;
            start_btn.Location = new System.Drawing.Point(3, 369);
            start_btn.Name = "start_btn";
            start_btn.Size = new System.Drawing.Size(129, 23);
            start_btn.TabIndex = 0;
            start_btn.Text = "Start";
            start_btn.UseVisualStyleBackColor = true;
            start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // Display_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(4)))), ((int)(((byte)(8)))));
            this.ClientSize = new System.Drawing.Size(934, 599);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.video_input);
            this.Controls.Add(this.video_list_combobox);
            this.Name = "Display_info";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Display_info_FormClosing);
            this.Load += new System.EventHandler(this.Display_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox category_textbox;
        private System.Windows.Forms.TextBox price_textbox;
        private System.Windows.Forms.ComboBox video_list_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label video_input;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

