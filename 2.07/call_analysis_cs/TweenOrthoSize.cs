using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenOrthoSize : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "get_orthoSize")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "get_value")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "set_value")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "Begin")]
		[CallerCount(Count = 6)]
		get
		{
			return null;
		}
	}

	public float orthoSize
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[Calls(Type = typeof(TweenOrthoSize), Member = "set_value")]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public float value
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "OnUpdate")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "set_orthoSize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "set_value")]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsUnknownMethods(Count = 3)]
	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public override void SetEndToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[DeduplicatedMethod]
	public TweenOrthoSize()
	{
	}
}
