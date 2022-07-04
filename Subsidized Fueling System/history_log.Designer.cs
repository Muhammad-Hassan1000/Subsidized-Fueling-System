namespace Subsidized_Fueling_System
{
    partial class history_log
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lower_date = new System.Windows.Forms.DateTimePicker();
            this.upper_date = new System.Windows.Forms.DateTimePicker();
            this.category_txt = new System.Windows.Forms.TextBox();
            this.lower_price = new System.Windows.Forms.TextBox();
            this.upper_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lower_date
            // 
            this.lower_date.Location = new System.Drawing.Point(154, 111);
            this.lower_date.Name = "lower_date";
            this.lower_date.Size = new System.Drawing.Size(200, 20);
            this.lower_date.TabIndex = 2;
            this.lower_date.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // upper_date
            // 
            this.upper_date.Location = new System.Drawing.Point(428, 111);
            this.upper_date.Name = "upper_date";
            this.upper_date.Size = new System.Drawing.Size(200, 20);
            this.upper_date.TabIndex = 3;
            // 
            // category_txt
            // 
            this.category_txt.Location = new System.Drawing.Point(154, 31);
            this.category_txt.Name = "category_txt";
            this.category_txt.Size = new System.Drawing.Size(476, 20);
            this.category_txt.TabIndex = 4;
            // 
            // lower_price
            // 
            this.lower_price.Location = new System.Drawing.Point(154, 71);
            this.lower_price.Name = "lower_price";
            this.lower_price.Size = new System.Drawing.Size(200, 20);
            this.lower_price.TabIndex = 6;
            // 
            // upper_price
            // 
            this.upper_price.Location = new System.Drawing.Point(430, 71);
            this.upper_price.Name = "upper_price";
            this.upper_price.Size = new System.Drawing.Size(200, 20);
            this.upper_price.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Till";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Till";
            // 
            // history_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upper_price);
            this.Controls.Add(this.lower_price);
            this.Controls.Add(this.category_txt);
            this.Controls.Add(this.upper_date);
            this.Controls.Add(this.lower_date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "history_log";
            this.Text = "history_log";
            this.Load += new System.EventHandler(this.history_log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker lower_date;
        private System.Windows.Forms.DateTimePicker upper_date;
        private System.Windows.Forms.TextBox category_txt;
        private System.Windows.Forms.TextBox lower_price;
        private System.Windows.Forms.TextBox upper_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}