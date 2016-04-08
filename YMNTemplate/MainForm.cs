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

        private void convertButton_Click(object sender, EventArgs e)
        {

        }
 
        private void copyButton_Click(object sender, EventArgs e)
        {

        }
 
        private void templateTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }

        private void templateTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            Console.WriteLine(files[0]);
        }

        #endregion

    }
}
