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
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "AutoSetTilts")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "add_PathPointAddedEvent")]
	[CallsUnknownMethods(Count = 8)]
	public override void Init(CameraPath _cameraPath)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(CameraPath), Member = "remove_PathPointAddedEvent")]
	[Calls(Type = typeof(CameraPathPointList), Member = "CleanUp")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void CleanUp()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public void AddTilt(CameraPathControlPoint atPoint)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public CameraPathTilt AddTilt(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage, float tilt)
	{
		return null;
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathTilt")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetNextPointIndex")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "LinearInterpolation")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "SmoothStepInterpolation")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "get_Item")]
	public float GetTilt(float percentage)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathTiltList), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathTiltList), Member = "AutoSetTilt")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void AutoSetTilts()
	{
	}

	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AutoSetTilts")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2), Member = "Angle")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector2), Member = "get_up")]
	public void AutoSetTilt(CameraPathTilt point)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	private float LinearInterpolation(float percentage)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(Mathf), Member = "LerpAngle")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	private float SmoothStepInterpolation(float percentage)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	public CameraPathTiltList()
	{
	}
}
