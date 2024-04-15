namespace lekce_12
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
            label2 = new Label();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            checkBox1 = new CheckBox();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton7 = new RadioButton();
            radioButton6 = new RadioButton();
            button1 = new Button();
            label5 = new Label();
            labelOdpoved = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 64);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 0;
            label1.Text = "Jméno a Příjmení";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(255, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(325, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 108);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 2;
            label2.Text = "E-mail";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(255, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 31);
            textBox2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(255, 156);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(325, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(85, 158);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 5;
            label3.Text = "Telefonní číslo";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(94, 216);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(367, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Jsem ráda, že jsem se přihlásila na kurz c#";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(94, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 205);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nejtežší pro mě bylo";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(412, 31);
            textBox3.TabIndex = 20;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(6, 111);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(64, 29);
            radioButton5.TabIndex = 19;
            radioButton5.TabStop = true;
            radioButton5.Text = "jiné";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(209, 76);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(220, 29);
            radioButton4.TabIndex = 18;
            radioButton4.TabStop = true;
            radioButton4.Text = "udržet večer pozornost";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(209, 41);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(240, 29);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "udržovat kontinuitu kurzu";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 76);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(172, 29);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "najít čas na úkoly";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 41);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 15;
            label4.Click += label4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(168, 29);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "najít čas na lekce";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton7);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Location = new Point(94, 480);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 126);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preferuji semestr:";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(19, 87);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(112, 29);
            radioButton7.TabIndex = 1;
            radioButton7.TabStop = true;
            radioButton7.Text = "podzimní";
            radioButton7.UseVisualStyleBackColor = true;
            radioButton7.CheckedChanged += volbaSemestru;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(19, 43);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(70, 29);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "jarní";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += volbaSemestru;
            // 
            // button1
            // 
            button1.Location = new Point(165, 627);
            button1.Name = "button1";
            button1.Size = new Size(240, 34);
            button1.TabIndex = 16;
            button1.Text = "odeslat formulář";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(552, 636);
            label5.Name = "label5";
            label5.Size = new Size(127, 25);
            label5.TabIndex = 17;
            label5.Text = "Vaše odpověď";
            // 
            // labelOdpoved
            // 
            labelOdpoved.AutoSize = true;
            labelOdpoved.Location = new Point(703, 636);
            labelOdpoved.Name = "labelOdpoved";
            labelOdpoved.Size = new Size(83, 25);
            labelOdpoved.TabIndex = 18;
            labelOdpoved.Text = "neznámá";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 682);
            Controls.Add(labelOdpoved);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private CheckBox checkBox1;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label4;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton7;
        private RadioButton radioButton6;
        private Button button1;
        private Label label5;
        private Label labelOdpoved;
    }
}
