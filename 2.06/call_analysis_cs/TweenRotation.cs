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
		[CalledBy(Type = typeof(TweenRotation), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenRotation), Member = "Begin")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetEndToCurrentValue")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetCurrentValueToEnd")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenRotation), Member = "set_value")]
		[CalledBy(Type = typeof(TweenRotation), Member = "get_value")]
		[CalledBy(Type = typeof(TweenRotation), Member = "set_rotation")]
		[CalledBy(Type = typeof(UIButtonRotation), Member = "OnDisable")]
		[CalledBy(Type = typeof(TweenRotation), Member = "get_rotation")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
		get
		{
			return null;
		}
	}

	public Quaternion rotation
	{
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(Quaternion);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	public Quaternion value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		get
		{
			return default(Quaternion);
		}
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 5)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnPress")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	public override void SetEndToCurrentValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContextMenu("Assume value of 'From'")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	private void SetCurrentValueToStart()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[ContextMenu("Assume value of 'To'")]
	private void SetCurrentValueToEnd()
	{
	}

	[DeduplicatedMethod]
	[Calls(Type = typeof(UITweener), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public TweenRotation()
	{
	}
}
