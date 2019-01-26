using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace Manning.MyPhotoAlbum
{
    public class AlbumManager
    {
        private PhotoAlbum _album;
        static private string _defaultPath;
        private string _name = String.Empty;
        private int _pos = -1;

        static AlbumManager()
        {
            _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\Albums";
        }
        public AlbumManager()
        {
            _album = new PhotoAlbum();
        }
        public AlbumManager(string name) : this()
        {
            _name = name;
            // TODO: load the album
            throw new NotImplementedException();
        }

        public PhotoAlbum Album
        {
            get { return _album; }
        }
        public Photograph Current
        {
            get
            {
                if (Index < 0 || Index >= Album.Count)
                    return null;
                return Album[_pos];
            }
        }
        public Bitmap CurrentImage
        {
            get
            {
                if (Current == null)
                    return null;
                return Current.Image;
            }
        }
        static public string DefaultPath
        {
            get { return _defaultPath; }
            set { _defaultPath = value; }
        }
        public string FullName
        {
            get { return _name; }
            private set { _name = value; }
        }
        public int Index
        {
            get
            {
                int count = Album.Count;
                if (_pos >= count)
                    _pos = count - 1;
                return _pos;
            }
            set
            {
                if (value < 0 || value >= Album.Count)
                    throw new IndexOutOfRangeException("The given index is out of bounds");
                _pos = value;
            }
        }
        public string ShortName
        {
            get
            {
                if (String.IsNullOrEmpty(FullName))
                    return null;
                else
                    return Path.GetFileNameWithoutExtension(FullName);
            }
        }

        static public bool AlbumExists(string name)
        {
            // TODO: implement AlbumExists method
            return false;
        }
        public bool MoveNext()
        {
            if (Index >= Album.Count)
                return false;
            Index++;
            return true;
        }
        public bool MovePrev()
        {
            if (Index <= 0)
                return false;
            Index--;
            return true;
        }
        public void Save()
        {
            // TODO:
            throw new NotImplementedException();
        }
        public void Save(string name, bool overwrite)
        {
            // TODO:
            throw new NotImplementedException();
        }
    }
}
