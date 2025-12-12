namespace WinFormsArray
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            ok = new Button();
            lblnum = new Label();
            lblsum = new Label();
            lblavg = new Label();
            lblmax = new Label();
            lblmin = new Label();
            btnArray2d = new Button();
            tbxArray2d = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 86);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 51);
            label1.TabIndex = 0;
            label1.Text = "กรอกข้อมูลตัวเลข";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 186);
            textBox1.Margin = new Padding(6, 7, 6, 7);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(501, 707);
            textBox1.TabIndex = 1;
            // 
            // ok
            // 
            ok.Location = new Point(654, 243);
            ok.Margin = new Padding(6, 7, 6, 7);
            ok.Name = "ok";
            ok.Size = new Size(176, 71);
            ok.TabIndex = 2;
            ok.Text = "ประมวลผล";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(910, 243);
            lblnum.Margin = new Padding(6, 0, 6, 0);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(250, 51);
            lblnum.TabIndex = 3;
            lblnum.Text = "จำนวนสมาชิกข้อมูล";
            lblnum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsum
            // 
            lblsum.AutoSize = true;
            lblsum.Location = new Point(1058, 294);
            lblsum.Margin = new Padding(6, 0, 6, 0);
            lblsum.Name = "lblsum";
            lblsum.Size = new Size(102, 51);
            lblsum.TabIndex = 4;
            lblsum.Text = "ผลรวม";
            lblsum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblavg
            // 
            lblavg.AutoSize = true;
            lblavg.Location = new Point(1047, 354);
            lblavg.Margin = new Padding(6, 0, 6, 0);
            lblavg.Name = "lblavg";
            lblavg.Size = new Size(113, 51);
            lblavg.TabIndex = 5;
            lblavg.Text = "ค่าเฉลี่ย";
            lblavg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblmax
            // 
            lblmax.AutoSize = true;
            lblmax.Location = new Point(1041, 415);
            lblmax.Name = "lblmax";
            lblmax.Size = new Size(119, 51);
            lblmax.TabIndex = 8;
            lblmax.Text = "ค่าสูงสุด";
            // 
            // lblmin
            // 
            lblmin.AutoSize = true;
            lblmin.Location = new Point(1040, 479);
            lblmin.Name = "lblmin";
            lblmin.Size = new Size(120, 51);
            lblmin.TabIndex = 9;
            lblmin.Text = "ค่าต่ำสุด";
            // 
            // btnArray2d
            // 
            btnArray2d.Location = new Point(633, 354);
            btnArray2d.Name = "btnArray2d";
            btnArray2d.Size = new Size(243, 67);
            btnArray2d.TabIndex = 10;
            btnArray2d.Text = "ทดสอบArray 2 มิติ";
            btnArray2d.UseVisualStyleBackColor = true;
            btnArray2d.Click += btnArray2d_Click;
            // 
            // tbxArray2d
            // 
            tbxArray2d.Location = new Point(654, 610);
            tbxArray2d.Multiline = true;
            tbxArray2d.Name = "tbxArray2d";
            tbxArray2d.Size = new Size(708, 283);
            tbxArray2d.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 49F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1852, 1055);
            Controls.Add(tbxArray2d);
            Controls.Add(btnArray2d);
            Controls.Add(lblmin);
            Controls.Add(lblmax);
            Controls.Add(lblavg);
            Controls.Add(lblsum);
            Controls.Add(lblnum);
            Controls.Add(ok);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Chakra Petch", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button ok;
        private Label lblnum;
        private Label lblsum;
        private Label lblavg;
        private Label lblmax;
        private Label lblmin;
        private Button btnArray2d;
        private TextBox tbxArray2d;
    }
}
