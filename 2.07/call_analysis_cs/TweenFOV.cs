using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenFOV), Member = "get_fov")]
		[CalledBy(Type = typeof(TweenFOV), Member = "get_value")]
		[CalledBy(Type = typeof(TweenFOV), Member = "Begin")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetEndToCurrentValue")]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(TweenFOV), Member = "set_value")]
		get
		{
			return null;
		}
	}

	public float fov
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenFOV), Member = "set_value")]
		set
		{
		}
	}

	public float value
	{
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		get
		{
			return default(float);
		}
		[CalledBy(Type = typeof(TweenFOV), Member = "set_fov")]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetCurrentValueToEnd")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenFOV), Member = "OnUpdate")]
		[CallerCount(Count = 4)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	private void SetCurrentValueToStart()
	{
	}

	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	private void SetCurrentValueToEnd()
	{
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenFOV()
	{
	}
}
