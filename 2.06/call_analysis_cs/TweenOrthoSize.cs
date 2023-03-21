using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenOrthoSize : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "Begin")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "set_value")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "get_value")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "get_orthoSize")]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "set_value")]
		set
		{
		}
	}

	public float value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(float);
		}
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "set_orthoSize")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "OnUpdate")]
		set
		{
		}
	}

	[Calls(Type = typeof(TweenOrthoSize), Member = "set_value")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public override void SetEndToCurrentValue()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenOrthoSize()
	{
	}
}
