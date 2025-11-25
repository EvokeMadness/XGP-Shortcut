namespace XGP_Shortcut
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
            textBoxLicenses = new TextBox();
            SuspendLayout();
            // 
            // textBoxLicenses
            // 
            textBoxLicenses.Dock = DockStyle.Fill;
            textBoxLicenses.Location = new Point(0, 0);
            textBoxLicenses.Multiline = true;
            textBoxLicenses.Name = "textBoxLicenses";
            textBoxLicenses.ReadOnly = true;
            textBoxLicenses.ScrollBars = ScrollBars.Both;
            textBoxLicenses.Size = new Size(784, 561);
            textBoxLicenses.TabIndex = 0;
            textBoxLicenses.WordWrap = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 561);
            Controls.Add(textBoxLicenses);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form2";
            Text = "Licenses";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLicenses;
    }
}