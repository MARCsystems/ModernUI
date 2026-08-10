using System;
using System.Collections.Generic;
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
            ctrlText.Text = string.Empty;
        }

        private void updateControlInitials()
        {
            if (string.IsNullOrEmpty(ctrlText.Text) && !string.IsNullOrEmpty(Name))
            {
                ctrlText.Text = Name;
            }
        }

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
