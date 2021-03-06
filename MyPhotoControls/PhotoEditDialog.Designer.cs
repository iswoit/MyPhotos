namespace Manning.MyPhotoControls
{
    partial class PhotoEditDialog
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
            this.tablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhotoFile = new System.Windows.Forms.TextBox();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtPhotographer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.mskDateTaken = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.tablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablePanel);
            // 
            // tablePanel
            // 
            this.tablePanel.ColumnCount = 2;
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tablePanel.Controls.Add(this.label1, 0, 0);
            this.tablePanel.Controls.Add(this.label2, 0, 1);
            this.tablePanel.Controls.Add(this.label3, 0, 2);
            this.tablePanel.Controls.Add(this.label4, 0, 3);
            this.tablePanel.Controls.Add(this.txtPhotoFile, 1, 0);
            this.tablePanel.Controls.Add(this.txtCaption, 1, 1);
            this.tablePanel.Controls.Add(this.txtPhotographer, 1, 3);
            this.tablePanel.Controls.Add(this.mskDateTaken, 1, 2);
            this.tablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel.Location = new System.Drawing.Point(0, 0);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.RowCount = 4;
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel.Size = new System.Drawing.Size(265, 105);
            this.tablePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Photo &File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cap&tion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Date Taken:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Photographer:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhotoFile
            // 
            this.txtPhotoFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhotoFile.Location = new System.Drawing.Point(95, 3);
            this.txtPhotoFile.Name = "txtPhotoFile";
            this.txtPhotoFile.ReadOnly = true;
            this.txtPhotoFile.Size = new System.Drawing.Size(167, 21);
            this.txtPhotoFile.TabIndex = 1;
            // 
            // txtCaption
            // 
            this.txtCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCaption.Location = new System.Drawing.Point(95, 29);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(167, 21);
            this.txtCaption.TabIndex = 3;
            this.txtCaption.TextChanged += new System.EventHandler(this.txtCaption_TextChanged);
            this.txtCaption.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaption_KeyPress);
            // 
            // txtPhotographer
            // 
            this.txtPhotographer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhotographer.Location = new System.Drawing.Point(95, 81);
            this.txtPhotographer.Name = "txtPhotographer";
            this.txtPhotographer.Size = new System.Drawing.Size(167, 21);
            this.txtPhotographer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.Location = new System.Drawing.Point(12, 143);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(268, 89);
            this.txtNotes.TabIndex = 8;
            // 
            // mskDateTaken
            // 
            this.mskDateTaken.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskDateTaken.Location = new System.Drawing.Point(95, 55);
            this.mskDateTaken.Mask = "0000/00/00";
            this.mskDateTaken.Name = "mskDateTaken";
            this.mskDateTaken.Size = new System.Drawing.Size(167, 21);
            this.mskDateTaken.TabIndex = 5;
            this.mskDateTaken.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mskDateTaken_TypeValidationCompleted);
            // 
            // PhotoEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Name = "PhotoEditDialog";
            this.Text = "Photo Properties";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtNotes, 0);
            this.panel1.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhotoFile;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TextBox txtPhotographer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.MaskedTextBox mskDateTaken;
    }
}