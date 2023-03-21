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
		[CalledBy(Type = typeof(TweenRotation), Member = "Begin")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenRotation), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenRotation), Member = "set_value")]
		[CalledBy(Type = typeof(TweenRotation), Member = "get_value")]
		[CalledBy(Type = typeof(TweenRotation), Member = "set_rotation")]
		[CalledBy(Type = typeof(TweenRotation), Member = "get_rotation")]
		[CalledBy(Type = typeof(UIButtonRotation), Member = "OnDisable")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetCurrentValueToStart")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetStartToCurrentValue")]
		[CallerCount(Count = 11)]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetEndToCurrentValue")]
		get
		{
			return null;
		}
	}

	public Quaternion rotation
	{
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Quaternion);
		}
		[DeduplicatedMethod]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Quaternion value
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		get
		{
			return default(Quaternion);
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsDeduplicatedMethods(Count = 3)]
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 2)]
	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	private void SetCurrentValueToStart()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[ContextMenu("Assume value of 'To'")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetCurrentValueToEnd()
	{
	}

	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TweenRotation()
	{
	}
}
