using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonScale : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Vector3 mScale;

	private bool mStarted;

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnHover")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonScale), Member = "OnHover")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(UIButtonScale), Member = "Start")]
	private void OnPress(bool isPressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIButtonScale), Member = "Start")]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 2)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIButtonScale), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnSelect(bool isSelected)
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public UIButtonScale()
	{
	}
}
