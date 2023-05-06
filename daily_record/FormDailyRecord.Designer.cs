
namespace daily_record
{
    partial class FormDailyRecord
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this._ucTextEditor = new daily_record.UserControlTextEditor();
            this.SuspendLayout();
            // 
            // _ucTextEditor
            // 
            this._ucTextEditor.Location = new System.Drawing.Point(144, 120);
            this._ucTextEditor.Name = "_ucTextEditor";
            this._ucTextEditor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ucTextEditor.Size = new System.Drawing.Size(644, 425);
            this._ucTextEditor.TabIndex = 0;
            // 
            // FormDailyRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 686);
            this.Controls.Add(this._ucTextEditor);
            this.MaximizeBox = false;
            this.Name = "FormDailyRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "일정기록 v0.1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTextEditor _ucTextEditor;
    }
}

