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

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnHover")]
	private void Start()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonScale), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIButtonScale), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void OnPress(bool isPressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnEnable")]
	[Calls(Type = typeof(UIButtonScale), Member = "Start")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnSelect")]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	private void OnHover(bool isOver)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIButtonScale), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonScale()
	{
	}
}
