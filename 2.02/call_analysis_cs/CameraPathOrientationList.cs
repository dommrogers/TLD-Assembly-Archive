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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "RecalculatePoints")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "Init")]
	[Calls(Type = typeof(CameraPath), Member = "add_PathPointAddedEvent")]
	[CallsUnknownMethods(Count = 8)]
	public override void Init(CameraPath _cameraPath)
	{
	}

	[Calls(Type = typeof(CameraPathPointList), Member = "CleanUp")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "remove_PathPointAddedEvent")]
	public override void CleanUp()
	{
	}

	[Calls(Type = typeof(CameraPath), Member = "GetPathDirection")]
	[Calls(Type = typeof(Vector3), Member = "op_Inequality")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPoint")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "AddPoint")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "get_forwardControlPoint")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	public void AddOrientation(CameraPathControlPoint atPoint)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public CameraPathOrientation AddOrientation(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage, Quaternion rotation)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public void RemovePoint(CameraPathOrientation orientation)
	{
	}

	[Calls(Type = typeof(CameraPathPointList), Member = "GetNextPointIndex")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "SmootStepInterpolation")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "CubicInterpolation")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "LinearInterpolation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathRotation")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "GetOrientation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	public Quaternion GetOrientation(float percentage)
	{
		return default(Quaternion);
	}

	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	private Quaternion LinearInterpolation(float percentage)
	{
		return default(Quaternion);
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private Quaternion SmootStepInterpolation(float percentage)
	{
		return default(Quaternion);
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CPMath), Member = "CalculateCubic")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 47)]
	private Quaternion CubicInterpolation(float percentage)
	{
		return default(Quaternion);
	}

	[Calls(Type = typeof(CameraPathPointList), Member = "RecalculatePoints")]
	[Calls(Type = typeof(CameraPathOrientationList), Member = "get_Item")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CallerCount(Count = 0)]
	protected override void RecalculatePoints()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	public CameraPathOrientationList()
	{
	}
}
