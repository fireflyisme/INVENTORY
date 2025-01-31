namespace FirstProgram1
{
    partial class Form2
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
            textBoxName = new TextBox();
            textBoxProgram = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Location = new Point(316, 186);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(349, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxProgram
            // 
            textBoxProgram.Anchor = AnchorStyles.None;
            textBoxProgram.Location = new Point(316, 259);
            textBoxProgram.Name = "textBoxProgram";
            textBoxProgram.Size = new Size(349, 27);
            textBoxProgram.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 412);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 38);
            panel2.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(textBoxProgram);
            Controls.Add(textBoxName);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Second Form";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxProgram;
        private Panel panel1;
        private Panel panel2;
    }
}