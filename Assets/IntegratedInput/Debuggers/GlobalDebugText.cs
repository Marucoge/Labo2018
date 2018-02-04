using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;


namespace IntegratedInput{
    public class GlobalDebugText : MonoBehaviour{
        private Text tex;

        private void Start() {
            tex = GetComponent<Text>();
        }

        private void Update() {
            this.tex.text =
                "StickL: " + InputIntegrator.LeftStickInput + Environment.NewLine +
                "StickR: " + InputIntegrator.RightStickInput + Environment.NewLine +
                "Circle: " + InputIntegrator.CircleButton + Environment.NewLine +
                "Cross: " + InputIntegrator.CrossButton + Environment.NewLine +
                "Square: " + InputIntegrator.SquareButton + Environment.NewLine +
                "Triangle: " + InputIntegrator.TriangleButton + Environment.NewLine;

        }
    }
}