using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathTiltList : CameraPathPointList
{
	public enum Interpolation
	{
		None,
		Linear,
		SmoothStep
	}

	public Interpolation interpolation;

	public bool listEnabled;

	public float autoSensitivity;

	public new CameraPathTilt Item
	{
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "AutoSetTilts")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
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
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public void AddTilt(CameraPathControlPoint atPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public CameraPathTilt AddTilt(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage, float tilt)
	{
		return null;
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathTilt")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "SmoothStepInterpolation")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "LinearInterpolation")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetNextPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public float GetTilt(float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathTiltList), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "AutoSetTilt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void AutoSetTilts()
	{
	}

	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AutoSetTilts")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector2), Member = "get_up")]
	[Calls(Type = typeof(Vector2), Member = "Angle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void AutoSetTilt(CameraPathTilt point)
	{
	}

	[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private float LinearInterpolation(float percentage)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private float SmoothStepInterpolation(float percentage)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	public CameraPathTiltList()
	{
	}
}
