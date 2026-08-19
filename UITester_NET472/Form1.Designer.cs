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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.highlightImageButton4 = new ModernUI_NET472.Buttons.HighlightImageButton();
            this.highlightImageButton3 = new ModernUI_NET472.Buttons.HighlightImageButton();
            this.highlightImageButton2 = new ModernUI_NET472.Buttons.HighlightImageButton();
            this.highlightImageButton1 = new ModernUI_NET472.Buttons.HighlightImageButton();
            this.SuspendLayout();
            // 
            // highlightImageButton4
            // 
            this.highlightImageButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("highlightImageButton4.BackgroundImage")));
            this.highlightImageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.highlightImageButton4.ButtonMode = ModernUI_NET472.Assets.AppAssets.ButtonMode.STANDARD;
            this.highlightImageButton4.Location = new System.Drawing.Point(330, 12);
            this.highlightImageButton4.Name = "highlightImageButton4";
            this.highlightImageButton4.Size = new System.Drawing.Size(100, 100);
            this.highlightImageButton4.TabIndex = 3;
            this.highlightImageButton4.Text = "highlightImageButton4";
            this.highlightImageButton4.TooltipText = "Click to Disable Button A";
            this.highlightImageButton4.Click += new System.EventHandler(this.highlightImageButton4_Click);
            // 
            // highlightImageButton3
            // 
            this.highlightImageButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("highlightImageButton3.BackgroundImage")));
            this.highlightImageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.highlightImageButton3.ButtonMode = ModernUI_NET472.Assets.AppAssets.ButtonMode.STANDARD;
            this.highlightImageButton3.Location = new System.Drawing.Point(224, 12);
            this.highlightImageButton3.Name = "highlightImageButton3";
            this.highlightImageButton3.Size = new System.Drawing.Size(100, 100);
            this.highlightImageButton3.TabIndex = 2;
            this.highlightImageButton3.Text = "highlightImageButton3";
            this.highlightImageButton3.TooltipText = "Click to set Button A to Loading";
            this.highlightImageButton3.Click += new System.EventHandler(this.highlightImageButton3_Click);
            // 
            // highlightImageButton2
            // 
            this.highlightImageButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("highlightImageButton2.BackgroundImage")));
            this.highlightImageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.highlightImageButton2.ButtonMode = ModernUI_NET472.Assets.AppAssets.ButtonMode.STANDARD;
            this.highlightImageButton2.Location = new System.Drawing.Point(118, 12);
            this.highlightImageButton2.Name = "highlightImageButton2";
            this.highlightImageButton2.Size = new System.Drawing.Size(100, 100);
            this.highlightImageButton2.TabIndex = 1;
            this.highlightImageButton2.Text = "highlightImageButton2";
            this.highlightImageButton2.TooltipText = "Click to Unlock Button A";
            this.highlightImageButton2.Click += new System.EventHandler(this.highlightImageButton2_Click);
            // 
            // highlightImageButton1
            // 
            this.highlightImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("highlightImageButton1.BackgroundImage")));
            this.highlightImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.highlightImageButton1.ButtonMode = ModernUI_NET472.Assets.AppAssets.ButtonMode.STANDARD;
            this.highlightImageButton1.Location = new System.Drawing.Point(12, 12);
            this.highlightImageButton1.Name = "highlightImageButton1";
            this.highlightImageButton1.Size = new System.Drawing.Size(100, 100);
            this.highlightImageButton1.TabIndex = 0;
            this.highlightImageButton1.Text = "highlightImageButton1";
            this.highlightImageButton1.TooltipText = "Click to Lock Button A";
            this.highlightImageButton1.Click += new System.EventHandler(this.highlightImageButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.highlightImageButton4);
            this.Controls.Add(this.highlightImageButton3);
            this.Controls.Add(this.highlightImageButton2);
            this.Controls.Add(this.highlightImageButton1);
            this.Name = "Form1";
            this.Text = "Testing Interface";
            this.ResumeLayout(false);

        }

        #endregion

        private ModernUI_NET472.Buttons.HighlightImageButton highlightImageButton1;
        private ModernUI_NET472.Buttons.HighlightImageButton highlightImageButton2;
        private ModernUI_NET472.Buttons.HighlightImageButton highlightImageButton3;
        private ModernUI_NET472.Buttons.HighlightImageButton highlightImageButton4;
    }
}

