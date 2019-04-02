using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Manning.MyPhotoControls
{
    public partial class BaseEditDialog : Form
    {
        public BaseEditDialog()
        {
            InitializeComponent();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetDialog();
        }
        protected virtual void ResetDialog()
        {
            // Does nothing in base class
        }

        
    }
}
