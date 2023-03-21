using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenOrthoSize : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "get_orthoSize")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "get_value")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "set_value")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "Begin")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "SetEndToCurrentValue")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Component), Member = "GetComponent")]
		get
		{
			return null;
		}
	}

	public float orthoSize
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "set_value")]
		set
		{
		}
	}

	public float value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return 0f;
		}
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "set_orthoSize")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "OnUpdate")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[CallsUnknownMethods(Count = 2)]
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
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetEndToCurrentValue()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenOrthoSize()
	{
	}
}
