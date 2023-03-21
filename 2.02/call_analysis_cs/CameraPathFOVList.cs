using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathFOVList : CameraPathPointList
{
	public enum ProjectionType
	{
		FOV,
		Orthographic
	}

	public enum Interpolation
	{
		None,
		Linear,
		SmoothStep
	}

	public Interpolation interpolation;

	private const float DEFAULT_FOV = 60f;

	private const float DEFAULT_SIZE = 5f;

	public bool listEnabled;

	public new CameraPathFOV Item
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private float defaultFOV
	{
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
		[Calls(Type = typeof(Camera), Member = "get_allCameras")]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallerCount(Count = 1)]
		get
		{
			return default(float);
		}
	}

	private float defaultSize
	{
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
		[Calls(Type = typeof(Camera), Member = "get_allCameras")]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return default(float);
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "add_PathPointAddedEvent")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "Init")]
	public override void Init(CameraPath _cameraPath)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "CleanUp")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(CameraPath), Member = "remove_PathPointAddedEvent")]
	public override void CleanUp()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "get_defaultSize")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "get_defaultFOV")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void AddFOV(CameraPathControlPoint atPoint)
	{
	}

	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "get_defaultSize")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public CameraPathFOV AddFOV(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage, float fov, float size)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathFOV")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathOrthographicSize")]
	public float GetValue(float percentage, ProjectionType type)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	private float LinearInterpolation(float percentage, ProjectionType projectionType)
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float SmoothStepInterpolation(float percentage, ProjectionType projectionType)
	{
		return default(float);
	}

	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CameraPathFOVList()
	{
	}
}
