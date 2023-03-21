using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathPointList : MonoBehaviour
{
	private List<CameraPathPoint> _points;

	protected CameraPath cameraPath;

	protected string pointTypeName;

	[NonSerialized]
	protected bool initialised;

	public CameraPathPoint Item
	{
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
		[CalledBy(Type = typeof(CameraPathEventList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "get_Item")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetPoint")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "get_Item")]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(CameraPathSpeedList), Member = "get_Item")]
		[CallsUnknownMethods(Count = 5)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public int numberOfPoints
	{
		[CallsUnknownMethods(Count = 4)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public int realNumberOfPoints
	{
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "RecalculatePoints")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "RecalculatePoints")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetNextPointIndex")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetPoint")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetPoint")]
		[CalledBy(Type = typeof(CameraPathSpeedList), Member = "get_listEnabled")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
		[CallerCount(Count = 19)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "set_pathSpeed")]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
		get
		{
			return default(int);
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsUnknownMethods(Count = 46)]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathDelayList), Member = "Init")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(CameraPathPointList), Member = "CheckListIsNull")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 6)]
	public virtual void Init(CameraPath _cameraPath)
	{
	}

	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "CleanUp")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CleanUp")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "CleanUp")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	public virtual void CleanUp()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int IndexOf(CameraPathPoint point)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "AddSpeedPoint")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = "AddEvent")]
	[CalledBy(Type = typeof(CameraPathDelayList), Member = "AddDelayPoint")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AddTilt")]
	public void AddPoint(CameraPathPoint newPoint, CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage)
	{
	}

	[CalledBy(Type = typeof(CameraPathDelayList), Member = "Init")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(CameraPathDelayList), Member = "Init")]
	public void AddPoint(CameraPathPoint newPoint, float fixPercent)
	{
	}

	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "AddSpeedPoint")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = "AddEvent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CameraPathDelayList), Member = "AddDelayPoint")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AddTilt")]
	[CallsUnknownMethods(Count = 2)]
	public void AddPoint(CameraPathPoint newPoint, CameraPathControlPoint atPoint)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void RemovePoint(CameraPathPoint newPoint)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 9)]
	public void PathPointAddedEvent(CameraPathControlPoint addedPoint)
	{
	}

	[Calls(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void PathPointRemovedEvent(CameraPathControlPoint removedPathPoint)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public void CheckPointCullEventFromStart(float percent)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 3)]
	public void CheckPointCullEventFromEnd(float percent)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected int GetNextPointIndex(float percent)
	{
		return default(int);
	}

	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "SmoothStepInterpolation")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CubicInterpolation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "SmootStepInterpolation")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "SmoothStepInterpolation")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "LinearInterpolation")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "LinearInterpolation")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "SmoothStepInterpolation")]
	protected int GetLastPointIndex(float percent)
	{
		return default(int);
	}

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 15)]
	public CameraPathPoint GetPoint(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	public CameraPathPoint GetPoint(CameraPathControlPoint atPoint)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public void Clear()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public CameraPathPoint DuplicatePointCheck()
	{
		return null;
	}

	[Calls(Type = typeof(CameraPath), Member = "GetNearestPointIndex")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[Calls(Type = typeof(CameraPath), Member = "CalculateNormalisedPercentage")]
	[Calls(Type = typeof(CameraPath), Member = "CalculateNormalisedPercentage")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 69)]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "RecalculatePoints")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	protected virtual void RecalculatePoints()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void ReassignCP(CameraPathControlPoint from, CameraPathControlPoint to)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CameraPathPointList), Member = "Init")]
	protected void CheckListIsNull()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathDelayList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	public CameraPathPointList()
	{
	}
}
