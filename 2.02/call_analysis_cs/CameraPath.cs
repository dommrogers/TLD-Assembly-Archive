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
		[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPoint")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	public int numberOfPoints
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return 0;
		}
	}

	public int realNumberOfPoints
	{
		[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "CalculateNormalisedPercentage")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdatePointReached")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
		[CallerCount(Count = 7)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	public int numberOfCurves
	{
		[CalledBy(Type = typeof(CameraPath), Member = "StoredArcLength")]
		[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPointNumber")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPercentage")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPathPercentage")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetNearestPointIndex")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetLastPointIndex")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetNextPointIndex")]
		[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPoint")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetPointIndex")]
		[CalledBy(Type = typeof(CameraPath), Member = "GetCurveIndex")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0;
		}
	}

	public bool loop
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
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
			return 0f;
		}
	}

	public CameraPathOrientationList orientationList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public CameraPathFOVList fovList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public CameraPathEventList eventList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public CameraPathDelayList delayList
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
	}

	public CameraPathControlPoint[] pointALink
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 8)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
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
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Interpolation interpolation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		get
		{
			return default(Interpolation);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
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
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
		set
		{
		}
	}

	public bool shouldInterpolateNextPath
	{
		[CalledBy(Type = typeof(CameraPath), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPath), Member = "get_numberOfPoints")]
		[CalledBy(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetPoint")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public float storedPointResolution
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
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
			return 0f;
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
			return 0;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public float aspect
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
			return 0;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public event RecalculateCurvesHandler RecalculateCurvesEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event PathPointAddedHandler PathPointAddedEvent
	{
		[CompilerGenerated]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "Init")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "Init")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "Init")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "CleanUp")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CleanUp")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "CleanUp")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event PathPointRemovedHandler PathPointRemovedEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event CheckStartPointCullHandler CheckStartPointCullEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event CheckEndPointCullHandler CheckEndPointCullEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	public event CleanUpListsHandler CleanUpListsEvent
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float StoredArcLength(int curve)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int StoredValueIndex(float percentage)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_localPosition")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public CameraPathControlPoint AddPoint(Vector3 position)
	{
		return null;
	}

	[CalledBy(Type = typeof(CameraPath), Member = "Init")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddPoint(CameraPathControlPoint point)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void InsertPoint(CameraPathControlPoint point, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	public CameraPathControlPoint InsertPoint(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[Calls(Type = typeof(CameraPath), Member = "RemovePoint")]
	public void RemovePoint(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool RemovePoint(string pointName)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPath), Member = "RemovePoint")]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPointIndex")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void RemovePoint(Vector3 pointPosition)
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public void RemovePoint(CameraPathControlPoint point)
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPointNumber")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathRotation")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathTilt")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathFOV")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathOrthographicSize")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathSpeed")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathEase")]
	[CalledBy(Type = typeof(CameraPath), Member = "CheckEvents")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetNearestPointIndex")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetLastPointIndex")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetNextPointIndex")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetStoredPoint")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "CheckEvents")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	private float ParsePercentage(float percentage)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[CallsUnknownMethods(Count = 9)]
	public float CalculateNormalisedPercentage(float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public float DeNormalisePercentage(float normalisedPercent)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetPointNumber(float percentage)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	public Vector3 GetPathPosition(float percentage)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetNearestPointNear")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AutoSetTilt")]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPointWorld")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPointWorld")]
	[Calls(Type = typeof(CPMath), Member = "CalculateBezier")]
	[Calls(Type = typeof(CPMath), Member = "CalculateHermite")]
	[Calls(Type = typeof(CPMath), Member = "CalculateCatmullRom")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	public Vector3 GetPathPosition(float percentage, bool ignoreNormalisation)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CallsUnknownMethods(Count = 1)]
	public Quaternion GetPathRotation(float percentage, bool ignoreNormalisation)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	public Vector3 GetPathDirection(float percentage)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AutoSetTilt")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(Vector3), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public Vector3 GetPathDirection(float percentage, bool normalisePercent)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[CallsUnknownMethods(Count = 1)]
	public float GetPathTilt(float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetPathFOV(float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "GetValue")]
	[CallsUnknownMethods(Count = 1)]
	public float GetPathOrthographicSize(float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathSpeedList), Member = "GetSpeed")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[CallsUnknownMethods(Count = 1)]
	public float GetPathSpeed(float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[CallsUnknownMethods(Count = 1)]
	public float GetPathEase(float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
	[CallsUnknownMethods(Count = 1)]
	public void CheckEvents(float percentage)
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public float GetPathPercentage(CameraPathControlPoint point)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	public float GetPathPercentage(int pointIndex)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNearestPointIndex(float percentage)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetLastPointIndex(float percentage, bool isNormalised)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetNextPointIndex(float percentage, bool isNormalised)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetCurvePercentage(CameraPathControlPoint pointA, CameraPathControlPoint pointB, float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GetCurvePercentage(CameraPathPoint pointA, CameraPathPoint pointB, float percentage)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointAddedEvent")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetCurvePercentage(CameraPathPoint point)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public float GetOutroEasePercentage(CameraPathDelay point)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public float GetIntroEasePercentage(CameraPathDelay point)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetPathPercentage(CameraPathControlPoint pointA, CameraPathControlPoint pointB, float curvePercentage)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetPathPercentage(float pointA, float pointB, float curvePercentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "ParsePercentage")]
	[Calls(Type = typeof(Mathf), Member = "FloorToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	public int GetStoredPoint(float percentage)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "Init")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 43)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "InitialiseLists")]
	[Calls(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnValidate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "set_loop")]
	[CalledBy(Type = typeof(CameraPath), Member = "set_interpolation")]
	[CalledBy(Type = typeof(CameraPath), Member = "set_nextPath")]
	[CalledBy(Type = typeof(CameraPath), Member = "set_interpolateNextPath")]
	[CalledBy(Type = typeof(CameraPath), Member = "AddPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "AddPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "InsertPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "InsertPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "OnValidate")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "CalculateNormalisedPercentage")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPointWorld")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_backwardControlPointWorld")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 110)]
	public void RecalculateStoredValues()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	public float GetNearestPoint(Vector3 fromPostition)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	public float GetNearestPoint(Vector3 fromPostition, bool ignoreNormalisation)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraPath), Member = "RemovePoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetNearestPoint")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetNearestPoint(Vector3 fromPostition, bool ignoreNormalisation, int refinments)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public float GetNearestPointNear(Vector3 fromPostition, float prevPercentage, Vector3 prevPosition, bool ignoreNormalisation, int refinments)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear()
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CalledBy(Type = typeof(CameraPath), Member = "RecalculateStoredValues")]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CameraPathControlPoint GetPoint(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetPointIndex(int index)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "get_numberOfCurves")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public int GetCurveIndex(int startPointIndex)
	{
		return 0;
	}

	[CalledBy(Type = typeof(CameraPath), Member = "Awake")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "InitialiseLists")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_localPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "set_forwardControlPoint")]
	[Calls(Type = typeof(CameraPath), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	private void Init()
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "OnValidate")]
	[CalledBy(Type = typeof(CameraPath), Member = "Init")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 18)]
	private void InitialiseLists()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public CameraPath()
	{
	}
}
