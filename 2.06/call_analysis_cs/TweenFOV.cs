using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		[CallerCount(Count = 6)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(TweenFOV), Member = "get_fov")]
		[CalledBy(Type = typeof(TweenFOV), Member = "get_value")]
		[CalledBy(Type = typeof(TweenFOV), Member = "set_value")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenFOV), Member = "Begin")]
		get
		{
			return null;
		}
	}

	public float fov
	{
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(TweenFOV), Member = "set_value")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float value
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CalledBy(Type = typeof(TweenFOV), Member = "set_fov")]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[CallerCount(Count = 4)]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetCurrentValueToEnd")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenFOV), Member = "OnUpdate")]
		set
		{
		}
	}

	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[ContextMenu("Set 'To' to current value")]
	[CallsUnknownMethods(Count = 2)]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	private void SetCurrentValueToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenFOV()
	{
	}
}
