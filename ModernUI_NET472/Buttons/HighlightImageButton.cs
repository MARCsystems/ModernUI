using ModernUI_NET472.Assets;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ModernUI_NET472.Buttons
{
    [DesignerCategory("Control")]
    public class HighlightImageButton : Control
    {
        private string tooltipText = string.Empty;
        public HighlightImageButton()
        {
            BackgroundImageLayout = ImageLayout.Zoom;
            BackgroundImage = AppAssets.GetPlaceholderButton(false, AppAssets.ButtonMode.STANDARD);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
            MouseEnter += (s, e) => { BackgroundImage = AppAssets.GetPlaceholderButton(true, AppAssets.ButtonMode.STANDARD); };
            MouseLeave += (s, e) => { BackgroundImage = AppAssets.GetPlaceholderButton(false, AppAssets.ButtonMode.STANDARD); };
            MouseDown += (s, e) => { BackgroundImage = AppAssets.GetPlaceholderButton(true, AppAssets.ButtonMode.PRESSED); };
            MouseUp += (s, e) => { BackgroundImage = AppAssets.GetPlaceholderButton(true, AppAssets.ButtonMode.STANDARD); };
        }

        #region Class Functions
        private void updateControlInitials()
        {
            if (string.IsNullOrEmpty(tooltipText) && !string.IsNullOrEmpty(Name))
            {
                tooltipText = "No tooltip assigned.";
            }
        }
        #endregion

        #region Properties
        [Category("_ModernUI_")]
        public string TooltipText
        {
            set { tooltipText = value; new ToolTip().SetToolTip(this, tooltipText); }
            get { return tooltipText; }
        }
        #endregion

        #region Property Overrides
        [Category("Appearance")]
        private Size DefaultSize
        {
            set { DefaultSize = new Size(100, 100); }
            get { return DefaultSize; }
        }
        #endregion

        #region Designer Overrides
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            updateControlInitials();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            updateControlInitials();
        }
        #endregion
    }
}
