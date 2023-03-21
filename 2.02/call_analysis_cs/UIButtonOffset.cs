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

	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnPress")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TweenPosition), Member = "set_value")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonOffset), Member = "Start")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 4)]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIButtonOffset), Member = "Start")]
	[Calls(Type = typeof(TweenPosition), Member = "Begin")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonOffset), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 4)]
	private void OnHover(bool isOver)
	{
	}

	[Calls(Type = typeof(UIButtonOffset), Member = "OnHover")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	public void RefreshPosition()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallerCount(Count = 0)]
	public UIButtonOffset()
	{
	}
}
