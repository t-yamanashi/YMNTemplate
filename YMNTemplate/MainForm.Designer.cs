namespace YMNTemplate
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.templateTextBox = new System.Windows.Forms.TextBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.convertTextBox = new System.Windows.Forms.TextBox();
            this.copyButton = new System.Windows.Forms.Button();
            this.templateSelectButton = new System.Windows.Forms.Button();
            this.dataSelectButton = new System.Windows.Forms.Button();
            this.fileFormatComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "テンプレートファイル";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "データファイル";
            // 
            // templateTextBox
            // 
            this.templateTextBox.AllowDrop = true;
            this.templateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.templateTextBox.Location = new System.Drawing.Point(112, 6);
            this.templateTextBox.Name = "templateTextBox";
            this.templateTextBox.Size = new System.Drawing.Size(389, 19);
            this.templateTextBox.TabIndex = 1;
            this.templateTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileTextBox_DragDrop);
            this.templateTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileTextBox_DragEnter);
            // 
            // dataTextBox
            // 
            this.dataTextBox.AllowDrop = true;
            this.dataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTextBox.Location = new System.Drawing.Point(112, 35);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(389, 19);
            this.dataTextBox.TabIndex = 4;
            this.dataTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileTextBox_DragDrop);
            this.dataTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileTextBox_DragEnter);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(6, 92);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "変換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // convertTextBox
            // 
            this.convertTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertTextBox.Location = new System.Drawing.Point(6, 121);
            this.convertTextBox.Multiline = true;
            this.convertTextBox.Name = "convertTextBox";
            this.convertTextBox.Size = new System.Drawing.Size(577, 390);
            this.convertTextBox.TabIndex = 11;
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(87, 92);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(75, 23);
            this.copyButton.TabIndex = 10;
            this.copyButton.Text = "コピー";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // templateSelectButton
            // 
            this.templateSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.templateSelectButton.Location = new System.Drawing.Point(507, 4);
            this.templateSelectButton.Name = "templateSelectButton";
            this.templateSelectButton.Size = new System.Drawing.Size(75, 23);
            this.templateSelectButton.TabIndex = 2;
            this.templateSelectButton.Text = "選択";
            this.templateSelectButton.UseVisualStyleBackColor = true;
            this.templateSelectButton.Click += new System.EventHandler(this.templateSelectButton_Click);
            // 
            // dataSelectButton
            // 
            this.dataSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataSelectButton.Location = new System.Drawing.Point(507, 33);
            this.dataSelectButton.Name = "dataSelectButton";
            this.dataSelectButton.Size = new System.Drawing.Size(75, 23);
            this.dataSelectButton.TabIndex = 5;
            this.dataSelectButton.Text = "選択";
            this.dataSelectButton.UseVisualStyleBackColor = true;
            this.dataSelectButton.Click += new System.EventHandler(this.dataSelectButton_Click);
            // 
            // fileFormatComboBox
            // 
            this.fileFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileFormatComboBox.FormattingEnabled = true;
            this.fileFormatComboBox.Location = new System.Drawing.Point(112, 60);
            this.fileFormatComboBox.Name = "fileFormatComboBox";
            this.fileFormatComboBox.Size = new System.Drawing.Size(142, 20);
            this.fileFormatComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "読込ファイル形式";
            // 
            // errorCheckBox
            // 
            this.errorCheckBox.AutoSize = true;
            this.errorCheckBox.Location = new System.Drawing.Point(260, 62);
            this.errorCheckBox.Name = "errorCheckBox";
            this.errorCheckBox.Size = new System.Drawing.Size(179, 16);
            this.errorCheckBox.TabIndex = 8;
            this.errorCheckBox.Text = "文法エラーがあるときは即時終了";
            this.errorCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 523);
            this.Controls.Add(this.errorCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileFormatComboBox);
            this.Controls.Add(this.dataSelectButton);
            this.Controls.Add(this.templateSelectButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.convertTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.templateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "YMNTemplate Ver 0.2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox templateTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox convertTextBox;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button templateSelectButton;
        private System.Windows.Forms.Button dataSelectButton;
        private System.Windows.Forms.ComboBox fileFormatComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox errorCheckBox;
    }
}

