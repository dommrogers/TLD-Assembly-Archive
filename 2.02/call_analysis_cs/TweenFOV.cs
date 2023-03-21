using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		[CalledBy(Type = typeof(TweenFOV), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenFOV), Member = "Begin")]
		[CalledBy(Type = typeof(TweenFOV), Member = "set_value")]
		[CalledBy(Type = typeof(TweenFOV), Member = "get_fov")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(TweenFOV), Member = "get_value")]
		get
		{
			return null;
		}
	}

	public float fov
	{
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
		[CalledBy(Type = typeof(TweenFOV), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenFOV), Member = "SetCurrentValueToEnd")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenFOV), Member = "set_fov")]
		set
		{
		}
	}

	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[CallsUnknownMethods(Count = 4)]
	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenFOV), Member = "get_cachedCamera")]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	private void SetCurrentValueToStart()
	{
	}

	[Calls(Type = typeof(TweenFOV), Member = "set_value")]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	private void SetCurrentValueToEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenFOV()
	{
	}
}
