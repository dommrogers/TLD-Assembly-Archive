using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPath : MonoBehaviour
{
	public enum PointModes
	{
		Transform,
		ControlPoints,
		FOV,
		Events,
		Speed,
		Delay,
		Ease,
		Orientations,
		Tilt,
		AddPathPoints,
		RemovePathPoints,
		AddOrientations,
		RemoveOrientations,
		TargetOrientation,
		AddFovs,
		RemoveFovs,
		AddTilts,
		RemoveTilts,
		AddEvents,
		RemoveEvents,
		AddSpeeds,
		RemoveSpeeds,
		AddDelays,
		RemoveDelays,
		Options
	}

	public enum Interpolation
	{
		Linear,
		SmoothStep,
		CatmullRom,
		Hermite,
		Bezier
	}

	public delegate void RecalculateCurvesHandler();

	public delegate void PathPointAddedHandler(CameraPathControlPoint point);

	public delegate void PathPointRemovedHandler(CameraPathControlPoint point);

	public delegate void CheckStartPointCullHandler(float percentage);

	public delegate void CheckEndPointCullHandler(float percentage);

	public delegate void CleanUpListsHandler();

	public static float CURRENT_VERSION_NUMBER;

	public float version;

	private List<CameraPathControlPoint> _points;

	private Interpolation _interpolation;

	private bool initialised;

	private float _storedTotalArcLength;

	private float[] _storedArcLengths;

	private float[] _storedArcLengthsFull;

	private Vector3[] _storedPoints;

	private float[] _normalisedPercentages;

	private float _storedPointResolution;

	private int _storedValueArraySize;

	private Vector3[] _storedPathDirections;

	private float _directionWidth;

	private CameraPathControlPoint[] _pointALink;

	private CameraPathControlPoint[] _pointBLink;

	private CameraPathOrientationList _orientationList;

	private CameraPathFOVList _fovList;

	private CameraPathTiltList _tiltList;

	private CameraPathSpeedList _speedList;

	private CameraPathEventList _eventList;

	private CameraPathDelayList _delayList;

	private bool _addOrientationsWithPoints;

	private bool _looped;

	private bool _normalised;

	private Bounds _pathBounds;

	public float hermiteTension;

	public float hermiteBias;

	public GameObject editorPreview;

	public int selectedPoint;

	public PointModes pointMode;

	public float addPointAtPercent;

	private float _aspect;

	private int _previewResolution;

	public float drawDistance;

	private int _displayHeight;

	private CameraPath _nextPath;

	private bool _interpolateNextPath;

	public bool showGizmos;

	public Color selectedPathColour;

	public Color unselectedPathColour;

	public Color selectedPointColour;

	public Color unselectedPointColour;

	public bool showOrientationIndicators;

	public float orientationIndicatorUnitLength;

	public Color orientationIndicatorColours;

	public bool autoSetStoedPointRes;

	public bool enableUndo;

	public bool showPreview;

	public bool enablePreviews;

	public CameraPathControlPoint Item
	{
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
		[CallsUnknownMethods(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		get
		{
			return null;
		}
	}

	public int numberOfPoints
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public int realNumberOfPoints
	{
		[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
		[CalledBy(Type = typeof(CameraPath), Member = "CalculateNormalisedPercentage")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(int);
		}
	}

	public int numberOfCurves
	{
		[CallerCount(Count = 27)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
		get
		{
			return default(int);
		}
	}

	public bool loop
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		set
		{
		}
	}

	public float pathLength
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
	}

	public CameraPathOrientationList orientationList
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public CameraPathFOVList fovList
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public CameraPathTiltList tiltList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public CameraPathSpeedList speedList
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public CameraPathEventList eventList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public CameraPathDelayList delayList
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public Bounds bounds
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Bounds);
		}
	}

	public int storedValueArraySize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
	}

	public CameraPathControlPoint[] pointALink
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public CameraPathControlPoint[] pointBLink
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
	}

	public Vector3[] storedPoints
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public bool normalised
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Interpolation interpolation
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Interpolation);
		}
		[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public CameraPath nextPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool interpolateNextPath
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		set
		{
		}
	}

	public bool shouldInterpolateNextPath
	{
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetPoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
		[CalledBy(Type = typeof(CameraPath), Member = "get_numberOfPoints")]
		[CalledBy(Type = typeof(CameraPath), Member = "get_Item")]
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CalledBy(Type = typeof(CameraPath), Member = "get_Item")]
		get
		{
			return default(bool);
		}
	}

	public float storedPointResolution
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public float directionWidth
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int displayHeight
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float aspect
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public int previewResolution
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public event RecalculateCurvesHandler RecalculateCurvesEvent
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event PathPointAddedHandler PathPointAddedEvent
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "Init")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "Init")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "Init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 3)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 3)]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CleanUp")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "CleanUp")]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "CleanUp")]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		remove
		{
		}
	}

	public event PathPointRemovedHandler PathPointRemovedEvent
	{
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		remove
		{
		}
	}

	public event CheckStartPointCullHandler CheckStartPointCullEvent
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event CheckEndPointCullHandler CheckEndPointCullEvent
	{
		[CompilerGenerated]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		add
		{
		}
		[CompilerGenerated]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event CleanUpListsHandler CleanUpListsEvent
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float StoredArcLength(int curve)
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public int StoredValueIndex(float percentage)
	{
		return default(int);
	}

	[Calls(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_localPosition")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	public CameraPathControlPoint AddPoint(Vector3 position)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CameraPath), Member = "Init")]
	[CalledBy(Type = typeof(CameraPath), Member = "Init")]
	[CalledBy(Type = typeof(CameraPath), Member = "Init")]
	[CalledBy(Type = typeof(CameraPath), Member = "Init")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	public void AddPoint(CameraPathControlPoint point)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void InsertPoint(CameraPathControlPoint point, int index)
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public CameraPathControlPoint InsertPoint(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "RemovePoint")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	public void RemovePoint(int index)
	{
	}

	[Calls(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 3)]
	public bool RemovePoint(string pointName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(CameraPath), Member = "RemovePoint")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[Calls(Type = typeof(CameraPath), Member = "RemovePoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPointIndex")]
	public void RemovePoint(Vector3 pointPosition)
	{
	}

	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	public void RemovePoint(CameraPathControlPoint point)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	private float ParsePercentage(float percentage)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 9)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	public float CalculateNormalisedPercentage(float percentage)
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float DeNormalisePercentage(float normalisedPercent)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	public int GetPointNumber(float percentage)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	public Vector3 GetPathPosition(float percentage)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CPMath), Member = "CalculateHermite")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CPMath), Member = "CalculateCatmullRom")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CPMath), Member = "CalculateBezier")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPointWorld")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 20)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPointWorld")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	public Vector3 GetPathPosition(float percentage, bool ignoreNormalisation)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[CallerCount(Count = 0)]
	public Quaternion GetPathRotation(float percentage, bool ignoreNormalisation)
	{
		return default(Quaternion);
	}

	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[CallerCount(Count = 0)]
	public Vector3 GetPathDirection(float percentage)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AutoSetTilt")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
	[CallerCount(Count = 7)]
	public Vector3 GetPathDirection(float percentage, bool normalisePercent)
	{
		return default(Vector3);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[CallerCount(Count = 0)]
	public float GetPathTilt(float percentage)
	{
		return default(float);
	}

	[Calls(Type = typeof(CameraPathFOVList), Member = "GetValue")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public float GetPathFOV(float percentage)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathFOVList), Member = "GetValue")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	public float GetPathOrthographicSize(float percentage)
	{
		return default(float);
	}

	[Calls(Type = typeof(CameraPathSpeedList), Member = "GetSpeed")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[CallsUnknownMethods(Count = 1)]
	public float GetPathSpeed(float percentage)
	{
		return default(float);
	}

	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	public float GetPathEase(float percentage)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	public void CheckEvents(float percentage)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public float GetPathPercentage(CameraPathControlPoint point)
	{
		return default(float);
	}

	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallerCount(Count = 0)]
	public float GetPathPercentage(int pointIndex)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public int GetNearestPointIndex(float percentage)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[CallerCount(Count = 0)]
	public int GetLastPointIndex(float percentage, bool isNormalised)
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNextPointIndex(float percentage, bool isNormalised)
	{
		return default(int);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CallerCount(Count = 0)]
	public float GetCurvePercentage(CameraPathControlPoint pointA, CameraPathControlPoint pointB, float percentage)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetCurvePercentage(CameraPathPoint pointA, CameraPathPoint pointB, float percentage)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointAddedEvent")]
	public float GetCurvePercentage(CameraPathPoint point)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public float GetOutroEasePercentage(CameraPathDelay point)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetIntroEasePercentage(CameraPathDelay point)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	public float GetPathPercentage(CameraPathControlPoint pointA, CameraPathControlPoint pointB, float curvePercentage)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public float GetPathPercentage(float pointA, float pointB, float curvePercentage)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetStoredPoint(float percentage)
	{
		return default(int);
	}

	[Calls(Type = typeof(CameraPath), Member = "Init")]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 43)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "InitialiseLists")]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "set_interpolateNextPath")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CameraPath), Member = "set_loop")]
	[CalledBy(Type = typeof(CameraPath), Member = "set_interpolation")]
	[CalledBy(Type = typeof(CameraPath), Member = "set_nextPath")]
	[CalledBy(Type = typeof(CameraPath), Member = "AddPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "AddPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "InsertPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "InsertPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 110)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "CalculateNormalisedPercentage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPointWorld")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPointWorld")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPointWorld")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPointWorld")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	public void RecalculateStoredValues()
	{
	}

	[Calls(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[CallerCount(Count = 0)]
	public float GetNearestPoint(Vector3 fromPostition)
	{
		return default(float);
	}

	[Calls(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[CallerCount(Count = 0)]
	public float GetNearestPoint(Vector3 fromPostition, bool ignoreNormalisation)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	public float GetNearestPoint(Vector3 fromPostition, bool ignoreNormalisation, int refinments)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetNearestPointNear(Vector3 fromPostition, float prevPercentage, Vector3 prevPosition, bool ignoreNormalisation, int refinments)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public void Clear()
	{
	}

	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	public CameraPathControlPoint GetPoint(int index)
	{
		return null;
	}

	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	public int GetPointIndex(int index)
	{
		return default(int);
	}

	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int GetCurveIndex(int startPointIndex)
	{
		return default(int);
	}

	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
	[Calls(Type = typeof(CameraPath), Member = "AddPoint")]
	[Calls(Type = typeof(CameraPath), Member = "AddPoint")]
	[Calls(Type = typeof(CameraPath), Member = "AddPoint")]
	[Calls(Type = typeof(CameraPath), Member = "AddPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "Awake")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_localPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_localPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_localPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_localPosition")]
	[Calls(Type = typeof(CameraPath), Member = "InitialiseLists")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	private void Init()
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "Init")]
	[CalledBy(Type = typeof(CameraPath), Member = "OnValidate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 18)]
	[CallerCount(Count = 2)]
	private void InitialiseLists()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CameraPath()
	{
	}
}
