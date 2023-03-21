using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraPathSpeedList : CameraPathPointList
{
	public enum Interpolation
	{
		None,
		Linear,
		SmoothStep
	}

	public Interpolation interpolation;

	private bool _enabled;

	public new CameraPathSpeed Item
	{
		[CalledBy(Type = typeof(CameraPathSpeedList), Member = "GetLowesetSpeed")]
		[Calls(Type = typeof(CameraPathPointList), Member = "get_Item")]
		[CalledBy(Type = typeof(CameraPathSpeedList), Member = "GetLowesetSpeed")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public bool listEnabled
	{
		[Calls(Type = typeof(CameraPathPointList), Member = "get_realNumberOfPoints")]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(CameraPathPointList), Member = "Init")]
	public override void Init(CameraPath _cameraPath)
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	public void AddSpeedPoint(CameraPathControlPoint atPoint)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(CameraPathPointList), Member = "AddPoint")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public CameraPathSpeed AddSpeedPoint(CameraPathControlPoint curvePointA, CameraPathControlPoint curvePointB, float curvePercetage)
	{
		return null;
	}

	[Calls(Type = typeof(CameraPathSpeedList), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(CameraPathSpeedList), Member = "get_Item")]
	public float GetLowesetSpeed()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(CameraPathAnimator), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(CameraPath), Member = "GetPathSpeed")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public float GetSpeed(float percentage)
	{
		return default(float);
	}

	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	private float LinearInterpolation(float percentage)
	{
		return default(float);
	}

	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetPoint")]
	[Calls(Type = typeof(CameraPathPointList), Member = "GetLastPointIndex")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	private float SmoothStepInterpolation(float percentage)
	{
		return default(float);
	}

	[Calls(Type = typeof(CameraPathPointList), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public CameraPathSpeedList()
	{
	}
}
