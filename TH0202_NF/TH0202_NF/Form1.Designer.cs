namespace TH0202_NF
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
            lbl_01 = new Label();
            tb_01 = new TextBox();
            tb_02 = new TextBox();
            lbl_02 = new Label();
            tb_03 = new TextBox();
            lbl_03 = new Label();
            tb_04 = new TextBox();
            lbl_04 = new Label();
            tb_05 = new TextBox();
            lbl_05 = new Label();
            lbl_06 = new Label();
            lbl_07 = new Label();
            button1 = new Button();
            lbl_08 = new Label();
            lbl_09 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_01
            // 
            lbl_01.AutoSize = true;
            lbl_01.Location = new Point(44, 60);
            lbl_01.Name = "lbl_01";
            lbl_01.Size = new Size(76, 20);
            lbl_01.TabIndex = 0;
            lbl_01.Text = "First Word";
            // 
            // tb_01
            // 
            tb_01.Location = new Point(126, 57);
            tb_01.Name = "tb_01";
            tb_01.Size = new Size(125, 27);
            tb_01.TabIndex = 1;
            tb_01.TextChanged += tb_01_TextChanged;
            // 
            // tb_02
            // 
            tb_02.Location = new Point(126, 90);
            tb_02.Name = "tb_02";
            tb_02.Size = new Size(125, 27);
            tb_02.TabIndex = 3;
            tb_02.TextChanged += tb_02_TextChanged;
            // 
            // lbl_02
            // 
            lbl_02.AutoSize = true;
            lbl_02.Location = new Point(22, 93);
            lbl_02.Name = "lbl_02";
            lbl_02.Size = new Size(98, 20);
            lbl_02.TabIndex = 2;
            lbl_02.Text = "Second Word";
            // 
            // tb_03
            // 
            tb_03.Location = new Point(126, 123);
            tb_03.Name = "tb_03";
            tb_03.Size = new Size(125, 27);
            tb_03.TabIndex = 5;
            tb_03.TextChanged += tb_03_TextChanged;
            // 
            // lbl_03
            // 
            lbl_03.AutoSize = true;
            lbl_03.Location = new Point(37, 126);
            lbl_03.Name = "lbl_03";
            lbl_03.Size = new Size(83, 20);
            lbl_03.TabIndex = 4;
            lbl_03.Text = "Third Word";
            // 
            // tb_04
            // 
            tb_04.Location = new Point(126, 156);
            tb_04.Name = "tb_04";
            tb_04.Size = new Size(125, 27);
            tb_04.TabIndex = 7;
            tb_04.TextChanged += tb_04_TextChanged;
            // 
            // lbl_04
            // 
            lbl_04.AutoSize = true;
            lbl_04.Location = new Point(29, 159);
            lbl_04.Name = "lbl_04";
            lbl_04.Size = new Size(91, 20);
            lbl_04.TabIndex = 6;
            lbl_04.Text = "Fourth Word";
            // 
            // tb_05
            // 
            tb_05.Location = new Point(126, 189);
            tb_05.Name = "tb_05";
            tb_05.Size = new Size(125, 27);
            tb_05.TabIndex = 9;
            tb_05.TextChanged += tb_05_TextChanged;
            // 
            // lbl_05
            // 
            lbl_05.AutoSize = true;
            lbl_05.Location = new Point(42, 192);
            lbl_05.Name = "lbl_05";
            lbl_05.Size = new Size(78, 20);
            lbl_05.TabIndex = 8;
            lbl_05.Text = "Fifth Word";
            // 
            // lbl_06
            // 
            lbl_06.AutoSize = true;
            lbl_06.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_06.Location = new Point(364, 9);
            lbl_06.Name = "lbl_06";
            lbl_06.Size = new Size(66, 35);
            lbl_06.TabIndex = 10;
            lbl_06.Text = "Rules";
            // 
            // lbl_07
            // 
            lbl_07.AutoSize = true;
            lbl_07.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_07.Location = new Point(270, 64);
            lbl_07.Name = "lbl_07";
            lbl_07.Size = new Size(256, 23);
            lbl_07.TabIndex = 11;
            lbl_07.Text = "* None of the words can be identical";
            // 
            // button1
            // 
            button1.Location = new Point(126, 231);
            button1.Name = "button1";
            button1.Size = new Size(125, 42);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_08
            // 
            lbl_08.AutoSize = true;
            lbl_08.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_08.Location = new Point(270, 94);
            lbl_08.Name = "lbl_08";
            lbl_08.Size = new Size(478, 23);
            lbl_08.TabIndex = 13;
            lbl_08.Text = "* Game cannot be started unless all 5 TextBox are filled with a word.";
            // 
            // lbl_09
            // 
            lbl_09.AutoSize = true;
            lbl_09.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_09.Location = new Point(270, 123);
            lbl_09.Name = "lbl_09";
            lbl_09.Size = new Size(452, 23);
            lbl_09.TabIndex = 14;
            lbl_09.Text = "* Words must be 5 letters, and cannot go beyond nor less of that.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 156);
            label1.Name = "label1";
            label1.Size = new Size(359, 23);
            label1.TabIndex = 15;
            label1.Text = "* Words must be not contain Symbols nor Numbers.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 306);
            Controls.Add(label1);
            Controls.Add(lbl_09);
            Controls.Add(lbl_08);
            Controls.Add(button1);
            Controls.Add(lbl_07);
            Controls.Add(lbl_06);
            Controls.Add(tb_05);
            Controls.Add(lbl_05);
            Controls.Add(tb_04);
            Controls.Add(lbl_04);
            Controls.Add(tb_03);
            Controls.Add(lbl_03);
            Controls.Add(tb_02);
            Controls.Add(lbl_02);
            Controls.Add(tb_01);
            Controls.Add(lbl_01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_01;
        private TextBox tb_01;
        private TextBox tb_02;
        private Label lbl_02;
        private TextBox tb_03;
        private Label lbl_03;
        private TextBox tb_04;
        private Label lbl_04;
        private TextBox tb_05;
        private Label lbl_05;
        private Label lbl_06;
        private Label lbl_07;
        private Button button1;
        private Label lbl_08;
        private Label lbl_09;
        private Label label1;
    }
}
