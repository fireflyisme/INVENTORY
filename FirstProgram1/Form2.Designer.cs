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
            textBoxProgramName = new MaterialSkin.Controls.MaterialTextBox2();
            textBoxProgramDescription = new MaterialSkin.Controls.MaterialTextBox2();
            textBoxProgramDepartment = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.AnimateReadOnly = false;
            textBoxProgramName.BackgroundImageLayout = ImageLayout.None;
            textBoxProgramName.CharacterCasing = CharacterCasing.Normal;
            textBoxProgramName.Depth = 0;
            textBoxProgramName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxProgramName.HideSelection = true;
            textBoxProgramName.Hint = "Enter program name";
            textBoxProgramName.LeadingIcon = null;
            textBoxProgramName.Location = new Point(95, 143);
            textBoxProgramName.MaxLength = 32767;
            textBoxProgramName.MouseState = MaterialSkin.MouseState.OUT;
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.PasswordChar = '\0';
            textBoxProgramName.PrefixSuffixText = null;
            textBoxProgramName.ReadOnly = false;
            textBoxProgramName.RightToLeft = RightToLeft.No;
            textBoxProgramName.SelectedText = "";
            textBoxProgramName.SelectionLength = 0;
            textBoxProgramName.SelectionStart = 0;
            textBoxProgramName.ShortcutsEnabled = true;
            textBoxProgramName.Size = new Size(312, 48);
            textBoxProgramName.TabIndex = 0;
            textBoxProgramName.TabStop = false;
            textBoxProgramName.TextAlign = HorizontalAlignment.Left;
            textBoxProgramName.TrailingIcon = null;
            textBoxProgramName.UseSystemPasswordChar = false;
            // 
            // textBoxProgramDescription
            // 
            textBoxProgramDescription.AnimateReadOnly = false;
            textBoxProgramDescription.BackgroundImageLayout = ImageLayout.None;
            textBoxProgramDescription.CharacterCasing = CharacterCasing.Normal;
            textBoxProgramDescription.Depth = 0;
            textBoxProgramDescription.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxProgramDescription.HideSelection = true;
            textBoxProgramDescription.Hint = "Enter program description";
            textBoxProgramDescription.LeadingIcon = null;
            textBoxProgramDescription.Location = new Point(95, 239);
            textBoxProgramDescription.MaxLength = 32767;
            textBoxProgramDescription.MouseState = MaterialSkin.MouseState.OUT;
            textBoxProgramDescription.Name = "textBoxProgramDescription";
            textBoxProgramDescription.PasswordChar = '\0';
            textBoxProgramDescription.PrefixSuffixText = null;
            textBoxProgramDescription.ReadOnly = false;
            textBoxProgramDescription.RightToLeft = RightToLeft.No;
            textBoxProgramDescription.SelectedText = "";
            textBoxProgramDescription.SelectionLength = 0;
            textBoxProgramDescription.SelectionStart = 0;
            textBoxProgramDescription.ShortcutsEnabled = true;
            textBoxProgramDescription.Size = new Size(312, 48);
            textBoxProgramDescription.TabIndex = 1;
            textBoxProgramDescription.TabStop = false;
            textBoxProgramDescription.TextAlign = HorizontalAlignment.Left;
            textBoxProgramDescription.TrailingIcon = null;
            textBoxProgramDescription.UseSystemPasswordChar = false;
            // 
            // textBoxProgramDepartment
            // 
            textBoxProgramDepartment.AnimateReadOnly = false;
            textBoxProgramDepartment.BackgroundImageLayout = ImageLayout.None;
            textBoxProgramDepartment.CharacterCasing = CharacterCasing.Normal;
            textBoxProgramDepartment.Depth = 0;
            textBoxProgramDepartment.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxProgramDepartment.HideSelection = true;
            textBoxProgramDepartment.Hint = "Enter program department";
            textBoxProgramDepartment.LeadingIcon = null;
            textBoxProgramDepartment.Location = new Point(95, 335);
            textBoxProgramDepartment.MaxLength = 32767;
            textBoxProgramDepartment.MouseState = MaterialSkin.MouseState.OUT;
            textBoxProgramDepartment.Name = "textBoxProgramDepartment";
            textBoxProgramDepartment.PasswordChar = '\0';
            textBoxProgramDepartment.PrefixSuffixText = null;
            textBoxProgramDepartment.ReadOnly = false;
            textBoxProgramDepartment.RightToLeft = RightToLeft.No;
            textBoxProgramDepartment.SelectedText = "";
            textBoxProgramDepartment.SelectionLength = 0;
            textBoxProgramDepartment.SelectionStart = 0;
            textBoxProgramDepartment.ShortcutsEnabled = true;
            textBoxProgramDepartment.Size = new Size(312, 48);
            textBoxProgramDepartment.TabIndex = 2;
            textBoxProgramDepartment.TabStop = false;
            textBoxProgramDepartment.TextAlign = HorizontalAlignment.Left;
            textBoxProgramDepartment.TrailingIcon = null;
            textBoxProgramDepartment.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(172, 423);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(64, 36);
            materialButton1.TabIndex = 3;
            materialButton1.Text = "SAVE";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(253, 423);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "DELETE";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += materialButton2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 514);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(textBoxProgramDepartment);
            Controls.Add(textBoxProgramDescription);
            Controls.Add(textBoxProgramName);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Program Details";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        public MaterialSkin.Controls.MaterialTextBox2 textBoxProgramName;
        public MaterialSkin.Controls.MaterialTextBox2 textBoxProgramDescription;
        public MaterialSkin.Controls.MaterialTextBox2 textBoxProgramDepartment;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}