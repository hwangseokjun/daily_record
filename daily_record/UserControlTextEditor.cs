using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using daily_record.Extensions.RichTextBoxExtension;

namespace daily_record
{
    public partial class UserControlTextEditor : UserControl
    {
        private FormTableSizeDialog _tableSizeDialog = new FormTableSizeDialog();
        private Dictionary<string, Font> _fontCache = new Dictionary<string, Font>();

        public string Rtf { get => _richTextBox.Rtf; }

        public UserControlTextEditor()
        {
            InitializeComponent();
            _cbxFontFamily.ComboBox.DataSource = new InstalledFontCollection().Families;
            _cbxFontFamily.ComboBox.DisplayMember = "Name";
            _cbxFontFamily.SelectedIndex = 0;
            var values = Enumerable.Range(8, 75)
                .Select(i => (object)i)
                .ToArray();
            _cbxFontSize.Items.AddRange(values);
            _cbxFontSize.SelectedIndex = 3;
            _toolStrip.Renderer = new CustomToolStripRenderer();
        }

        private void _btnFontStyle_Click(object sender, EventArgs e)
        {
            var toolStripButton = sender as ToolStripButton;
            TryGetButtonAndFontStyle(
                toolStripButton.Name,
                out ToolStripButton currentButton,
                out FontStyle fontStyle);
            ApplyFontStyleToArea(currentButton, fontStyle);
        }

        private void _btnIncreaseFontSize_Click(object sender, EventArgs e)
        {
            if (_cbxFontSize.SelectedIndex == _cbxFontSize.Items.Count)
            {
                return;
            }

            _cbxFontSize.SelectedIndex++;
            ApplyFontSizeToArea();
        }

        private void _btnDecreaseFontSize_Click(object sender, EventArgs e)
        {
            if (_cbxFontSize.SelectedIndex < 1)
            {
                return;
            }

            _cbxFontSize.SelectedIndex--;
            ApplyFontSizeToArea();
        }

        private void _btnFontColor_Click(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                _richTextBox.SelectionColor = _colorDialog.Color;
            }
        }

        private void _btnFontBackgroundColor_Click(object sender, EventArgs e)
        {
            if (_colorDialog.ShowDialog() == DialogResult.OK)
            {
                _richTextBox.SelectionBackColor = _colorDialog.Color;
            }
        }

        private void _btnTable_Click(object sender, EventArgs e)
        {
            if (_tableSizeDialog.ShowDialog() == DialogResult.OK)
            {
                _richTextBox.SelectedRtf = _tableSizeDialog.Rtf;
            }
        }

        private void _btnAlignLeft_Click(object sender, EventArgs e)
        {
            _richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void _btnAlignCenter_Click(object sender, EventArgs e)
        {
            _richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void _btnAlignRight_Click(object sender, EventArgs e)
        {
            _richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void _btnImage_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            IDataObject backupData = Clipboard.GetDataObject();
            string[] fileNames = _openFileDialog.FileNames;

            try
            {
                foreach (var fileName in fileNames)
                {
                    // TODO : 업로드 이미지 반드시 압축 필요.
                    using (var image = Image.FromFile(fileName))
                    {
                        Clipboard.SetImage(image);
                        _richTextBox.Focus();
                        _richTextBox.Paste();
                    }
                }
            }
            finally
            {
                Clipboard.SetDataObject(backupData);
            }
        }

        private void _cbxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFontSizeToArea();

            if (!(_richTextBox.SelectionFont is null))
            {
                _richTextBox.SelectionFont = new Font(_richTextBox.SelectionFont.FontFamily, (int)_cbxFontSize.SelectedItem, _richTextBox.SelectionFont.Style);
            }
        }

        private void _cbxFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: 한글에는 적용되는데, 영문에는 적용이 안되고있다. 윈도우즈의 한컴입력기, US키보드 문제때문에 발생함. 버그 해결 방법이 있는지 알아봐야함.
            // TODO: 리치텍스트박스 컨트롤 자체가 윈도우에 요청을 보내어 처리하는 구조라서 버그가 있을 수도 있다. 상용 제품은 자사 솔루션이 적용되어 있을 것이다.
            ApplyFontFamilyToArea();

            if (!(_richTextBox.SelectionFont is null)) 
            {
                _richTextBox.SelectionFont = new Font(_cbxFontFamily.Text, _richTextBox.SelectionFont.Size, _richTextBox.SelectionFont.Style);
            }
        }

        private void _cbxFont_DropDown(object sender, EventArgs e)
        {
            _richTextBox.Focus();
        }

        private void _cbxFont_DropDownClosed(object sender, EventArgs e)
        {
            _richTextBox.Focus();
        }

        private void ApplyFontSizeToArea()
        {
            if (string.IsNullOrEmpty(_richTextBox.SelectedText))
            {
                return;
            }

            int selectionStart = _richTextBox.SelectionStart;
            int selectionLength = _richTextBox.SelectionLength;

            for (int i = 0; i < selectionLength; i++)
            {
                _richTextBox.SelectionStart = selectionStart + i;
                _richTextBox.SelectionLength = 1;

                var currentFont = _richTextBox.SelectionFont;
                _richTextBox.SelectionFont = new Font(currentFont.FontFamily, (int)_cbxFontSize.SelectedItem, currentFont.Style);
            }

            _richTextBox.SelectionStart = selectionStart;
            _richTextBox.SelectionLength = selectionLength;
        }

        private void ApplyFontFamilyToArea()
        {
            if (string.IsNullOrEmpty(_richTextBox.SelectedText))
            {
                return;
            }

            int selectionStart = _richTextBox.SelectionStart;
            int selectionLength = _richTextBox.SelectionLength;

            for (int i = 0; i < selectionLength; i++)
            {
                _richTextBox.SelectionStart = selectionStart + i;
                _richTextBox.SelectionLength = 1;

                var currentFont = _richTextBox.SelectionFont;
                _richTextBox.SelectionFont = new Font(_cbxFontFamily.Text, currentFont.Size, currentFont.Style);
            }

            _richTextBox.SelectionStart = selectionStart;
            _richTextBox.SelectionLength = selectionLength;
        }

        private void TryGetButtonAndFontStyle(string instanceName, out ToolStripButton toolStripButton, out FontStyle fontStyle)
        {
            switch (instanceName)
            {
                case nameof(_btnBold):
                    toolStripButton = _btnBold;
                    fontStyle = FontStyle.Bold;
                    return;
                case nameof(_btnItalic):
                    toolStripButton = _btnItalic;
                    fontStyle = FontStyle.Italic;
                    return;
                case nameof(_btnUnderline):
                    toolStripButton = _btnUnderline;
                    fontStyle = FontStyle.Underline;
                    return;
                case nameof(_btnStrikeout):
                    toolStripButton = _btnStrikeout;
                    fontStyle = FontStyle.Strikeout;
                    return;
                default:
                    throw new ArgumentException("매개변수가 올바르지 않습니다.", "instanceName");
            }
        }

        private void ApplyFontStyle(FontStyle fontStyle) 
        { 
        
        }

        private void ApplyFontStyleToArea(ToolStripButton toolStripButton, FontStyle fontStyle)
        {
            if (string.IsNullOrEmpty(_richTextBox.SelectedText))
            {
                return;
            }

            int selectionStart = _richTextBox.SelectionStart;
            int selectionLength = _richTextBox.SelectionLength;

            _richTextBox.BeginUpdate();
            for (int i = 0; i < selectionLength; i++)
            {
                _richTextBox.SelectionStart = selectionStart + i;
                _richTextBox.SelectionLength = 1;
                var currentStyle = _richTextBox.SelectionFont.Style;
                var newStyle = toolStripButton.Checked ? currentStyle | fontStyle : currentStyle & ~fontStyle;
                string cacheKey = $"{_richTextBox.SelectionFont}_{newStyle}";

                if (_fontCache.ContainsKey(cacheKey))
                {
                    _richTextBox.SelectionFont = _fontCache[cacheKey];
                    continue;
                }

                _richTextBox.SelectionFont = new Font(_richTextBox.SelectionFont, newStyle);
            }
            _richTextBox.SelectionStart = selectionStart;
            _richTextBox.SelectionLength = selectionLength;
            _richTextBox.EndUpdate();
        }

        private void ApplyShortcut(FontStyle fontStyle)
        {
            if (string.IsNullOrEmpty(_richTextBox.SelectedText))
            {
                return;
            }

            int selectionStart = _richTextBox.SelectionStart;
            int selectionLength = _richTextBox.SelectionLength;

            _richTextBox.BeginUpdate();
            for (int i = 0; i < selectionLength; i++)
            {
                _richTextBox.SelectionStart = selectionStart + i;
                _richTextBox.SelectionLength = 1;
                var currentStyle = _richTextBox.SelectionFont.Style;
                var newStyle = currentStyle | fontStyle;
                string cacheKey = $"{_richTextBox.SelectionFont}_{newStyle}";

                if (_fontCache.ContainsKey(cacheKey))
                {
                    _richTextBox.SelectionFont = _fontCache[cacheKey];
                    continue;
                }

                _richTextBox.SelectionFont = new Font(_richTextBox.SelectionFont, newStyle);
            }
            _richTextBox.SelectionStart = selectionStart;
            _richTextBox.SelectionLength = selectionLength;
            _richTextBox.EndUpdate();
        }

        private void _btnHyperLink_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_richTextBox.SelectedText))
            {
                return;
            }

            string url = "https://www.naver.com/";
            // 선택된 텍스트의 RTF 형식 가져오기
            string selectedRtf = _richTextBox.SelectedRtf;

            // 선택된 텍스트를 하이퍼링크로 대체
            selectedRtf = selectedRtf.Replace(_richTextBox.SelectedText,
                $"{{\\field{{\\*\\fldinst HYPERLINK \"{url}\"}}{{\\fldrslt {_richTextBox.SelectedText}}}}}");

            // 리치텍스트박스의 내용을 수정된 RTF로 설정
            _richTextBox.SelectedRtf = selectedRtf;
        }

        private void _richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // TODO: 단축키 기능을 여기에 추가해야함. 단축키를 사용자가 커스텀할 수 있으면 더 좋다.
            #region Ctrl + B 볼드
            if (e.Control && e.KeyCode == Keys.B) 
            {
                ApplyShortcut(FontStyle.Bold);
                return;
            }
            #endregion

            #region Ctrl + I 이탤릭
            if (e.Control && e.KeyCode == Keys.I)
            {
                ApplyShortcut(FontStyle.Italic);
                e.SuppressKeyPress = true;
                return;
            }
            #endregion

            #region Ctrl + U 밑줄
            if (e.Control && e.KeyCode == Keys.U) 
            {
                ApplyShortcut(FontStyle.Underline);
                return;
            }
            #endregion

            #region Ctrl + F 찾기
            #endregion
        }

        private void _richTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            // TODO: 클릭되었을 때 이벤트가 발생하지 않는다.
            Process.Start(e.LinkText);
        }

        private void _richTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) 
            {
                return;
            }

            _contextMenuStrip.Show(_richTextBox, e.Location);

            bool isTextSelected = !string.IsNullOrEmpty(_richTextBox.SelectedText);
            _tsmiCut.Enabled = isTextSelected;
            _tsmiCopy.Enabled = isTextSelected;
            _tsmiPaste.Enabled = Clipboard.ContainsText() || Clipboard.ContainsImage();
        }

        private void _tsmiCut_Click(object sender, EventArgs e)
        {

        }

        private void _tsmiCopy_Click(object sender, EventArgs e)
        {

        }

        private void _tsmiPaste_Click(object sender, EventArgs e)
        {

        }
    }
}
