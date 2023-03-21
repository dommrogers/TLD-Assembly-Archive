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

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnHover")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonScale), Member = "OnHover")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIButtonScale), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnPress(bool isPressed)
	{
	}

	[Calls(Type = typeof(TweenScale), Member = "Begin")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIButtonScale), Member = "OnEnable")]
	[Calls(Type = typeof(UIButtonScale), Member = "Start")]
	[CallerCount(Count = 2)]
	private void OnHover(bool isOver)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIButtonScale), Member = "OnHover")]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonScale()
	{
	}
}
