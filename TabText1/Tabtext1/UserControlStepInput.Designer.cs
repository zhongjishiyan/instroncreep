namespace TabHeaderDemo
{
    partial class UserControlStepInput
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpback = new System.Windows.Forms.TableLayoutPanel();
            this.numvalue = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.cbounit = new System.Windows.Forms.ComboBox();
            this.tlpback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numvalue)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpback
            // 
            this.tlpback.BackColor = System.Drawing.Color.White;
            this.tlpback.ColumnCount = 2;
            this.tlpback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpback.Controls.Add(this.numvalue, 0, 0);
            this.tlpback.Controls.Add(this.cbounit, 1, 0);
            this.tlpback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpback.Location = new System.Drawing.Point(0, 0);
            this.tlpback.Margin = new System.Windows.Forms.Padding(0);
            this.tlpback.Name = "tlpback";
            this.tlpback.RowCount = 1;
            this.tlpback.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpback.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpback.Size = new System.Drawing.Size(577, 26);
            this.tlpback.TabIndex = 4;
            // 
            // numvalue
            // 
            this.numvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numvalue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numvalue.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.numvalue.Location = new System.Drawing.Point(3, 3);
            this.numvalue.Name = "numvalue";
            this.numvalue.Size = new System.Drawing.Size(282, 21);
            this.numvalue.TabIndex = 0;
            this.numvalue.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.numspeed1_AfterChangeValue);
            // 
            // cbounit
            // 
            this.cbounit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbounit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbounit.FormattingEnabled = true;
            this.cbounit.Location = new System.Drawing.Point(291, 3);
            this.cbounit.Name = "cbounit";
            this.cbounit.Size = new System.Drawing.Size(283, 20);
            this.cbounit.TabIndex = 1;
            // 
            // UserControlStepInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpback);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlStepInput";
            this.Size = new System.Drawing.Size(577, 26);
            this.tlpback.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numvalue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpback;
        public NationalInstruments.UI.WindowsForms.NumericEdit numvalue;
        public System.Windows.Forms.ComboBox cbounit;
    }
}
