using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Manning.MyPhotoAlbum
{
    /// <summary>
    /// The photograph class represents a photograph image stored in the file system.
    /// </summary>
    public class Photograph : IDisposable
    {
        private Bitmap _bitmap;
        private string _caption = "";
        private DateTime _dateTaken = DateTime.Now;
        private string _fileName;
        private bool _hasChanged = true;
        private string _notes = "";
        private string _photographer = "";

        public Photograph(string fileName)
        {
            _fileName = fileName;
            _bitmap = null;
            _caption = System.IO.Path.GetFileNameWithoutExtension(fileName);
        }

        public string Caption
        {
            get { return _caption; }
            set
            {
                if (_caption != value)
                {
                    _caption = value;
                    HasChanged = true;
                }
            }
        }
        public DateTime DateTaken
        {
            get { return _dateTaken; }
            set
            {
                if (_dateTaken != value)
                {
                    _dateTaken = value;
                    HasChanged = true;
                }
            }
        }
        public string FileName
        {
            get { return _fileName; }
        }
        public bool HasChanged
        {
            get { return _hasChanged; }
            internal set { _hasChanged = value; }
        }
        public Bitmap Image
        {
            get
            {
                if (_bitmap == null)
                {
                    _bitmap = new Bitmap(_fileName);
                }
                return _bitmap;
            }
        }
        public string Notes
        {
            get { return _notes; }
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    HasChanged = true;
                }
            }
        }
        public string Photographer
        {
            get { return _photographer; }
            set
            {
                if (_photographer != value)
                {
                    _photographer = value;
                    HasChanged = true;
                }
            }
        }

        public void Dispose()
        {
            ReleaseImage();
        }
        public override bool Equals(object obj)
        {
            if (obj is Photograph)
            {
                Photograph p = (Photograph)obj;
                return FileName.Equals(p.FileName, StringComparison.InvariantCultureIgnoreCase);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return FileName.ToLowerInvariant().GetHashCode();
        }
        public void ReleaseImage()
        {
            if (_bitmap != null)
            {
                _bitmap.Dispose();
                _bitmap = null;
            }
        }
        public override string ToString()
        {
            return FileName;
        }

    }
}
