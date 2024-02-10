namespace Eratosphen
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
            MaxValueA = new TextBox();
            label1 = new Label();
            btтA = new Button();
            richTextBoxA = new RichTextBox();
            richTextBoxB = new RichTextBox();
            btтB = new Button();
            label2 = new Label();
            MaxValueB = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            panelA = new Panel();
            panelB = new Panel();
            panelA.SuspendLayout();
            panelB.SuspendLayout();
            SuspendLayout();
            // 
            // MaxValueA
            // 
            MaxValueA.Location = new Point(121, 15);
            MaxValueA.Name = "MaxValueA";
            MaxValueA.Size = new Size(247, 23);
            MaxValueA.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите число А";
            // 
            // btтA
            // 
            btтA.AutoSize = true;
            btтA.Location = new Point(6, 60);
            btтA.Name = "btтA";
            btтA.Size = new Size(119, 25);
            btтA.TabIndex = 2;
            btтA.Text = "Вывести решето А";
            btтA.UseVisualStyleBackColor = true;
            btтA.Click += btтA_Click;
            // 
            // richTextBoxA
            // 
            richTextBoxA.Location = new Point(6, 91);
            richTextBoxA.Name = "richTextBoxA";
            richTextBoxA.Size = new Size(375, 333);
            richTextBoxA.TabIndex = 3;
            richTextBoxA.Text = "";
            // 
            // richTextBoxB
            // 
            richTextBoxB.Location = new Point(9, 91);
            richTextBoxB.Name = "richTextBoxB";
            richTextBoxB.ReadOnly = true;
            richTextBoxB.Size = new Size(375, 333);
            richTextBoxB.TabIndex = 7;
            richTextBoxB.Text = "";
            // 
            // btтB
            // 
            btтB.AutoSize = true;
            btтB.Location = new Point(12, 57);
            btтB.Name = "btтB";
            btтB.Size = new Size(118, 25);
            btтB.TabIndex = 6;
            btтB.Text = "Вывести решето В";
            btтB.UseVisualStyleBackColor = true;
            btтB.Click += btтB_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 15);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Введите число В";
            // 
            // MaxValueB
            // 
            MaxValueB.Location = new Point(120, 12);
            MaxValueB.Name = "MaxValueB";
            MaxValueB.Size = new Size(247, 23);
            MaxValueB.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(192, 483);
            button2.Name = "button2";
            button2.Size = new Size(75, 24);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 483);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 23);
            textBox2.TabIndex = 9;
            // 
            // panelA
            // 
            panelA.Controls.Add(btтA);
            panelA.Controls.Add(label1);
            panelA.Controls.Add(MaxValueA);
            panelA.Controls.Add(richTextBoxA);
            panelA.Location = new Point(10, 12);
            panelA.Name = "panelA";
            panelA.Size = new Size(387, 439);
            panelA.TabIndex = 10;
            // 
            // panelB
            // 
            panelB.Controls.Add(richTextBoxB);
            panelB.Controls.Add(btтB);
            panelB.Controls.Add(label2);
            panelB.Controls.Add(MaxValueB);
            panelB.Location = new Point(403, 12);
            panelB.Name = "panelB";
            panelB.Size = new Size(387, 440);
            panelB.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 546);
            Controls.Add(panelB);
            Controls.Add(panelA);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            panelA.ResumeLayout(false);
            panelA.PerformLayout();
            panelB.ResumeLayout(false);
            panelB.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MaxValueA;
        private Label label1;
        private Button btтA;
        private RichTextBox richTextBoxA;
        private RichTextBox richTextBoxB;
        private Button btтB;
        private Label label2;
        private TextBox MaxValueB;
        private Button button2;
        private TextBox textBox2;
        private Panel panelA;
        private Panel panelB;
    }
}
