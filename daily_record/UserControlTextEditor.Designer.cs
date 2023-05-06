
namespace daily_record
{
    partial class UserControlTextEditor
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._cbxFontFamily = new System.Windows.Forms.ToolStripComboBox();
            this._cbxFontSize = new System.Windows.Forms.ToolStripComboBox();
            this._colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._btnBold = new System.Windows.Forms.ToolStripButton();
            this._btnItalic = new System.Windows.Forms.ToolStripButton();
            this._btnUnderline = new System.Windows.Forms.ToolStripButton();
            this._btnStrikeout = new System.Windows.Forms.ToolStripButton();
            this._btnIncreaseFontSize = new System.Windows.Forms.ToolStripButton();
            this._btnDecreaseFontSize = new System.Windows.Forms.ToolStripButton();
            this._btnFontColor = new System.Windows.Forms.ToolStripButton();
            this._btnFontBackgroundColor = new System.Windows.Forms.ToolStripButton();
            this._btnAlignLeft = new System.Windows.Forms.ToolStripButton();
            this._btnAlignCenter = new System.Windows.Forms.ToolStripButton();
            this._btnAlignRight = new System.Windows.Forms.ToolStripButton();
            this._btnTable = new System.Windows.Forms.ToolStripButton();
            this._btnImage = new System.Windows.Forms.ToolStripButton();
            this._btnHyperLink = new System.Windows.Forms.ToolStripButton();
            this._tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStripContainer.ContentPanel.SuspendLayout();
            this._toolStripContainer.TopToolStripPanel.SuspendLayout();
            this._toolStripContainer.SuspendLayout();
            this._toolStrip.SuspendLayout();
            this._contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _toolStripContainer
            // 
            // 
            // _toolStripContainer.ContentPanel
            // 
            this._toolStripContainer.ContentPanel.Controls.Add(this._richTextBox);
            this._toolStripContainer.ContentPanel.Size = new System.Drawing.Size(644, 400);
            this._toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._toolStripContainer.LeftToolStripPanelVisible = false;
            this._toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this._toolStripContainer.Name = "_toolStripContainer";
            this._toolStripContainer.RightToolStripPanelVisible = false;
            this._toolStripContainer.Size = new System.Drawing.Size(644, 425);
            this._toolStripContainer.TabIndex = 2;
            this._toolStripContainer.Text = "toolStripContainer1";
            // 
            // _toolStripContainer._topToolStripPanel
            // 
            this._toolStripContainer.TopToolStripPanel.Controls.Add(this._toolStrip);
            // 
            // _richTextBox
            // 
            this._richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._richTextBox.EnableAutoDragDrop = true;
            this._richTextBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._richTextBox.Location = new System.Drawing.Point(0, 0);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(644, 400);
            this._richTextBox.TabIndex = 0;
            this._richTextBox.Text = "";
            this._richTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this._richTextBox_LinkClicked);
            this._richTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._richTextBox_KeyDown);
            this._richTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this._richTextBox_MouseUp);
            // 
            // _toolStrip
            // 
            this._toolStrip.AllowMerge = false;
            this._toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnBold,
            this._btnItalic,
            this._btnUnderline,
            this._btnStrikeout,
            this.toolStripSeparator1,
            this._btnIncreaseFontSize,
            this._btnDecreaseFontSize,
            this.toolStripSeparator2,
            this._btnFontColor,
            this._btnFontBackgroundColor,
            this.toolStripSeparator4,
            this._cbxFontFamily,
            this._cbxFontSize,
            this.toolStripSeparator3,
            this._btnAlignLeft,
            this._btnAlignCenter,
            this._btnAlignRight,
            this.toolStripSeparator5,
            this._btnTable,
            this._btnImage,
            this._btnHyperLink,
            this.toolStripSeparator6});
            this._toolStrip.Location = new System.Drawing.Point(3, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(566, 25);
            this._toolStrip.TabIndex = 1;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // _cbxFontFamily
            // 
            this._cbxFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxFontFamily.Name = "_cbxFontFamily";
            this._cbxFontFamily.Size = new System.Drawing.Size(121, 25);
            this._cbxFontFamily.DropDown += new System.EventHandler(this._cbxFont_DropDown);
            this._cbxFontFamily.DropDownClosed += new System.EventHandler(this._cbxFont_DropDownClosed);
            this._cbxFontFamily.SelectedIndexChanged += new System.EventHandler(this._cbxFontFamily_SelectedIndexChanged);
            // 
            // _cbxFontSize
            // 
            this._cbxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxFontSize.Name = "_cbxFontSize";
            this._cbxFontSize.Size = new System.Drawing.Size(80, 25);
            this._cbxFontSize.DropDown += new System.EventHandler(this._cbxFont_DropDown);
            this._cbxFontSize.DropDownClosed += new System.EventHandler(this._cbxFont_DropDownClosed);
            this._cbxFontSize.SelectedIndexChanged += new System.EventHandler(this._cbxFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // _openFileDialog
            // 
            this._openFileDialog.Filter = "이미지 파일(*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif|모든 파일|*.*";
            this._openFileDialog.Multiselect = true;
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmiCut,
            this._tsmiCopy,
            this._tsmiPaste});
            this._contextMenuStrip.Name = "_contextMenuStrip";
            this._contextMenuStrip.Size = new System.Drawing.Size(181, 92);
            // 
            // _btnBold
            // 
            this._btnBold.CheckOnClick = true;
            this._btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnBold.Image = global::daily_record.Properties.Resources.Bold_16x;
            this._btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnBold.Name = "_btnBold";
            this._btnBold.Size = new System.Drawing.Size(23, 22);
            this._btnBold.ToolTipText = "Bold";
            this._btnBold.Click += new System.EventHandler(this._btnFontStyle_Click);
            // 
            // _btnItalic
            // 
            this._btnItalic.CheckOnClick = true;
            this._btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnItalic.Image = global::daily_record.Properties.Resources.Italic_16x;
            this._btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnItalic.Name = "_btnItalic";
            this._btnItalic.Size = new System.Drawing.Size(23, 22);
            this._btnItalic.Text = "toolStripButton2";
            this._btnItalic.ToolTipText = "Italic";
            this._btnItalic.Click += new System.EventHandler(this._btnFontStyle_Click);
            // 
            // _btnUnderline
            // 
            this._btnUnderline.CheckOnClick = true;
            this._btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnUnderline.Image = global::daily_record.Properties.Resources.Underline_16x;
            this._btnUnderline.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnUnderline.Name = "_btnUnderline";
            this._btnUnderline.Size = new System.Drawing.Size(23, 22);
            this._btnUnderline.Text = "toolStripButton4";
            this._btnUnderline.ToolTipText = "Underline";
            this._btnUnderline.Click += new System.EventHandler(this._btnFontStyle_Click);
            // 
            // _btnStrikeout
            // 
            this._btnStrikeout.BackColor = System.Drawing.SystemColors.Control;
            this._btnStrikeout.CheckOnClick = true;
            this._btnStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnStrikeout.Image = global::daily_record.Properties.Resources.StrikeThrough_16x;
            this._btnStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnStrikeout.Name = "_btnStrikeout";
            this._btnStrikeout.Size = new System.Drawing.Size(23, 22);
            this._btnStrikeout.Text = "toolStripButton3";
            this._btnStrikeout.ToolTipText = "StrikeThrough";
            this._btnStrikeout.Click += new System.EventHandler(this._btnFontStyle_Click);
            // 
            // _btnIncreaseFontSize
            // 
            this._btnIncreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnIncreaseFontSize.Image = global::daily_record.Properties.Resources.IncreaseFontSize_16x;
            this._btnIncreaseFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnIncreaseFontSize.Name = "_btnIncreaseFontSize";
            this._btnIncreaseFontSize.Size = new System.Drawing.Size(23, 22);
            this._btnIncreaseFontSize.Text = "toolStripButton1";
            this._btnIncreaseFontSize.Click += new System.EventHandler(this._btnIncreaseFontSize_Click);
            // 
            // _btnDecreaseFontSize
            // 
            this._btnDecreaseFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnDecreaseFontSize.Image = global::daily_record.Properties.Resources.DecreaseFontSize_16x;
            this._btnDecreaseFontSize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._btnDecreaseFontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnDecreaseFontSize.Name = "_btnDecreaseFontSize";
            this._btnDecreaseFontSize.Size = new System.Drawing.Size(23, 22);
            this._btnDecreaseFontSize.Text = "toolStripButton2";
            this._btnDecreaseFontSize.Click += new System.EventHandler(this._btnDecreaseFontSize_Click);
            // 
            // _btnFontColor
            // 
            this._btnFontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnFontColor.Image = global::daily_record.Properties.Resources.FontColor_16x;
            this._btnFontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnFontColor.Name = "_btnFontColor";
            this._btnFontColor.Size = new System.Drawing.Size(23, 22);
            this._btnFontColor.Text = "toolStripButton3";
            this._btnFontColor.Click += new System.EventHandler(this._btnFontColor_Click);
            // 
            // _btnFontBackgroundColor
            // 
            this._btnFontBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnFontBackgroundColor.Image = global::daily_record.Properties.Resources.HighlightText_16x;
            this._btnFontBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnFontBackgroundColor.Name = "_btnFontBackgroundColor";
            this._btnFontBackgroundColor.Size = new System.Drawing.Size(23, 22);
            this._btnFontBackgroundColor.Text = "toolStripButton1";
            this._btnFontBackgroundColor.Click += new System.EventHandler(this._btnFontBackgroundColor_Click);
            // 
            // _btnAlignLeft
            // 
            this._btnAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnAlignLeft.Image = global::daily_record.Properties.Resources.AlignLeft_16x;
            this._btnAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnAlignLeft.Name = "_btnAlignLeft";
            this._btnAlignLeft.Size = new System.Drawing.Size(23, 22);
            this._btnAlignLeft.Text = "toolStripButton1";
            this._btnAlignLeft.Click += new System.EventHandler(this._btnAlignLeft_Click);
            // 
            // _btnAlignCenter
            // 
            this._btnAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnAlignCenter.Image = global::daily_record.Properties.Resources.AlignCenter_16x;
            this._btnAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnAlignCenter.Name = "_btnAlignCenter";
            this._btnAlignCenter.Size = new System.Drawing.Size(23, 22);
            this._btnAlignCenter.Text = "toolStripButton2";
            this._btnAlignCenter.Click += new System.EventHandler(this._btnAlignCenter_Click);
            // 
            // _btnAlignRight
            // 
            this._btnAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnAlignRight.Image = global::daily_record.Properties.Resources.AlignRight_16x;
            this._btnAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnAlignRight.Name = "_btnAlignRight";
            this._btnAlignRight.Size = new System.Drawing.Size(23, 22);
            this._btnAlignRight.Text = "toolStripButton3";
            this._btnAlignRight.Click += new System.EventHandler(this._btnAlignRight_Click);
            // 
            // _btnTable
            // 
            this._btnTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnTable.Image = global::daily_record.Properties.Resources.Table_16x;
            this._btnTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnTable.Name = "_btnTable";
            this._btnTable.Size = new System.Drawing.Size(23, 22);
            this._btnTable.Text = "toolStripButton5";
            this._btnTable.Click += new System.EventHandler(this._btnTable_Click);
            // 
            // _btnImage
            // 
            this._btnImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnImage.Image = global::daily_record.Properties.Resources.Image_16x;
            this._btnImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnImage.Name = "_btnImage";
            this._btnImage.Size = new System.Drawing.Size(23, 22);
            this._btnImage.Text = "toolStripButton6";
            this._btnImage.Click += new System.EventHandler(this._btnImage_Click);
            // 
            // _btnHyperLink
            // 
            this._btnHyperLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._btnHyperLink.Image = global::daily_record.Properties.Resources.HyperLink_16x;
            this._btnHyperLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnHyperLink.Name = "_btnHyperLink";
            this._btnHyperLink.Size = new System.Drawing.Size(23, 22);
            this._btnHyperLink.Text = "toolStripButton7";
            this._btnHyperLink.Click += new System.EventHandler(this._btnHyperLink_Click);
            // 
            // _tsmiCut
            // 
            this._tsmiCut.Image = global::daily_record.Properties.Resources.Cut_16x;
            this._tsmiCut.Name = "_tsmiCut";
            this._tsmiCut.Size = new System.Drawing.Size(180, 22);
            this._tsmiCut.Text = "잘라내기";
            this._tsmiCut.Click += new System.EventHandler(this._tsmiCut_Click);
            // 
            // _tsmiCopy
            // 
            this._tsmiCopy.Image = global::daily_record.Properties.Resources.Copy_16x;
            this._tsmiCopy.Name = "_tsmiCopy";
            this._tsmiCopy.Size = new System.Drawing.Size(180, 22);
            this._tsmiCopy.Text = "복사";
            this._tsmiCopy.Click += new System.EventHandler(this._tsmiCopy_Click);
            // 
            // _tsmiPaste
            // 
            this._tsmiPaste.Image = global::daily_record.Properties.Resources.Paste_16x;
            this._tsmiPaste.Name = "_tsmiPaste";
            this._tsmiPaste.Size = new System.Drawing.Size(180, 22);
            this._tsmiPaste.Text = "붙여넣기";
            this._tsmiPaste.Click += new System.EventHandler(this._tsmiPaste_Click);
            // 
            // UserControlTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._toolStripContainer);
            this.Name = "UserControlTextEditor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(644, 425);
            this._toolStripContainer.ContentPanel.ResumeLayout(false);
            this._toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this._toolStripContainer.TopToolStripPanel.PerformLayout();
            this._toolStripContainer.ResumeLayout(false);
            this._toolStripContainer.PerformLayout();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this._contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer _toolStripContainer;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _btnBold;
        private System.Windows.Forms.ToolStripButton _btnItalic;
        private System.Windows.Forms.ToolStripButton _btnUnderline;
        private System.Windows.Forms.ToolStripButton _btnStrikeout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton _btnIncreaseFontSize;
        private System.Windows.Forms.ToolStripButton _btnDecreaseFontSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _btnFontColor;
        private System.Windows.Forms.ToolStripComboBox _cbxFontFamily;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripComboBox _cbxFontSize;
        private System.Windows.Forms.RichTextBox _richTextBox;
        private System.Windows.Forms.ColorDialog _colorDialog;
        private System.Windows.Forms.ToolStripButton _btnFontBackgroundColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton _btnAlignLeft;
        private System.Windows.Forms.ToolStripButton _btnAlignCenter;
        private System.Windows.Forms.ToolStripButton _btnAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton _btnTable;
        private System.Windows.Forms.ToolStripButton _btnImage;
        private System.Windows.Forms.ToolStripButton _btnHyperLink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem _tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem _tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem _tsmiPaste;
    }
}
