using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class TweenRotation : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool quaternionLerp;

	private Transform mTrans;

	public Transform cachedTransform
	{
		[CalledBy(Type = typeof(UIButtonRotation), Member = "OnDisable")]
		[CalledBy(Type = typeof(TweenRotation), Member = "get_rotation")]
		[CalledBy(Type = typeof(TweenRotation), Member = "set_rotation")]
		[CalledBy(Type = typeof(TweenRotation), Member = "get_value")]
		[CalledBy(Type = typeof(TweenRotation), Member = "set_value")]
		[CalledBy(Type = typeof(TweenRotation), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenRotation), Member = "Begin")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetCurrentValueToEnd")]
		[CallerCount(Count = 11)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public Quaternion rotation
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Quaternion);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public Quaternion value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Quaternion);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UITweener), Member = "Begin")]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SetCurrentValueToEnd()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	public TweenRotation()
	{
	}
}
