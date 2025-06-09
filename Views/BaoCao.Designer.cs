namespace QuanLySV.Views
{
    partial class BaoCao
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(447, 29);
            label1.Name = "label1";
            label1.Size = new Size(584, 86);
            label1.TabIndex = 1;
            label1.Text = "Báo cáo thống kê";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 185);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 2;
            label2.Text = "Chủ đề báo cáo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 285);
            label3.Name = "label3";
            label3.Size = new Size(306, 32);
            label3.TabIndex = 3;
            label3.Text = "Tóm tắt nội dung trình bày:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(499, 182);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(785, 39);
            textBox1.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(499, 282);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(785, 192);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(499, 570);
            button1.Name = "button1";
            button1.Size = new Size(282, 48);
            button1.TabIndex = 7;
            button1.Text = "Chọn File nộp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 578);
            label4.Name = "label4";
            label4.Size = new Size(165, 32);
            label4.TabIndex = 8;
            label4.Text = "Chọn file nộp:";
            // 
            // BaoCao
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 829);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BaoCao";
            Text = "BaoCao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label4;
    }
}