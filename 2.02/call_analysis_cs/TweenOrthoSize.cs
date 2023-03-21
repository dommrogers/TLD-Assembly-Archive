using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenOrthoSize : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "set_value")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "SetStartToCurrentValue")]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "Begin")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "get_value")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "get_orthoSize")]
		get
		{
			return null;
		}
	}

	public float orthoSize
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(float);
		}
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenOrthoSize), Member = "set_orthoSize")]
		[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
		set
		{
		}
	}

	[Calls(Type = typeof(TweenOrthoSize), Member = "set_value")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	[CallsDeduplicatedMethods(Count = 4)]
	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	public override void SetStartToCurrentValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenOrthoSize), Member = "get_cachedCamera")]
	public override void SetEndToCurrentValue()
	{
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TweenOrthoSize()
	{
	}
}
