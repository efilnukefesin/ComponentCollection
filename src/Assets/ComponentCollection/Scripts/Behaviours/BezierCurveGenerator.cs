using NET.efilnukefesin.Unity.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class BezierCurveGenerator : BaseBehaviour
{
    #region Properties

    public Transform Point0;
    public Transform Point1;

    private LineRenderer lineRenderer;

    private int numberOfPoints = 50;
    private List<Vector3> positions;

    #endregion Properties

    #region Methods

    #region Start
    private void Start()
    {
        this.lineRenderer = this.GetComponent<LineRenderer>();

        this.lineRenderer.positionCount = this.numberOfPoints;
        this.positions = new List<Vector3>();
        this.DrawLinearCurve();
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

    #region DrawLinearCurve
    private void DrawLinearCurve()
    {
        // add initial position
        this.positions.Add(this.Point0.position);

        // calculate in-between positions
        for (int i = 1; i < this.numberOfPoints; i++)
        {
            float t = (float)i / (float)this.numberOfPoints;
            this.positions.Add(this.CalculateLinearBezierPoint(t, this.Point0.position, this.Point1.position));
        }
        // add end position
        this.positions.Add(this.Point1.position);

        this.lineRenderer.SetPositions(this.positions.ToArray());
    }
    #endregion DrawLinearCurve

    #endregion Methods


}
