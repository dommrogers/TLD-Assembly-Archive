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
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[Calls(Type = typeof(UIButtonRotation), Member = "Start")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(TweenRotation), Member = "Begin")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnPress(bool isPressed)
	{
	}

	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnEnable")]
	[Calls(Type = typeof(TweenRotation), Member = "Begin")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIButtonRotation), Member = "Start")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	private void OnHover(bool isOver)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIButtonRotation()
	{
	}
}
