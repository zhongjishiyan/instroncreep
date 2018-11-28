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
            this.numspeed1 = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.cbospeedunit1 = new System.Windows.Forms.ComboBox();
            this.tlpback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numspeed1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpback
            // 
            this.tlpback.BackColor = System.Drawing.Color.White;
            this.tlpback.ColumnCount = 2;
            this.tlpback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpback.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpback.Controls.Add(this.numspeed1, 0, 0);
            this.tlpback.Controls.Add(this.cbospeedunit1, 1, 0);
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
            // numspeed1
            // 
            this.numspeed1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numspeed1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numspeed1.Location = new System.Drawing.Point(3, 3);
            this.numspeed1.Name = "numspeed1";
            this.numspeed1.Size = new System.Drawing.Size(282, 21);
            this.numspeed1.TabIndex = 0;
            this.numspeed1.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.numspeed1_AfterChangeValue);
            // 
            // cbospeedunit1
            // 
            this.cbospeedunit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbospeedunit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbospeedunit1.FormattingEnabled = true;
            this.cbospeedunit1.Location = new System.Drawing.Point(291, 3);
            this.cbospeedunit1.Name = "cbospeedunit1";
            this.cbospeedunit1.Size = new System.Drawing.Size(283, 20);
            this.cbospeedunit1.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.numspeed1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpback;
        private NationalInstruments.UI.WindowsForms.NumericEdit numspeed1;
        private System.Windows.Forms.ComboBox cbospeedunit1;
    }
}
