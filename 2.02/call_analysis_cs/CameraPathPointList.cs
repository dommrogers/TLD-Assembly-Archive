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
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathEventList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathEventList), Member = "CheckEvents")]
		[CalledBy(Type = typeof(CameraPathFOVList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetPoint")]
		[CalledBy(Type = typeof(CameraPathSpeedList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "get_Item")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	public int numberOfPoints
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		get
		{
			return 0;
		}
	}

	public int realNumberOfPoints
	{
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "set_pathSpeed")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
		[CalledBy(Type = typeof(CameraPathOrientationList), Member = "RecalculatePoints")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "PathPointRemovedEvent")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetNextPointIndex")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
		[CalledBy(Type = typeof(CameraPathPointList), Member = "GetPoint")]
		[CalledBy(Type = typeof(CameraPathSpeedList), Member = "get_listEnabled")]
		[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
		[CallerCount(Count = 19)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return 0;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(CameraPathDelayList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "Init")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "Init")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CameraPathPointList), Member = "CheckListIsNull")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 46)]
	public virtual void Init(CameraPath _cameraPath)
	{
	}

	[CalledBy(Type = typeof(CameraPathFOVList), Member = "CleanUp")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CleanUp")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "CleanUp")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 45)]
	public virtual void CleanUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public int IndexOf(CameraPathPoint point)
	{
		return 0;
	}

	[CalledBy(Type = typeof(CameraPathDelayList), Member = "AddDelayPoint")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = "AddEvent")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "AddSpeedPoint")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AddTilt")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddPoint(CameraPathPoint newPoint, CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage)
	{
	}

	[CalledBy(Type = typeof(CameraPathDelayList), Member = "Init")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddPoint(CameraPathPoint newPoint, float fixPercent)
	{
	}

	[CalledBy(Type = typeof(CameraPathDelayList), Member = "AddDelayPoint")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = "AddEvent")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "AddFOV")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "AddOrientation")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "AddSpeedPoint")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "AddTilt")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddPoint(CameraPathPoint newPoint, CameraPathControlPoint atPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void RemovePoint(CameraPathPoint newPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public void PathPointAddedEvent(CameraPathControlPoint addedPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(Type = typeof(CameraPath), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPath), Member = "GetCurvePercentage")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public void PathPointRemovedEvent(CameraPathControlPoint removedPathPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void CheckPointCullEventFromStart(float percent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void CheckPointCullEventFromEnd(float percent)
	{
	}

	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	protected int GetNextPointIndex(float percent)
	{
		return 0;
	}

	[CalledBy(Type = typeof(CameraPathFOVList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "SmoothStepInterpolation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "SmootStepInterpolation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CubicInterpolation")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "SmoothStepInterpolation")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "SmoothStepInterpolation")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	protected int GetLastPointIndex(float percent)
	{
		return 0;
	}

	[CalledBy(Type = typeof(CameraPath), Member = "GetOutroEasePercentage")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetIntroEasePercentage")]
	[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = "SmoothStepInterpolation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "GetOrientation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "SmootStepInterpolation")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "CubicInterpolation")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = "SmoothStepInterpolation")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "GetTilt")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "LinearInterpolation")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = "SmoothStepInterpolation")]
	[CallerCount(Count = 26)]
	[Calls(Type = typeof(CameraPath), Member = "get_shouldInterpolateNextPath")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public CameraPathPoint GetPoint(int index)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public CameraPathPoint GetPoint(CameraPathControlPoint atPoint)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Clear()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public CameraPathPoint DuplicatePointCheck()
	{
		return null;
	}

	[CalledBy(Type = typeof(CameraPathOrientationList), Member = "RecalculatePoints")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(List<>), Member = "Insert")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(CameraPath), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPosition")]
	[Calls(Type = typeof(CameraPath), Member = "CalculateNormalisedPercentage")]
	[Calls(Type = typeof(CameraPath), Member = "GetNearestPointIndex")]
	[Calls(Type = typeof(CameraPath), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathControlPoint), Member = "LocalToWorldPosition")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 69)]
	protected virtual void RecalculatePoints()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void ReassignCP(CameraPathControlPoint from, CameraPathControlPoint to)
	{
	}

	[CalledBy(Type = typeof(CameraPathPointList), Member = "Init")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	protected void CheckListIsNull()
	{
	}

	[CalledBy(Type = typeof(CameraPathDelayList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathEventList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathFOVList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathOrientationList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathSpeedList), Member = ".ctor")]
	[CalledBy(Type = typeof(CameraPathTiltList), Member = ".ctor")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public CameraPathPointList()
	{
	}
}
