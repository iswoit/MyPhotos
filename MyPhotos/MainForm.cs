﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;

namespace MyPhotos
{
    public partial class MainForm : Form
    {
        private AlbumManager _manager;

        public MainForm()
        {
            InitializeComponent();
            NewAlbum();

            menuView.DropDown = ctxMenuPhoto;
        }

        private AlbumManager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        private void ctxMenuPhoto_Opening(object sender, CancelEventArgs e)
        {
            menuNext.Enabled = (Manager.Index < Manager.Album.Count - 1);
            menuPrevious.Enabled = (Manager.Index > 0);
        }
        private void DisplayAlbum()
        {
            pbxPhoto.Image = Manager.CurrentImage;
            SetStatusStrip();
            SetTitleBar();
        }
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            NewAlbum();
        }
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Album";
            dlg.Filter = "Album files (*.abm)|*.abm|All files (*.*)|*.*";
            dlg.InitialDirectory = AlbumManager.DefaultPath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // TODO: save any existing album.

                // Open the new Album
                // TODO: handle invalid album file
                Manager = new AlbumManager(dlg.FileName);
                DisplayAlbum();
            }
            dlg.Dispose();
        }
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            SaveAlbum();
        }
        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveAsAlbum();
        }
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void menuEditAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Add Photos";
            dlg.Multiselect = true;
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|*.jpg;*.jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png|" + "JPEG files (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "GIF files (*.gif)|*.gif|" + "BMP files (*.bmp)|*.bmp|" + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|" + "PNG files (*.png)|*.png|" + "All files (*.*)|*.*";
            dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.RestoreDirectory = true;
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] files = dlg.FileNames;
                int index = 0;
                foreach (string s in files)
                {
                    Photograph photo = new Photograph(s);

                    // Add the file (if not already present)
                    index = Manager.Album.IndexOf(photo);
                    if (index < 0)
                        Manager.Album.Add(photo);
                    else
                        photo.Dispose();
                }
                Manager.Index = Manager.Album.Count - 1;
            }
            dlg.Dispose();
            DisplayAlbum();
        }
        private void menuEditRemove_Click(object sender, EventArgs e)
        {
            if (Manager.Album.Count > 0)
            {
                Manager.Album.RemoveAt(Manager.Index);
                DisplayAlbum();
            }
        }
        private void menuImage_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ProcessImageClick(e);
        }
        private void menuImage_DropDownOpening(object sender, EventArgs e)
        {
            ProcessImageOpening(sender as ToolStripDropDownItem);
        }
        private void menuPrevious_Click(object sender, EventArgs e)
        {
            if (Manager.Index > 0)
            {
                Manager.Index--;
                DisplayAlbum();
            }
        }
        private void menuNext_Click(object sender, EventArgs e)
        {
            if (Manager.Index < Manager.Album.Count - 1)
            {
                Manager.Index++;
                DisplayAlbum();
            }
        }
        private void MainForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Manager.Album != null && Manager.Album.Count > 0)
            {
                if (e.Delta < 0)
                {
                    if (Manager.MoveNext())
                        DisplayAlbum();
                }
                else if (e.Delta > 0)
                {
                    if (Manager.MovePrev())
                        DisplayAlbum();
                }
            }
        }
        private void NewAlbum()
        {
            // TODO:clean up,save existing album
            Manager = new AlbumManager();
            DisplayAlbum();
        }
        private void ProcessImageClick(ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            string enumVal = item.Tag as string;
            if (enumVal != null)
            {
                pbxPhoto.SizeMode = (PictureBoxSizeMode)Enum.Parse(typeof(PictureBoxSizeMode), enumVal);
            }
        }
        private void ProcessImageOpening(ToolStripDropDownItem parent)
        {
            if (parent != null)
            {
                string enumVal = pbxPhoto.SizeMode.ToString();
                foreach (ToolStripMenuItem item in parent.DropDownItems)
                {
                    item.Enabled = (pbxPhoto.Image != null);
                    item.Checked = item.Tag.Equals(enumVal);
                }
            }
        }
        private void SaveAlbum(string name)
        {
            Manager.Save(name, true);
        }
        private void SaveAlbum()
        {
            if (String.IsNullOrEmpty(Manager.FullName))
                SaveAsAlbum();
            else
                SaveAlbum(Manager.FullName);
        }
        private void SaveAsAlbum()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Save Album";
            dlg.Filter = "Album files (*.abm)|*.abm|All files (*.*)|*.*";
            dlg.InitialDirectory = AlbumManager.DefaultPath;
            dlg.RestoreDirectory = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SaveAlbum(dlg.FileName);

                // Update title bar to include new name
                SetTitleBar();
            }
            dlg.Dispose();
        }
        private void SetStatusStrip()
        {
            if (pbxPhoto.Image != null)
            {
                statusInfo.Text = Manager.Current.Caption;
                statusImageSize.Text = String.Format("{0:#}x{1:#}", pbxPhoto.Image.Width, pbxPhoto.Image.Height);
                statusAlbumPos.Text = String.Format("{0:0}/{1:0}", Manager.Index + 1, Manager.Album.Count);
            }
            else
            {
                statusInfo.Text = null;
                statusImageSize.Text = null;
                statusAlbumPos.Text = null;
            }
        }
        private void SetTitleBar()
        {
            Version ver = new Version(Application.ProductVersion);
            string name = Manager.FullName;
            Text = String.Format("{2} - MyPhotos {0:0}.{1:0}", ver.Major, ver.Minor, String.IsNullOrEmpty(name) ? "Untitled" : name);
        }


    }
}
