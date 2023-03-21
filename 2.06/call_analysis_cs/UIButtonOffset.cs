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

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonOffset), Member = "OnHover")]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnDisable()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIButtonOffset), Member = "Start")]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIButtonOffset), Member = "Start")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnHover(bool isOver)
	{
	}

	[Calls(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
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
