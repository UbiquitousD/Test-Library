using UnityEngine;

namespace UbiquitousD
{
    public class SimpleMath
    {
        /// <summary>
        /// 基点となるポジションから指定した範囲内にターゲットが存在するか
        /// </summary>
        /// <param name="basePosition">基点となるポジション</param>
        /// <param name="targetPosition">ターゲットのポジション</param>
        /// <param name="searchRange">探索範囲</param>
        public static bool InRange(Vector2 basePosition, Vector2 targetPosition, float searchRange)
        {
            // 基点となる座標から対象の座標を引き、各座標の差を求める
            Vector2 difference = basePosition - targetPosition;
            // 各座標の２乗を足し，ルート化前の状態にする
            double distance = (difference.x * difference.x) + (difference.y * difference.y);
            // 探索範囲を２乗したものを比較し，その距離内だった場合はtrue
            return distance < (searchRange * searchRange);
        }

        public static float GetDistance((float x, float y) vector1, (float x, float y) vector2)
        {
            // 作成中
            return 1.0f;
        }

        /// <summary>
        /// 入力された数値の範囲を別の範囲へと変更する
        /// </summary>
        /// <param name="value">変更したい数値</param>
        /// <param name="start1">現在の範囲の始まり</param>
        /// <param name="end1">現在の範囲の終わり</param>
        /// <param name="start2">変更する範囲の始まり</param>
        /// <param name="end2">変更する範囲の終わり</param>
        /// <remarks>例：「-80 ～ 20」で入力された範囲を「0 ～ 100」に変更する等</remarks>
        public static float ChangeTheValueRange(float value, float start1, float end1, float start2, float end2)
        {
            return start2 + (end2 - start2) * ((value - start1) / (end1 - start1));
        }
    }
}
