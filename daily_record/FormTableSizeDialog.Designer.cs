
namespace daily_record
{
    partial class FormTableSizeDialog
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
            this._numericRow = new System.Windows.Forms.NumericUpDown();
            this._numericColumn = new System.Windows.Forms.NumericUpDown();
            this._btnConfirm = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._lbRow = new System.Windows.Forms.Label();
            this._lbColumn = new System.Windows.Forms.Label();
            this._lbWidth = new System.Windows.Forms.Label();
            this._lbHeight = new System.Windows.Forms.Label();
            this._numericHeight = new System.Windows.Forms.NumericUpDown();
            this._numericWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this._numericRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // _numericRow
            // 
            this._numericRow.Location = new System.Drawing.Point(14, 37);
            this._numericRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numericRow.Name = "_numericRow";
            this._numericRow.Size = new System.Drawing.Size(84, 21);
            this._numericRow.TabIndex = 0;
            this._numericRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _numericColumn
            // 
            this._numericColumn.Location = new System.Drawing.Point(14, 85);
            this._numericColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._numericColumn.Name = "_numericColumn";
            this._numericColumn.Size = new System.Drawing.Size(84, 21);
            this._numericColumn.TabIndex = 1;
            this._numericColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _btnConfirm
            // 
            this._btnConfirm.Location = new System.Drawing.Point(14, 141);
            this._btnConfirm.Name = "_btnConfirm";
            this._btnConfirm.Size = new System.Drawing.Size(75, 23);
            this._btnConfirm.TabIndex = 2;
            this._btnConfirm.Text = "확인";
            this._btnConfirm.UseVisualStyleBackColor = true;
            this._btnConfirm.Click += new System.EventHandler(this._btnConfirm_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(95, 141);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "취소";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _lbRow
            // 
            this._lbRow.AutoSize = true;
            this._lbRow.Location = new System.Drawing.Point(12, 22);
            this._lbRow.Name = "_lbRow";
            this._lbRow.Size = new System.Drawing.Size(45, 12);
            this._lbRow.TabIndex = 4;
            this._lbRow.Text = "열 개수";
            // 
            // _lbColumn
            // 
            this._lbColumn.AutoSize = true;
            this._lbColumn.Location = new System.Drawing.Point(12, 70);
            this._lbColumn.Name = "_lbColumn";
            this._lbColumn.Size = new System.Drawing.Size(45, 12);
            this._lbColumn.TabIndex = 5;
            this._lbColumn.Text = "행 개수";
            // 
            // _lbWidth
            // 
            this._lbWidth.AutoSize = true;
            this._lbWidth.Location = new System.Drawing.Point(119, 70);
            this._lbWidth.Name = "_lbWidth";
            this._lbWidth.Size = new System.Drawing.Size(29, 12);
            this._lbWidth.TabIndex = 6;
            this._lbWidth.Text = "너비";
            // 
            // _lbHeight
            // 
            this._lbHeight.AutoSize = true;
            this._lbHeight.Location = new System.Drawing.Point(119, 22);
            this._lbHeight.Name = "_lbHeight";
            this._lbHeight.Size = new System.Drawing.Size(29, 12);
            this._lbHeight.TabIndex = 7;
            this._lbHeight.Text = "높이";
            // 
            // _numericHeight
            // 
            this._numericHeight.Location = new System.Drawing.Point(121, 37);
            this._numericHeight.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this._numericHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._numericHeight.Name = "_numericHeight";
            this._numericHeight.Size = new System.Drawing.Size(116, 21);
            this._numericHeight.TabIndex = 8;
            this._numericHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // _numericWidth
            // 
            this._numericWidth.Location = new System.Drawing.Point(121, 85);
            this._numericWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this._numericWidth.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this._numericWidth.Name = "_numericWidth";
            this._numericWidth.Size = new System.Drawing.Size(116, 21);
            this._numericWidth.TabIndex = 9;
            this._numericWidth.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // FormTableSizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 177);
            this.Controls.Add(this._numericWidth);
            this.Controls.Add(this._numericHeight);
            this.Controls.Add(this._lbHeight);
            this.Controls.Add(this._lbWidth);
            this.Controls.Add(this._lbColumn);
            this.Controls.Add(this._lbRow);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnConfirm);
            this.Controls.Add(this._numericColumn);
            this.Controls.Add(this._numericRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTableSizeDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "표";
            ((System.ComponentModel.ISupportInitialize)(this._numericRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numericWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown _numericRow;
        private System.Windows.Forms.NumericUpDown _numericColumn;
        private System.Windows.Forms.Button _btnConfirm;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label _lbRow;
        private System.Windows.Forms.Label _lbColumn;
        private System.Windows.Forms.Label _lbWidth;
        private System.Windows.Forms.Label _lbHeight;
        private System.Windows.Forms.NumericUpDown _numericHeight;
        private System.Windows.Forms.NumericUpDown _numericWidth;
    }
}