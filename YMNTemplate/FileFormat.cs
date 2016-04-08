/**************************************************************************************************
 * システム名: YMNTemplate(テンプレートツール)
 * クラス名: MainForm
* 役割: メイン画面
* 作成者: 山梨智之
*************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMNTemplate
{
    /// <summary>
    /// ファイルフォーマット
    /// </summary>
    public class FileFormat
    {
        #region ***** フィールド ***** 

        /// <summary>
        /// 表示名
        /// </summary>
        private string _dispName = String.Empty;

        /// <summary>
        /// エンコーディング
        /// </summary>
        private Encoding _encodingObject = null;

        #endregion

        #region ***** プロパティ ***** 

        /// <summary>
        /// 表示名
        /// </summary>
        public string DispName
        {
            get
            {
                return _dispName;
            }
        }

        /// <summary>
        /// エンコーディング
        /// </summary>
        public Encoding EncodingObject
        {
            get
            {
                return _encodingObject;
            }
        }

        #endregion

        #region ***** publicメソッド ***** 

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="dispname"></param>
        /// <param name="encoding"></param>
        public FileFormat(string dispname, Encoding encoding)
        {
            _dispName = dispname;
            _encodingObject = encoding;
        }

        public static List<FileFormat> GetFileFormatList()
        {
            List<FileFormat> list = new List<FileFormat>();
            list.Add(new FileFormat("Shift-JIS", Encoding.GetEncoding("Shift_JIS")));
            list.Add(new FileFormat("UTF8", Encoding.UTF8));
            return list;
        }

        #endregion

        #region ***** privateメソッド ***** 

        #endregion

        #region ***** イベント ***** 

        #endregion


    }
}
