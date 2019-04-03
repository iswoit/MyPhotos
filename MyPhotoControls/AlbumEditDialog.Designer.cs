namespace Manning.MyPhotoControls
{
    partial class AlbumEditDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlbumFile = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnFileName = new System.Windows.Forms.RadioButton();
            this.rbtnCaption = new System.Windows.Forms.RadioButton();
            this.rbtnDateTaken = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtAlbumFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Size = new System.Drawing.Size(267, 61);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Album &File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlbumFile
            // 
            this.txtAlbumFile.Location = new System.Drawing.Point(82, 7);
            this.txtAlbumFile.Name = "txtAlbumFile";
            this.txtAlbumFile.ReadOnly = true;
            this.txtAlbumFile.Size = new System.Drawing.Size(180, 21);
            this.txtAlbumFile.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(82, 31);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(180, 21);
            this.txtTitle.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnDateTaken);
            this.groupBox1.Controls.Add(this.rbtnCaption);
            this.groupBox1.Controls.Add(this.rbtnFileName);
            this.groupBox1.Location = new System.Drawing.Point(13, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phot&o Description";
            // 
            // rbtnFileName
            // 
            this.rbtnFileName.AutoSize = true;
            this.rbtnFileName.Location = new System.Drawing.Point(14, 21);
            this.rbtnFileName.Name = "rbtnFileName";
            this.rbtnFileName.Size = new System.Drawing.Size(77, 16);
            this.rbtnFileName.TabIndex = 0;
            this.rbtnFileName.TabStop = true;
            this.rbtnFileName.Text = "File &name";
            this.rbtnFileName.UseVisualStyleBackColor = true;
            // 
            // rbtnCaption
            // 
            this.rbtnCaption.AutoSize = true;
            this.rbtnCaption.Location = new System.Drawing.Point(97, 21);
            this.rbtnCaption.Name = "rbtnCaption";
            this.rbtnCaption.Size = new System.Drawing.Size(65, 16);
            this.rbtnCaption.TabIndex = 1;
            this.rbtnCaption.TabStop = true;
            this.rbtnCaption.Text = "Ca&ption";
            this.rbtnCaption.UseVisualStyleBackColor = true;
            // 
            // rbtnDateTaken
            // 
            this.rbtnDateTaken.AutoSize = true;
            this.rbtnDateTaken.Location = new System.Drawing.Point(168, 21);
            this.rbtnDateTaken.Name = "rbtnDateTaken";
            this.rbtnDateTaken.Size = new System.Drawing.Size(83, 16);
            this.rbtnDateTaken.TabIndex = 2;
            this.rbtnDateTaken.TabStop = true;
            this.rbtnDateTaken.Text = "&Date Taken";
            this.rbtnDateTaken.UseVisualStyleBackColor = true;
            // 
            // AlbumEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlbumEditDialog";
            this.Text = "AlbumEditDialog";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAlbumFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnDateTaken;
        private System.Windows.Forms.RadioButton rbtnCaption;
        private System.Windows.Forms.RadioButton rbtnFileName;
    }
}