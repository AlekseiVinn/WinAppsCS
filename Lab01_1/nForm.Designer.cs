namespace Lab01_1
{
    partial class nForm
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
            /*if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);*/
            if (nClose)
            {
                base.Dispose(disposing);
            }
            else
                Hide();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkboxClose = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // checkboxClose
            // 
            checkboxClose.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkboxClose.AutoSize = true;
            checkboxClose.Location = new Point(327, 292);
            checkboxClose.Name = "checkboxClose";
            checkboxClose.Size = new Size(143, 19);
            checkboxClose.TabIndex = 0;
            checkboxClose.Text = "Close, like, really close";
            checkboxClose.UseVisualStyleBackColor = true;
            checkboxClose.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(327, 115);
            button1.Name = "button1";
            button1.Size = new Size(143, 23);
            button1.TabIndex = 1;
            button1.Text = "Close like hell";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(checkboxClose);
            Name = "nForm";
            Text = "nForm";
            Load += nForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkboxClose;
        private Button button1;
    }
}