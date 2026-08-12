using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI_NET472.Buttons
{
    public class HighlightImageButton : Control
    {
        private Label ctrlText;
        public HighlightImageButton()
        {
            ctrlText = new Label();
            Controls.Add(ctrlText);
            ctrlText.Text = string.Empty;
            ctrlText.Dock = DockStyle.Fill;
            ctrlText.TextAlign = ContentAlignment.MiddleCenter;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Size = DefaultSize;
        }

        private void updateControlInitials()
        {
            if (string.IsNullOrEmpty(ctrlText.Text) && !string.IsNullOrEmpty(Name))
            {
                ctrlText.Text = Name;
            }
        }

        #region Properties
        public string Text
        {
            set { ctrlText.Text = value; }
            get { return ctrlText.Text; }
        }

        public ContentAlignment TextAlign
        {
            set { ctrlText.TextAlign = value; }
            get { return ctrlText.TextAlign; }
        }

        [Category("Appearance")]
        private Size DefaultSize
        {
            set { DefaultSize = new Size(100, 100); }
            get { return DefaultSize; }
        }
        #endregion

        #region Overrides
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
