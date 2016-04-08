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
        StringBuilder _errMsg = new StringBuilder();

        /// <summary>
        /// 結果
        /// </summary>
        string _convertText = string.Empty;

        /// <summary>
        /// エラーチェック
        /// </summary>
        private bool _errorChecke = false;

        #endregion

        #region ***** プロパティ ***** 

        /// <summary>
        /// エラーチェック
        /// </summary>
        public bool ErrorChecke
        {
            get
            {
                return _errorChecke;
            }
            set
            {
                _errorChecke = value;
            }
        }

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
            string dataString = string.Empty;
            _errMsg.Clear();
            _convertText = string.Empty;
            _enc = enc;
            bool errFlg = false;

            if (_enc == null)
            {
                _errMsg.AppendLine("読込ファイル形式の指定に誤りがあります。");
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

            if (ReadFile(dataFile, out dataString) == false)
            {
                return false;
            }

            if (ReadFile(templateFile, out template) == false)
            {
                return false;
            }

            StringBuilder sb = new StringBuilder();
            dataString = dataString.Replace("\r\n", "\n");
            dataString = dataString.Replace("\r", "\n");
            string[] dataLines = dataString.Split('\n');
            foreach (var line in dataLines)
            {
                if (line.Length == 0)
                {
                    continue;
                }
                string[] data = line.Split('\t');
                string addData = string.Empty;
                try
                {
                    addData = string.Format(template, data);  
                }
                catch (System.Exception)
                {
                    if (_errorChecke == false) continue;
                    _errMsg.AppendLine("文法に誤りがあります");
                    return false;
                }
                sb.Append(addData);
            }
            
            _convertText = sb.ToString();
            return true;
        }

        /// <summary>
        /// エラーメッセージ取得
        /// </summary>
        /// <returns></returns>
        public string GetErrorMessage()
        {
            return _errMsg.ToString();
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
                _errMsg.AppendLine(msg + "は指定されていません。");
                return false;
            }
            if (File.Exists(templateFile) == false)
            {
                _errMsg.AppendLine(msg + "は存在していません。");
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
                _errMsg.AppendLine("読込ファイル形式の指定に誤りがあります。");
                return false;
            }

            try
            {
                sr = new StreamReader(filename, _enc);
                body = sr.ReadToEnd();
            }
            catch
            {
                _errMsg.AppendLine(filename + "の読み込みに失敗しました。");
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