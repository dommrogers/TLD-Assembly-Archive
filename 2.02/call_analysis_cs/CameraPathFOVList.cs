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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	private float defaultFOV
	{
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Camera), Member = "get_allCameras")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return 0f;
		}
	}

	private float defaultSize
	{
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Object), Member = "op_Implicit")]
		[Calls(Type = typeof(Camera), Member = "get_allCameras")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 7)]
		get
		{
			return 0f;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "Init")]
	[Calls(Type = typeof(CameraPath), Member = "add_PathPointAddedEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override void Init(CameraPath _cameraPath)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "CleanUp")]
	[Calls(Type = typeof(CameraPath), Member = "remove_PathPointAddedEvent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public override void CleanUp()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "get_defaultFOV")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "get_defaultSize")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void AddFOV(CameraPathControlPoint atPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathFOVList), Member = "get_defaultSize")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public CameraPathFOV AddFOV(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage, float fov, float size)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathFOV")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathOrthographicSize")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CallerCount(Count = 4)]
	public float GetValue(float percentage, ProjectionType type)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private float LinearInterpolation(float percentage, ProjectionType projectionType)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private float SmoothStepInterpolation(float percentage, ProjectionType projectionType)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	public CameraPathFOVList()
	{
	}
}
