namespace lekce_11_pocitadlo
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
            tlacitkoVlevo = new Button();
            tlacitkoVpravo = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tlacitkoVlevo
            // 
            tlacitkoVlevo.Location = new Point(98, 78);
            tlacitkoVlevo.Name = "tlacitkoVlevo";
            tlacitkoVlevo.Size = new Size(112, 34);
            tlacitkoVlevo.TabIndex = 0;
            tlacitkoVlevo.Text = "stiskni";
            tlacitkoVlevo.UseVisualStyleBackColor = true;
            tlacitkoVlevo.Click += tlacitkoVlevo_Click;
            // 
            // tlacitkoVpravo
            // 
            tlacitkoVpravo.Location = new Point(281, 81);
            tlacitkoVpravo.Name = "tlacitkoVpravo";
            tlacitkoVpravo.Size = new Size(112, 29);
            tlacitkoVpravo.TabIndex = 1;
            tlacitkoVpravo.Text = "stiskni ";
            tlacitkoVpravo.UseVisualStyleBackColor = true;
            tlacitkoVpravo.Click += tlacitkoVlevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 147);
            label1.Name = "label1";
            label1.Size = new Size(22, 25);
            label1.TabIndex = 2;
            label1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tlacitkoVpravo);
            Controls.Add(tlacitkoVlevo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tlacitkoVlevo;
        private Button tlacitkoVpravo;
        private Label label1;
    }
}
