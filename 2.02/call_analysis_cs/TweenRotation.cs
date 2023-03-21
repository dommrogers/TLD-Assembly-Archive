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
		[CalledBy(Type = typeof(TweenRotation), Member = "SetEndToCurrentValue")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetCurrentValueToEnd")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetCurrentValueToStart")]
		[CalledBy(Type = typeof(TweenRotation), Member = "SetStartToCurrentValue")]
		[CalledBy(Type = typeof(TweenRotation), Member = "Begin")]
		[CalledBy(Type = typeof(TweenRotation), Member = "OnUpdate")]
		[CalledBy(Type = typeof(TweenRotation), Member = "set_value")]
		[CalledBy(Type = typeof(TweenRotation), Member = "set_rotation")]
		[CalledBy(Type = typeof(TweenRotation), Member = "get_rotation")]
		[CalledBy(Type = typeof(UIButtonRotation), Member = "OnDisable")]
		[CalledBy(Type = typeof(TweenRotation), Member = "get_value")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(Object), Member = "op_Equality")]
		get
		{
			return null;
		}
	}

	public Quaternion rotation
	{
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(Quaternion);
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		set
		{
		}
	}

	public Quaternion value
	{
		[DeduplicatedMethod]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Quaternion);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
		set
		{
		}
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallerCount(Count = 0)]
	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnPress")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	public static TweenRotation Begin(GameObject go, float duration, Quaternion rot)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	public override void SetStartToCurrentValue()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	public override void SetEndToCurrentValue()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsUnknownMethods(Count = 2)]
	private void SetCurrentValueToStart()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[ContextMenu(/*Could not decode attribute arguments.*/)]
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
