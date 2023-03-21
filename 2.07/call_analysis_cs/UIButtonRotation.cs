using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonRotation : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Quaternion mRot;

	private bool mStarted;

	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnPress")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIButtonRotation), Member = "Start")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(TweenRotation), Member = "Begin")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsDeduplicatedMethods(Count = 4)]
	private void OnPress(bool isPressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIButtonRotation), Member = "Start")]
	[Calls(Type = typeof(TweenRotation), Member = "Begin")]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CallsUnknownMethods(Count = 2)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonRotation()
	{
	}
}
