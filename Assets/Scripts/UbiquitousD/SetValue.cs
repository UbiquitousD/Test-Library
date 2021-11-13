using UnityEngine;
using UnityEngine.UI;

namespace UbiquitousD
{
    public static class SetValue
    {
        /// <summary>
        /// 文字列に含まれる文字の数をカウント
        /// </summary>
        public static int CountOf(this string self, string chara)
        {
            var result = 0;
            for (var i = 0; i <= self.Length - chara.Length; i++)
            {
                if (self.Substring(i, chara.Length) == chara)
                {
                    result++;
                }
            }

            return result;
        }

        /// <summary>
        /// 子要素のアクティブ状態を一括で変更する
        /// </summary>
        /// <param name="decision">変更するアクティブ状態</param>
        /// <param name="exclusion">除外する項目名</param>
        public static void ChildObjectSetActive(this Transform transform, bool decision, params string[] exclusion)
        {
            if (exclusion.Length == 0)
            {
                for (var i = 0; i < transform.childCount; i++)
                {
                    transform.GetChild(i).gameObject.SetActive(decision);
                }
            }
            else
            {
                for (var i = 0; i < transform.childCount; i++)
                {
                    for (var j = 0; j < exclusion.Length; j++)
                    {
                        if (!(transform.GetChild(i).gameObject.name == exclusion[j]))
                        {
                            transform.GetChild(i).gameObject.SetActive(decision);
                        }
                    }
                }
            }
        }

        /// <summary>複数あるタグの中から指定したコンポーネントを探す</summary>
        public static void FindComponentFromMultipleTags<T>(this T type, string tagName)
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag(tagName);
            foreach (var obj in objects)
            {
                if (obj.TryGetComponent(out T t))
                {
                    type = t;
                    break;
                }
            }

            Debug.LogError($"コンポーネント名 {type} が見つかりませんでした(タグが設定されていることを確認してください)。");
        }
        
        public static void SetAlpha(this Image palette, float alpha) => palette.color = new Color(palette.color.r, palette.color.g, palette.color.b, alpha);
        public static void SetAlpha(this RawImage palette, float alpha) => palette.color = new Color(palette.color.r, palette.color.g, palette.color.b, alpha);
        public static void SetAlpha(this SpriteRenderer palette, float alpha) => palette.color = new Color(palette.color.r, palette.color.g, palette.color.b, alpha);
    }
}