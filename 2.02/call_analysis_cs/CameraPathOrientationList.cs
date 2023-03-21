using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathOrientationList : CameraPathPointList
{
	public enum Interpolation
	{
		None,
		Linear,
		SmoothStep,
		Hermite,
		Cubic
	}

	public Interpolation interpolation;

	public new CameraPathOrientation Item
	{
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "RecalculatePoints")]
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

	[CalledBy(Type = typeof(CameraPath), Member = "AddPoint")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPoint")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void AddOrientation(CameraPathControlPoint atPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public CameraPathOrientation AddOrientation(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage, Quaternion rotation)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void RemovePoint(CameraPathOrientation orientation)
	{
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetPathRotation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "CubicInterpolation")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "SmootStepInterpolation")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "LinearInterpolation")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetNextPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Quaternion GetOrientation(float percentage)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private Quaternion LinearInterpolation(float percentage)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private Quaternion SmootStepInterpolation(float percentage)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CPMath), Member = "CalculateCubic")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 47)]
	private Quaternion CubicInterpolation(float percentage)
	{
		return default(Quaternion);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "get_Item")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void RecalculatePoints()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	public CameraPathOrientationList()
	{
	}
}
