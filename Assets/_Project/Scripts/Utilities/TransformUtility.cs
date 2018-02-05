using System.Collections.Generic;
using UnityEngine;
using System;


namespace Labo{
    public static class TransformUtility{
        /// <summary>
        /// 上下左右の回転のみで、Z軸の(ドアノブをひねるような)回転はしないRotate。
        /// </summary>
        /// <param name="objectToRotate"></param>
        /// <param name="horizontalRotation"></param>
        /// <param name="verticalRotation"></param>
        public static void AntiTiltRotate(GameObject objectToRotate, float horizontalRotation, float verticalRotation) {
            // 回転がローカル軸に対してか、ワールド軸に対してか指定することができる。
            // Y軸方向の回転はワールド軸でないと、あちこち回転しているうちにオブジェクトが傾いてしまう。
            objectToRotate.transform.Rotate(0, horizontalRotation, 0, Space.World);
            objectToRotate.transform.Rotate(verticalRotation, 0, 0);
        }
    }
}