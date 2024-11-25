namespace Seeleim
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
            btnCircleArea = new Button();
            label1 = new Label();
            txtRaduis = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtHeight = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtWidth = new TextBox();
            label7 = new Label();
            txtHexagonWidth = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnTriangleArea = new Button();
            groupBox3 = new GroupBox();
            btn = new Button();
            lblResult = new Label();
            button4 = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(151, 89);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(93, 30);
            btnCircleArea.TabIndex = 0;
            btnCircleArea.Text = "คำนวณ";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Yellow;
            label1.Location = new Point(301, 20);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "เครื่องคำนวณหาพื้นที่";
            // 
            // txtRaduis
            // 
            txtRaduis.Location = new Point(104, 38);
            txtRaduis.Name = "txtRaduis";
            txtRaduis.Size = new Size(85, 27);
            txtRaduis.TabIndex = 2;
            txtRaduis.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 232);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(507, 94);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 5;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(104, 26);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(85, 27);
            txtHeight.TabIndex = 6;
            txtHeight.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 38);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 7;
            label5.Text = "รัศมีวงกลม";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 26);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 8;
            label6.Text = "ความสูง";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(103, 61);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(85, 27);
            txtWidth.TabIndex = 9;
            txtWidth.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 61);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 10;
            label7.Text = "ความยาวฐาน";
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.Location = new Point(117, 28);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(85, 27);
            txtHexagonWidth.TabIndex = 11;
            txtHexagonWidth.Text = "1";
            txtHexagonWidth.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 28);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 12;
            label8.Text = "ความยาวฐาน";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 128, 255);
            groupBox1.Controls.Add(txtRaduis);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(53, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณรัศมีวงกลม";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 128, 255);
            groupBox2.Controls.Add(btnTriangleArea);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtWidth);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(53, 250);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "หาพื้นที่สามเหลี่ยม";
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(150, 90);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(94, 29);
            btnTriangleArea.TabIndex = 11;
            btnTriangleArea.Text = "คำนวณ";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(128, 255, 255);
            groupBox3.Controls.Add(btn);
            groupBox3.Controls.Add(txtHexagonWidth);
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(439, 64);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 125);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "หาพื้นที่หกเหลี่ยมด้านเท่า";
            // 
            // btn
            // 
            btn.Location = new Point(150, 90);
            btn.Name = "btn";
            btn.Size = new Size(94, 29);
            btn.TabIndex = 13;
            btn.Text = "คำนวณ";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(128, 255, 128);
            lblResult.Location = new Point(439, 275);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(244, 100);
            lblResult.TabIndex = 16;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Location = new Point(653, 378);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 17;
            button4.Text = "ออก!";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 250);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 18;
            label2.Text = "พื้นที่(ตารางหน่วย)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(lblResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCircleArea;
        private Label label1;
        private TextBox txtRaduis;
        private Label label3;
        private Label label4;
        private TextBox txtHeight;
        private Label label5;
        private Label label6;
        private TextBox txtWidth;
        private Label label7;
        private TextBox txtHexagonWidth;
        private Label label8;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnTriangleArea;
        private GroupBox groupBox3;
        private Button btn;
        private Label lblResult;
        private Button button4;
        private Label label2;
    }
}
