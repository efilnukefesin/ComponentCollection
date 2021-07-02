using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(BezierCurveGenerator))]
public class BezierCurveGeneratorEditor : Editor
{
    #region Properties

    #endregion Properties

    #region Methods

    #region OnInspectorGUI

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        BezierCurveGenerator bezierCurveGenerator = this.target as BezierCurveGenerator;

        switch (bezierCurveGenerator.Type)
        {
            case Assets.ComponentCollection.Scripts.Enums.BezierTypes.Linear:
                // show two points
                break;
            case Assets.ComponentCollection.Scripts.Enums.BezierTypes.Quadratic:
                // show two points and one pivot
                break;
            case Assets.ComponentCollection.Scripts.Enums.BezierTypes.Cubic:
                // show two points and two pivots
                break;
            default:
                break;
        }
        /*
        myScript.flag = GUILayout.Toggle(myScript.flag, "Flag");

        if (myScript.flag)
        {
            myScript.i = EditorGUILayout.IntSlider("I field:", myScript.i, 1, 100);
        }
        */
    }
    #endregion OnInspectorGUI

    #endregion Methods
}
