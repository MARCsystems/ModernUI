namespace UITester_NET472
{
    partial class Form1
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
            this.highlightImageButton1 = new ModernUI_NET472.Buttons.HighlightImageButton();
            this.highlightImageButton2 = new ModernUI_NET472.Buttons.HighlightImageButton();
            this.SuspendLayout();
            // 
            // highlightImageButton1
            // 
            this.highlightImageButton1.Location = new System.Drawing.Point(178, 91);
            this.highlightImageButton1.Name = "highlightImageButton1";
            this.highlightImageButton1.Size = new System.Drawing.Size(315, 197);
            this.highlightImageButton1.TabIndex = 0;
            this.highlightImageButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highlightImageButton2
            // 
            this.highlightImageButton2.Location = new System.Drawing.Point(81, 43);
            this.highlightImageButton2.Name = "highlightImageButton2";
            this.highlightImageButton2.Size = new System.Drawing.Size(75, 23);
            this.highlightImageButton2.TabIndex = 1;
            this.highlightImageButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highlightImageButton2);
            this.Controls.Add(this.highlightImageButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ModernUI_NET472.Buttons.HighlightImageButton highlightImageButton1;
        private ModernUI_NET472.Buttons.HighlightImageButton highlightImageButton2;
    }
}

