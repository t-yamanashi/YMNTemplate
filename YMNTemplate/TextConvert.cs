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

        /// <summary>
        /// エンコーディング
        /// </summary>
        Encoding _enc = null;

        /// <summary>
        /// エラーメッセージ
        /// </summary>
        StringBuilder errMsg = new StringBuilder();

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
            if(ReadFile (dataFile, out ret) == false)
            {
                return ret;
            }

            return ret;
        }

        #endregion

        #region ***** privateメソッド ***** 

        /// <summary>
        /// ファイル読込
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private bool ReadFile(string filename, out string body)
        { 
            StreamReader sr = null;
            body = string.Empty;
            try
            {
                sr = new StreamReader(filename, _enc);
                body = sr.ReadToEnd();
            }
            catch
            {
                errMsg.AppendLine(filename + "の読み込みに失敗しました。");
                return false;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Dispose();
                }
            }
            
            return true;
        }

        #endregion

        #region ***** イベント ***** 

        #endregion


    }
}