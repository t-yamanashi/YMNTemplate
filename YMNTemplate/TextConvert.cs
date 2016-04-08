/**************************************************************************************************
* システム名: YMNTemplate(テンプレートツール)
*   クラス名: TextConvert
*       役割: テキスト変換クラス
*     作成者: 山梨智之
*************************************************************************************************/

using System.IO;
using System.Text;

namespace YMNTemplate
{
    public class TextConvert
    {

        #region ***** フィールド ***** 

        #endregion

        #region ***** プロパティ ***** 

        #endregion

        #region ***** publicメソッド ***** 
        public string Convert(Encoding enc, string templateFile, string dataFile)
        {
            string ret = string.Empty;
            if (enc == null)
            {
                return ret;
            }
            StreamReader sr = new StreamReader(dataFile, enc);
            ret = sr.ReadToEnd();
            sr.Dispose();
            return ret;
        }
        #endregion

        #region ***** privateメソッド ***** 

        #endregion

        #region ***** イベント ***** 

        #endregion


    }
}