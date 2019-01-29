namespace MyPhotos
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.ctxMenuPhoto = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageScale = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageStretch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageActual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNext = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.打印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打印预览VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusAlbumPos = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.ctxMenuPhoto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxPhoto.ContextMenuStrip = this.ctxMenuPhoto;
            this.pbxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxPhoto.Location = new System.Drawing.Point(0, 28);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(800, 422);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPhoto.TabIndex = 1;
            this.pbxPhoto.TabStop = false;
            // 
            // ctxMenuPhoto
            // 
            this.ctxMenuPhoto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImage,
            this.toolStripMenuItem3,
            this.menuPrevious,
            this.menuNext});
            this.ctxMenuPhoto.Name = "ctxMenuPhoto";
            this.ctxMenuPhoto.Size = new System.Drawing.Size(242, 76);
            this.ctxMenuPhoto.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuPhoto_Opening);
            // 
            // menuImage
            // 
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageScale,
            this.menuImageStretch,
            this.menuImageActual});
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(241, 22);
            this.menuImage.Text = "Image";
            this.menuImage.DropDownOpening += new System.EventHandler(this.menuImage_DropDownOpening);
            this.menuImage.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuImage_DropDownItemClicked);
            // 
            // menuImageScale
            // 
            this.menuImageScale.Checked = true;
            this.menuImageScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuImageScale.Name = "menuImageScale";
            this.menuImageScale.Size = new System.Drawing.Size(176, 26);
            this.menuImageScale.Tag = "Zoom";
            this.menuImageScale.Text = "&Scale to Fit";
            // 
            // menuImageStretch
            // 
            this.menuImageStretch.Name = "menuImageStretch";
            this.menuImageStretch.Size = new System.Drawing.Size(176, 26);
            this.menuImageStretch.Tag = "StretchImage";
            this.menuImageStretch.Text = "S&tretch";
            // 
            // menuImageActual
            // 
            this.menuImageActual.Name = "menuImageActual";
            this.menuImageActual.Size = new System.Drawing.Size(176, 26);
            this.menuImageActual.Tag = "Normal";
            this.menuImageActual.Text = "&Actual Size";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(238, 6);
            // 
            // menuPrevious
            // 
            this.menuPrevious.Name = "menuPrevious";
            this.menuPrevious.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menuPrevious.Size = new System.Drawing.Size(241, 22);
            this.menuPrevious.Text = "&Previous";
            this.menuPrevious.Click += new System.EventHandler(this.menuPrevious_Click);
            // 
            // menuNext
            // 
            this.menuNext.Name = "menuNext";
            this.menuNext.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menuNext.Size = new System.Drawing.Size(241, 22);
            this.menuNext.Text = "N&ext";
            this.menuNext.Click += new System.EventHandler(this.menuNext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuView,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.toolStripSeparator,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.toolStripSeparator1,
            this.打印PToolStripMenuItem,
            this.打印预览VToolStripMenuItem,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(51, 24);
            this.menuFile.Text = "&File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(216, 26);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(216, 26);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(213, 6);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(216, 26);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(216, 26);
            this.menuFileSaveAs.Text = "Save &As";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // 打印PToolStripMenuItem
            // 
            this.打印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印PToolStripMenuItem.Image")));
            this.打印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印PToolStripMenuItem.Name = "打印PToolStripMenuItem";
            this.打印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.打印PToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打印PToolStripMenuItem.Text = "打印(&P)";
            // 
            // 打印预览VToolStripMenuItem
            // 
            this.打印预览VToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打印预览VToolStripMenuItem.Image")));
            this.打印预览VToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打印预览VToolStripMenuItem.Name = "打印预览VToolStripMenuItem";
            this.打印预览VToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.打印预览VToolStripMenuItem.Text = "打印预览(&V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(216, 26);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切TToolStripMenuItem,
            this.复制CToolStripMenuItem,
            this.粘贴PToolStripMenuItem,
            this.toolStripMenuItem1,
            this.menuEditAdd,
            this.menuEditRemove});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(51, 24);
            this.menuEdit.Text = "&Edit";
            // 
            // 剪切TToolStripMenuItem
            // 
            this.剪切TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切TToolStripMenuItem.Image")));
            this.剪切TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切TToolStripMenuItem.Name = "剪切TToolStripMenuItem";
            this.剪切TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪切TToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.剪切TToolStripMenuItem.Text = "剪切(&T)";
            // 
            // 复制CToolStripMenuItem
            // 
            this.复制CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripMenuItem.Image")));
            this.复制CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripMenuItem.Name = "复制CToolStripMenuItem";
            this.复制CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.复制CToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.复制CToolStripMenuItem.Text = "复制(&C)";
            // 
            // 粘贴PToolStripMenuItem
            // 
            this.粘贴PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripMenuItem.Image")));
            this.粘贴PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripMenuItem.Name = "粘贴PToolStripMenuItem";
            this.粘贴PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.粘贴PToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.粘贴PToolStripMenuItem.Text = "粘贴(&P)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // menuEditAdd
            // 
            this.menuEditAdd.Name = "menuEditAdd";
            this.menuEditAdd.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.menuEditAdd.Size = new System.Drawing.Size(231, 26);
            this.menuEditAdd.Text = "Ad&d";
            this.menuEditAdd.Click += new System.EventHandler(this.menuEditAdd_Click);
            // 
            // menuEditRemove
            // 
            this.menuEditRemove.Name = "menuEditRemove";
            this.menuEditRemove.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.menuEditRemove.Size = new System.Drawing.Size(231, 26);
            this.menuEditRemove.Text = "Remo&ve";
            this.menuEditRemove.Click += new System.EventHandler(this.menuEditRemove_Click);
            // 
            // menuView
            // 
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(51, 24);
            this.menuView.Text = "&View";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(51, 24);
            this.menuHelp.Text = "&Help";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.关于AToolStripMenuItem.Text = "关于(&A)...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusInfo,
            this.statusImageSize,
            this.statusAlbumPos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusInfo
            // 
            this.statusInfo.AutoSize = false;
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(699, 19);
            this.statusInfo.Spring = true;
            this.statusInfo.Text = "Desc";
            this.statusInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusImageSize
            // 
            this.statusImageSize.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusImageSize.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statusImageSize.Name = "statusImageSize";
            this.statusImageSize.Size = new System.Drawing.Size(51, 19);
            this.statusImageSize.Text = "W x H";
            // 
            // statusAlbumPos
            // 
            this.statusAlbumPos.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.statusAlbumPos.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.statusAlbumPos.Name = "statusAlbumPos";
            this.statusAlbumPos.Size = new System.Drawing.Size(35, 19);
            this.statusAlbumPos.Text = "1/1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbxPhoto);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "MyPhotos";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseWheel);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.ctxMenuPhoto.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip ctxMenuPhoto;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.ToolStripMenuItem menuImageScale;
        private System.Windows.Forms.ToolStripMenuItem menuImageStretch;
        private System.Windows.Forms.ToolStripMenuItem menuImageActual;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
        private System.Windows.Forms.ToolStripStatusLabel statusAlbumPos;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuNext;
        private System.Windows.Forms.ToolStripMenuItem menuPrevious;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 打印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打印预览VToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem 剪切TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEditRemove;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
    }
}

