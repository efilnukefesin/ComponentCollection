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

    #region NumberOfPoints: The Number of Points to generate (higher number = smoother curves)
    [Tooltip("The Number of Points to generate (higher number = smoother curves)")]
    public int NumberOfPoints = 50;
    #endregion NumberOfPoints

    private LineRenderer lineRenderer;
    private List<Vector3> positions;

    #endregion Properties

    #region Methods

    #region Start
    protected override void Start()
    {
        base.Start();

        this.lineRenderer = this.GetComponent<LineRenderer>();

        this.lineRenderer.positionCount = this.NumberOfPoints;
        this.positions = new List<Vector3>();
        this.DrawLinearCurve(this.NumberOfPoints, this.Point0.position, this.Point1.position);
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
    /// <summary>
    /// Draws a linear Bezier Curve (= Line) between two points
    /// </summary>
    /// <param name="numberOfPoints">The number of points to generate</param>
    /// <param name="Start">The Starting position</param>
    /// <param name="End">The Ending position</param>
    private void DrawLinearCurve(int numberOfPoints, Vector3 Start, Vector3 End)
    {
        // add initial position
        this.positions.Add(Start);

        // calculate in-between positions
        for (int i = 1; i < numberOfPoints; i++)
        {
            float t = (float)i / (float)numberOfPoints;
            this.positions.Add(this.CalculateLinearBezierPoint(t, Start, End));
        }
        // add end position
        this.positions.Add(End);

        this.lineRenderer.SetPositions(this.positions.ToArray());
    }
    #endregion DrawLinearCurve

    //https://www.youtube.com/watch?v=Xwj8_z9OrFw
    // cubic: https://www.youtube.com/watch?v=AxhCKFbIkmM

    #endregion Methods


}
