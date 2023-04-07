namespace PasswordGenerator
{
    partial class MainForm
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
            txtPassword = new TextBox();
            trkLength = new TrackBar();
            lblLength = new Label();
            chkSymbols = new CheckBox();
            chkLowercase = new CheckBox();
            chkUppercase = new CheckBox();
            chkNumbers = new CheckBox();
            btnGenerate = new Button();
            numLength = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)trkLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLength).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(12, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.Size = new Size(371, 33);
            txtPassword.TabIndex = 0;
            // 
            // trkLength
            // 
            trkLength.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            trkLength.Location = new Point(12, 89);
            trkLength.Maximum = 50;
            trkLength.Minimum = 1;
            trkLength.Name = "trkLength";
            trkLength.Size = new Size(320, 45);
            trkLength.TabIndex = 1;
            trkLength.Value = 1;
            trkLength.Scroll += trkLength_Scroll;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLength.Location = new Point(12, 65);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(104, 17);
            lblLength.TabIndex = 2;
            lblLength.Text = "Password length";
            // 
            // chkSymbols
            // 
            chkSymbols.AutoSize = true;
            chkSymbols.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkSymbols.Location = new Point(12, 140);
            chkSymbols.Name = "chkSymbols";
            chkSymbols.Size = new Size(199, 21);
            chkSymbols.TabIndex = 3;
            chkSymbols.Text = "Include symbols (e. g. @#$%)";
            chkSymbols.UseVisualStyleBackColor = true;
            // 
            // chkLowercase
            // 
            chkLowercase.AutoSize = true;
            chkLowercase.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkLowercase.Location = new Point(12, 194);
            chkLowercase.Name = "chkLowercase";
            chkLowercase.Size = new Size(290, 21);
            chkLowercase.TabIndex = 6;
            chkLowercase.Text = "Include lowercase characters (e. g. abcdefgh)";
            chkLowercase.UseVisualStyleBackColor = true;
            // 
            // chkUppercase
            // 
            chkUppercase.AutoSize = true;
            chkUppercase.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkUppercase.Location = new Point(12, 221);
            chkUppercase.Name = "chkUppercase";
            chkUppercase.Size = new Size(301, 21);
            chkUppercase.TabIndex = 8;
            chkUppercase.Text = "Include uppercase characters (e. g. ABCDEFGH)";
            chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            chkNumbers.AutoSize = true;
            chkNumbers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            chkNumbers.Location = new Point(12, 167);
            chkNumbers.Name = "chkNumbers";
            chkNumbers.Size = new Size(206, 21);
            chkNumbers.TabIndex = 9;
            chkNumbers.Text = "Include numbers (e. g. 123456)";
            chkNumbers.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom;
            btnGenerate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenerate.Location = new Point(140, 259);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(120, 30);
            btnGenerate.TabIndex = 12;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // numLength
            // 
            numLength.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numLength.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            numLength.Location = new Point(338, 94);
            numLength.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLength.Name = "numLength";
            numLength.Size = new Size(45, 25);
            numLength.TabIndex = 15;
            numLength.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numLength.ValueChanged += numLength_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 301);
            Controls.Add(numLength);
            Controls.Add(btnGenerate);
            Controls.Add(chkNumbers);
            Controls.Add(chkUppercase);
            Controls.Add(chkLowercase);
            Controls.Add(chkSymbols);
            Controls.Add(lblLength);
            Controls.Add(trkLength);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password generetor";
            ((System.ComponentModel.ISupportInitialize)trkLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private TrackBar trkLength;
        private Label lblLength;
        private CheckBox chkSymbols;
        private CheckBox chkLowercase;
        private CheckBox chkUppercase;
        private CheckBox chkNumbers;
        private Button btnGenerate;
        private NumericUpDown numLength;
    }
}