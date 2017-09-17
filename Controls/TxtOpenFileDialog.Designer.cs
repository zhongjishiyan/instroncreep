namespace CustomControls
{
    partial class TxtOpenFileDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblColors = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblSizeValue = new System.Windows.Forms.Label();
            this.lblFormatValue = new System.Windows.Forms.Label();
            this.lblColorsValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(5, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ԥ��";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(436, 200);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblColors
            // 
            this.lblColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColors.Location = new System.Drawing.Point(2, 296);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(42, 13);
            this.lblColors.TabIndex = 3;
            this.lblColors.Text = "Colors:";
            // 
            // lblFormat
            // 
            this.lblFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormat.Location = new System.Drawing.Point(2, 260);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(42, 13);
            this.lblFormat.TabIndex = 4;
            this.lblFormat.Text = "Format:";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSize.Location = new System.Drawing.Point(2, 278);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(42, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size:";
            // 
            // lblSizeValue
            // 
            this.lblSizeValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSizeValue.Location = new System.Drawing.Point(50, 278);
            this.lblSizeValue.Name = "lblSizeValue";
            this.lblSizeValue.Size = new System.Drawing.Size(178, 13);
            this.lblSizeValue.TabIndex = 8;
            // 
            // lblFormatValue
            // 
            this.lblFormatValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormatValue.Location = new System.Drawing.Point(50, 260);
            this.lblFormatValue.Name = "lblFormatValue";
            this.lblFormatValue.Size = new System.Drawing.Size(178, 13);
            this.lblFormatValue.TabIndex = 7;
            // 
            // lblColorsValue
            // 
            this.lblColorsValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblColorsValue.Location = new System.Drawing.Point(50, 296);
            this.lblColorsValue.Name = "lblColorsValue";
            this.lblColorsValue.Size = new System.Drawing.Size(178, 13);
            this.lblColorsValue.TabIndex = 6;
            // 
            // TxtOpenFileDialog
            // 
            this.Controls.Add(this.lblSizeValue);
            this.Controls.Add(this.lblFormatValue);
            this.Controls.Add(this.lblColorsValue);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblColors);
            this.Name = "TxtOpenFileDialog";
            this.Size = new System.Drawing.Size(453, 318);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSizeValue;
        private System.Windows.Forms.Label lblFormatValue;
        private System.Windows.Forms.Label lblColorsValue;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}