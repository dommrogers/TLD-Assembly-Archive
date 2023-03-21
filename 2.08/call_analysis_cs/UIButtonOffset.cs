using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonOffset : MonoBehaviour
{
	public Transform tweenTarget;

	public Vector3 hover;

	public Vector3 pressed;

	public float duration;

	private Vector3 mPos;

	private bool mStarted;

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIButtonOffset), Member = "Start")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	private void OnPress(bool isPressed)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnEnable")]
	[Calls(Type = typeof(UIButtonOffset), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CallsUnknownMethods(Count = 2)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void RefreshPosition()
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonOffset()
	{
	}
}
