using System.Collections.Generic;
//using UnityEngine;
using System;


// 今はただコピーしてきただけのコード。
// メソッドの int配列を可変長配列にする?


namespace Labo {
    public static class LayerMaskUtility {
        #region レイヤーマスクとは
        // layerMask が ゼロのときは すべてのレイヤーと衝突しない。(つまりすべて false)
        #endregion


        public enum Ignore { SpecifiedLayer, ExceptSpecifiedLayer }


        /// <summary>
        /// レイヤーマスクを生成する。指定したレイヤーを無視、または指定したレイヤー以外を無視する。
        /// </summary>
        /// <param name="ignoreType">指定レイヤーを無視するのか、指定レイヤー以外を無視するのか。</param>
        /// <param name="specifiedLayerIndexes"></param>
        public static int GenerateMask(Ignore ignoreType, int[] specifiedLayerIndexes) {
            int layerMask = 0;       // 0 だとすべてのレイヤーと衝突しない。-1だとすべてのレイヤーと衝突する(~0)。

            // マスクに穴を開けていく。
            foreach (int element in specifiedLayerIndexes) {
                int flag = 1 << element;                // 1(つまり一桁目がtrue)をn桁シフトすることで、n桁にtrueを入れる。
                layerMask = layerMask | flag;       // or演算子 
                // Debug.Log("Specified layer : " + LayerMask.LayerToName(element)); // デバッグ用に残しておく。
            }

            // 指定レイヤーを無視したい場合、生成したビットマスクを反転させる。
            if (ignoreType == Ignore.SpecifiedLayer) { layerMask = ~layerMask; }

            return layerMask;
        }

    }
}