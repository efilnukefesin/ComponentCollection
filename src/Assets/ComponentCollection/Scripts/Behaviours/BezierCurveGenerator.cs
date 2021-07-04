using Assets.ComponentCollection.Scripts.Enums;
using NET.efilnukefesin.Unity.Base;
using NET.efilnukefesin.Unity.Base.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(LineRenderer))]
public class BezierCurveGenerator : BaseBehaviour
{
    #region Properties

    public BezierTypes Type;

    public Transform Point0;
    public Transform Point1;

    public Transform Pivot0;
    public Transform Pivot1;

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
    }
    #endregion Start

    #region Update
    private void Update()
    {
        switch (this.Type)
        {
            case BezierTypes.Linear:
                this.DrawLinearCurve(this.NumberOfPoints, this.Point0.position, this.Point1.position);
                break;
            case BezierTypes.Quadratic:
                this.DrawQuadraticCurve(this.NumberOfPoints, this.Point0.position, this.Point1.position, this.Pivot0.position);
                break;
            case BezierTypes.Cubic:
                this.DrawCubicCurve(this.NumberOfPoints, this.Point0.position, this.Point1.position, this.Pivot0.position, this.Pivot1.position);
                break;
            default:
                break;
        }
    }
    #endregion Update

    #region DrawLinearCurve
    /// <summary>
    /// Draws a linear Bezier Curve (= Line) between two points
    /// </summary>
    /// <param name="numberOfPoints">The number of points to generate</param>
    /// <param name="Start">The Starting position</param>
    /// <param name="End">The Ending position</param>
    private void DrawLinearCurve(int numberOfPoints, Vector3 Start, Vector3 End)
    {
        this.positions.Clear();

        // add initial position
        this.positions.Add(Start);

        // calculate in-between positions
        for (int i = 1; i < numberOfPoints; i++)
        {
            float t = (float)i / (float)numberOfPoints;
            this.positions.Add(BezierHelper.CalculateLinearBezierPoint(t, Start, End));
        }
        // add end position
        this.positions.Add(End);

        this.lineRenderer.SetPositions(this.positions.ToArray());
    }
    #endregion DrawLinearCurve

    #region DrawQuadraticCurve
    private void DrawQuadraticCurve(int numberOfPoints, Vector3 Start, Vector3 End, Vector3 Pivot)
    {
        this.positions.Clear();

        // add initial position
        this.positions.Add(Start);

        // calculate in-between positions
        for (int i = 1; i < numberOfPoints; i++)
        {
            float t = (float)i / (float)numberOfPoints;
            this.positions.Add(BezierHelper.CalculateQuadraticCurveBezierPoint(t, Start, End, Pivot));
        }
        // add end position
        this.positions.Add(End);

        this.lineRenderer.SetPositions(this.positions.ToArray());
    }
    #endregion DrawQuadraticCurve

    #region DrawCubicCurve
    private void DrawCubicCurve(int numberOfPoints, Vector3 Start, Vector3 End, Vector3 Pivot0, Vector3 Pivot1)
    {
        this.positions.Clear();

        // add initial position
        this.positions.Add(Start);

        // calculate in-between positions
        for (int i = 1; i < numberOfPoints; i++)
        {
            float t = (float)i / (float)numberOfPoints;
            this.positions.Add(BezierHelper.CalculateCubicCurveBezierPoint(t, Start, End, Pivot0, Pivot1));
        }
        // add end position
        this.positions.Add(End);

        this.lineRenderer.SetPositions(this.positions.ToArray());
    }
    #endregion DrawCubicCurve

    #endregion Methods


}
