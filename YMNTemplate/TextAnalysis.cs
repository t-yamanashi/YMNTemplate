/***************************************************************************************************
* システム名: YMNWrite(テンプレートツール)
*   クラス名: TextAnalysis
*       役割: 構文解析
* 　  作成者: 山梨智之
****************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YMNTemplate
{
    public class TextAnalysis
    {
        #region ***** フィールド ***** 
        /// <summary>
        /// 構文
        /// </summary>
        private String _syntax;

        #endregion

        #region ***** プロパティ ***** 
        /// <summary>
        /// 構文
        /// </summary>
        public String Syntax
        {
            get
            {
                return _syntax;
            }
            set
            {
                _syntax = value;
            }
        }
        #endregion

        #region ***** publicメソッド ***** 
        
        /// <summary>
        /// 解析実行
        /// </summary>
        public void Execution()
        {
            List<Object> objList = new List<object>();
            bool koubunFlg = false;
            int st = 0;
            int kst = 0;
            for (int i = 0; i < _syntax.Length; i++)
            {
                char nowChar = _syntax[i];
                if (nowChar == '{')
                {
                    koubunFlg = true;
                }
                if (koubunFlg)
                {

                }

            }
        }
        
        #endregion

        #region ***** privateメソッド ***** 

        #endregion

        #region ***** イベント ***** 

        #endregion


    }
}