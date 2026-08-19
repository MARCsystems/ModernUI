using ModernUI_NET472.Assets;
using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Windows.Forms;

namespace ModernUI_NET472.Buttons
{
    [DesignerCategory("Control")]
    public class HighlightImageButton : Control
    {
        private string tooltipText = string.Empty;
        private AppAssets.ButtonMode mode = AppAssets.ButtonMode.STANDARD;
        private bool isHover = false;
        
        public HighlightImageButton()
        {
            BackgroundImageLayout = ImageLayout.Zoom;
            BackgroundImage = AppAssets.GetPlaceholderButton(false, AppAssets.ButtonMode.STANDARD);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            Size = new Size(100, 100);

            MouseEnter += (s, e) => { isHover = true; UpdateButtonState(); };
            MouseLeave += (s, e) => { isHover = false; UpdateButtonState(); };
            MouseDown += (s, e) =>
            {
                ButtonMode = !(mode == AppAssets.ButtonMode.LOCKED || mode==AppAssets.ButtonMode.LOADING || mode == AppAssets.ButtonMode.DISABLED) ? AppAssets.ButtonMode.PRESSED : mode;
            };
            MouseUp += (s, e) =>
            {
                ButtonMode = !(mode == AppAssets.ButtonMode.LOCKED || mode == AppAssets.ButtonMode.LOADING || mode == AppAssets.ButtonMode.DISABLED) ? AppAssets.ButtonMode.STANDARD : mode;
            };
        }

        #region Class Functions
        private void updateControlInitials()
        {
            if (string.IsNullOrEmpty(tooltipText) && !string.IsNullOrEmpty(Name))
            {
                tooltipText = "No tooltip assigned.";
            }
        }

        private void UpdateButtonState()
        {
            BackgroundImage = AppAssets.GetPlaceholderButton(isHover, mode);
        }

        private bool CanPerformClick()
        {
            return !(mode == AppAssets.ButtonMode.LOCKED || mode == AppAssets.ButtonMode.LOADING || mode == AppAssets.ButtonMode.DISABLED);
        }
        #endregion

        #region Properties
        [Category("_ModernUI_")]
        public string TooltipText
        {
            set { tooltipText = value; new ToolTip().SetToolTip(this, tooltipText); }
            get { return tooltipText; }
        }

        [Category("_ModernUI_")]
        public AppAssets.ButtonMode ButtonMode
        {
            set { mode = value; UpdateButtonState(); }
            get { return mode; }
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

        #region Event Overrides
        protected override void OnClick(EventArgs e)
        {
            if (CanPerformClick())
            {
                base.OnClick(e);
            }
            else
            {
                // No action - LOCKED
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            if (CanPerformClick())
            {
                base.OnDoubleClick(e);
            }
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
