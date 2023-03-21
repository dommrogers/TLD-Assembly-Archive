using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		[CalledBy(Type = typeof(TweenFOV), Member = "get_fov")]
		[CalledBy(Type = typeof(TweenFOV), Member = "get_value")]
		[CalledBy(Type = typeof(TweenFOV), Member = "set_value")]
		[CalledBy(Type = typeof(TweenFOV), Member = "Begin")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetEndToCurrentValue")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public float fov
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenFOV), Member = "set_value")]
		set
		{
		}
	}

	public float value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(TweenFOV), Member = "set_fov")]
		[CalledBy(Type = typeof(TweenFOV), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetCurrentValueToEnd")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetEndToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	private void SetCurrentValueToStart()
	{
	}

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
