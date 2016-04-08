/**************************************************************************************************
 * システム名: YMNTemplate(テンプレートツール)
 *   クラス名: MainForm
 *       役割: メイン画面
 * 　  作成者: 山梨智之
 *************************************************************************************************/

using System;
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

        #endregion

        #region ***** イベント ***** 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {

        }
 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyButton_Click(object sender, EventArgs e)
        {

        }
 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fileTextBox_DragDrop(object sender, DragEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;        
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            textBox.Text = files[0];
        }

        #endregion

    }
}
