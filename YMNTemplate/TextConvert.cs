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

        string _convertText = string.Empty;

        #endregion

        #region ***** プロパティ ***** 

        #endregion

        #region ***** publicメソッド ***** 

        /// <summary>
        /// 変換実行
        /// </summary>
        /// <param name="enc"></param>
        /// <param name="templateFile"></param>
        /// <param name="dataFile"></param>
        /// <returns></returns>
        public bool Convert(Encoding enc, string templateFile, string dataFile)
        {
            string template = string.Empty;
            string data = string.Empty;
            errMsg.Clear();
            _convertText = string.Empty;
            _enc = enc;
            bool errFlg = false;

            if (_enc == null)
            {
                errMsg.AppendLine("読込ファイル形式の指定に誤りがあります。");
                errFlg = true;
            }
     
            if (FileExists(templateFile, "テンプレートファイル") == false)
            {
                errFlg = true;
            }

            if (FileExists(dataFile, "データファイル") == false)
            {
                errFlg = true;
            }

            if (errFlg)
            {
                return false;
            }

            if (ReadFile(dataFile, out data) == false)
            {
                return false;
            }

            if (ReadFile(templateFile, out template) == false)
            {
                return false;
            }

            _convertText = template;
            return true;
        }



        /// <summary>
        /// エラーメッセージ取得
        /// </summary>
        /// <returns></returns>
        public string GetErrorMessage()
        {
            return errMsg.ToString();
        }

        /// <summary>
        /// 変換結果取得
        /// </summary>
        /// <returns></returns>
        public string GetConvertText()
        {
            return _convertText;
        }

        #endregion

        #region ***** privateメソッド ***** 

        /// <summary>
        /// ファイル存在チェック
        /// </summary>
        /// <param name="templateFile"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool FileExists(string templateFile, string msg)
        {
            if (templateFile.Length == 0)
            {
                errMsg.AppendLine(msg + "は指定されていません。");
                return false;
            }
            if (File.Exists(templateFile) == false)
            {
                errMsg.AppendLine(msg + "は存在していません。");
                return false;
            }

            return true;
        }

        /// <summary>
        /// ファイル読込
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        private bool ReadFile(string filename, out string body)
        { 
            StreamReader sr = null;
            body = string.Empty;
            if (_enc == null)
            {
                errMsg.AppendLine("読込ファイル形式の指定に誤りがあります。");
                return false;
            }

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