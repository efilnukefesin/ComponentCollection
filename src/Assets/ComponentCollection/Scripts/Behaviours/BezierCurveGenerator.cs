using NET.efilnukefesin.Unity.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class BezierCurveGenerator : BaseBehaviour
{

    #region Properties

    private LineRenderer lineRenderer;

    #endregion Properties

    #region Methods

    #region Start
    private void Start()
    {
        this.lineRenderer = this.GetComponent<LineRenderer>();
    }
    #endregion Start

    #region CalculateLinearBezierPoint: Calculate a point on a linear Bezier 'curve'
    /// <summary>
    /// Calculate a point on a linear Bezier 'curve'
    /// </summary>
    /// <param name="t">0-1, indicates the position of the result between Point0 and Point1</param>
    /// <param name="Point0">The first and starting point of the line</param>
    /// <param name="Point1">The last and ending point of the line</param>
    /// <returns></returns>
    private Vector3 CalculateLinearBezierPoint(float t, Vector3 Point0, Vector3 Point1)
    {
        Vector3 result = Point0 + t * (Point1 - Point0);
        return result;
    }
    #endregion CalculateLinearBezierPoint

    #endregion Methods


}
