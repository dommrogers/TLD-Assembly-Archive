using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathDelayList : CameraPathPointList
{
	public delegate void CameraPathDelayEventHandler(float time);

	public float MINIMUM_EASE_VALUE;

	private float _lastPercentage;

	private CameraPathDelay _introPoint;

	private CameraPathDelay _outroPoint;

	private bool delayInitialised;

	public new CameraPathDelay Item
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEase")]
		[CalledBy(Type = typeof(CameraPathDelayList), Member = "CheckEvents")]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 2)]
		get
		{
			return null;
		}
	}

	public CameraPathDelay introPoint
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public CameraPathDelay outroPoint
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public event CameraPathDelayEventHandler CameraPathDelayEvent
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "CleanUp")]
		[CalledBy(Type = typeof(CameraPathAnimator), Member = "OnEnable")]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		add
		{
		}
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_hideFlags")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(CameraPathPointList), Member = "Init")]
	public override void Init(CameraPath _cameraPath)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	public void AddDelayPoint(CameraPathControlPoint atPoint)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public CameraPathDelay AddDelayPoint(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void OnAnimationStart(float startPercentage)
	{
	}

	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CalledBy(Type = typeof(CameraPath), Member = "CheckEvents")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "CheckEvents")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(CameraPathDelayList), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	public void CheckEvents(float percentage)
	{
	}

	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathEase")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AnimationCurve), Member = "Evaluate")]
	[Calls(Type = typeof(CameraPath), Member = "GetPathPercentage")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathSpeed")]
	[Calls(Type = typeof(CameraPathDelayList), Member = "get_Item")]
	[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public float CheckEase(float percent)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void FireDelay(CameraPathDelay eventPoint)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	public CameraPathDelayList()
	{
	}
}
