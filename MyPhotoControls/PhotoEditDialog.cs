using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;

namespace Manning.MyPhotoControls
{
    public partial class PhotoEditDialog : Manning.MyPhotoControls.BaseEditDialog
    {
        private Photograph _photo;
        private AlbumManager _manager = null;

        protected PhotoEditDialog()
        {
            InitializeComponent();
        }
        public PhotoEditDialog(Photograph photo) : this()
        {
            if (photo == null)
                throw new ArgumentNullException("The photo parameter cannot be null");
            InitializeDialog(photo);
        }
        public PhotoEditDialog(AlbumManager mgr) : this()
        {
            if (mgr == null)
                throw new ArgumentNullException("The mgr parameter cannot be null");
            _manager = mgr;
            InitializeDialog(mgr.Current);
        }

        private Photograph Photo
        {
            get { return _photo; }
        }
        private AlbumManager Manager
        {
            get { return _manager; }
        }

        private void InitializeDialog(Photograph photo)
        {
            _photo = photo;
            ResetDialog();
            mskDateTaken.ValidatingType = typeof(CurrentDate);
        }
        private void mskDateTaken_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if(!e.IsValidInput)
            {
                DialogResult result = MessageBox.Show("The Date Taken entry is invalid of in the future and may be ignored. Do you wish to correct this?", "Photo Properties", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                e.Cancel = (result == DialogResult.Yes);
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
                SaveSettings();
            
        }        
        protected override void ResetDialog()
        {
            Photograph photo = Photo;
            if (photo != null)
            {
                txtPhotoFile.Text = photo.FileName;
                txtCaption.Text = photo.Caption;
                mskDateTaken.Text = photo.DateTaken.ToString("yyyyMMdd");
                txtPhotographer.Text = photo.Photographer; txtNotes.Text = photo.Notes;
            }

        }
        private void SaveSettings()
        {
            Photograph photo = Photo;
            if (photo != null)
            {
                photo.Caption = txtCaption.Text;
                photo.Photographer = txtPhotographer.Text;
                photo.Notes = txtNotes.Text;

                // On pares error ,do not set date
                try
                {
                    photo.DateTaken = DateTime.Parse(mskDateTaken.Text);
                }
                catch (FormatException) { }
            }
        }
        private void txtCaption_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            e.Handled = !(Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c) || Char.IsControl(c));
            if (e.Handled)
                Console.Beep();
        }
        private void txtCaption_TextChanged(object sender, EventArgs e)
        {
            Text = txtCaption.Text + " - Properties";
        }

        private static class CurrentDate
        {
            public static DateTime Parse(string input)
            {
                DateTime result = DateTime.Parse(input);
                if (result > DateTime.Now)
                    throw new FormatException("The given date is in the future.");
                return result;
            }
        }


    }
}
