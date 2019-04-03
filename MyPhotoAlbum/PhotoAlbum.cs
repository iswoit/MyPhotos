using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Manning.MyPhotoAlbum
{
    public class PhotoAlbum : Collection<Photograph>, IDisposable
    {
        public enum DescriptorOption { FileName, Caption, DateTaken }

        private bool _hasChanged = false;
        private string _title;
        private DescriptorOption _descriptor;

        public PhotoAlbum()
        {
            ClearSettings();
        }

        public bool HasChanged
        {
            get
            {
                if (_hasChanged)
                    return true;

                foreach (Photograph p in this)
                    if (p.HasChanged)
                        return true;

                return false;
            }

            internal set
            {
                _hasChanged = value;
                if (value == false)
                {
                    foreach (Photograph p in this)
                    {
                        p.HasChanged = false;
                    }
                }
            }
        }
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                HasChanged = true;
            }
        }
        public DescriptorOption PhotoDescriptor
        {
            get { return _descriptor; }
            set
            {
                _descriptor = value;
                HasChanged = true;
            }
        }

        public Photograph Add(string fileName)
        {
            Photograph p = new Photograph(fileName);
            base.Add(p);
            return p;
        }
        protected override void ClearItems()
        {
            if (Count > 0)
            {
                Dispose();
                base.ClearItems();
                HasChanged = true;
            }
        }
        private void ClearSettings()
        {
            _title = null;
            _descriptor = DescriptorOption.Caption;
        }
        public void Dispose()
        {
            ClearSettings();
            foreach (Photograph p in this)
                p.Dispose();
        }
        public string GetDescription(Photograph photo)
        {
            switch(PhotoDescriptor)
            {
                case DescriptorOption.Caption:
                    return photo.Caption;
                case DescriptorOption.DateTaken:
                    return photo.DateTaken.ToShortDateString();
                case DescriptorOption.FileName:
                    return photo.FileName;
            }
            throw new ArgumentException("Unrecognized photo descriptor option.");
        }
        public string GetDescription(int index)
        {
            return GetDescription(this[index]);
        }
        protected override void InsertItem(int index, Photograph item)
        {
            base.InsertItem(index, item);
            HasChanged = true;
        }
        protected override void RemoveItem(int index)
        {
            Items[index].Dispose();
            base.RemoveItem(index);
            HasChanged = true;
        }
        protected override void SetItem(int index, Photograph item)
        {
            base.SetItem(index, item);
            HasChanged = true;
        }
    }
}
