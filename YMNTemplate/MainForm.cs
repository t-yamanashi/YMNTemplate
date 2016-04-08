/**************************************************************************************************
 * システム名: YMNTemplate(テンプレートツール)
 *   クラス名: MainForm
 *       役割: メイン画面
 * 　  作成者: 山梨智之
 *************************************************************************************************/

using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace YMNTemplate
{
    /// <summary>
    /// メイン画面
    /// </summary>
    public partial class MainForm : Form
    {
        #region ***** フィールド ***** 

        #endregion

        #region ***** プロパティ ***** 

        #endregion

        #region ***** publicメソッド ***** 

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region ***** privateメソッド ***** 

        /// <summary>
        /// ダイアログを開いてファイル選択
        /// </summary>
        /// <param name="textBox"></param>
        private static void SelectFile(TextBox textBox)
        {
            if (textBox == null)
            {
                return;
            }

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox.Text = fileDialog.FileName;
                }
            }
        }

        #endregion

        #region ***** イベント ***** 

        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            fileFormatComboBox.DisplayMember = "DispName";
            fileFormatComboBox.ValueMember = "EncodingObject";
            fileFormatComboBox.DataSource = FileFormat.GetFileFormatList();
        }

        /// <summary>
        /// 変換ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            Encoding enc = fileFormatComboBox.SelectedValue as Encoding;
            TextConvert conv = new TextConvert();
            if (conv.Convert(enc, templateTextBox.Text, dataTextBox.Text))
            {
                convertTextBox.Text = conv.GetConvertText();
            }
            MessageBox.Show(conv.GetErrorMessage(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /// <summary>
        /// コピーボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(convertTextBox.Text);
        }

        /// <summary>
        /// テキストボックスにファイルがドラッグ時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// テキストボックスにファイルがドラッグ完了時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileTextBox_DragDrop(object sender, DragEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;
            String[] files = e.Data.GetData(DataFormats.FileDrop) as String[];
            if (files == null ||
                files.Length != 1) 
            {
                return;
            }

            textBox.Text = files[0];
        }

        /// <summary>
        /// テンプレートファイル選択ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void templateSelectButton_Click(object sender, EventArgs e)
        {
            SelectFile(templateTextBox);
        }

        /// <summary>
        /// データファイル選択ボタンクリック時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataSelectButton_Click(object sender, EventArgs e)
        {
            SelectFile(dataTextBox);
        }


        #endregion

    }
}
