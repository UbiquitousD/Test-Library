using System.Globalization;
using static System.Globalization.CompareOptions;

namespace UbiquitousD
{
    public class CompareText
    {
        /// <summary>
        /// ローマ字の大文字・小文字を無視して比較
        /// </summary>
        public static bool En(string strA, string strB) => string.Compare(strA, strB, true) == 0;

        /// <summary>
        /// 日本語の全角・半角, ひらがな・カタカナを無視して比較
        /// </summary>
        public static bool Jp(string strA, string strB)
        {
            return CompareInfo.GetCompareInfo("ja-JP").Compare(strA, strB, IgnoreWidth | IgnoreKanaType) == 0;
        }

        /// <summary>
        /// ローマ字の大文字・小文字 / 日本語の全角・半角, ひらがな・カタカナを無視して比較
        /// </summary>
        public static bool JpAndEn(string strA, string strB)
        {
            return (CompareInfo.GetCompareInfo("ja-JP").Compare(strA, strB, IgnoreWidth | IgnoreKanaType) == 0) || 
                                                               (string.Compare(strA, strB, true) == 0);
        }
    }
}