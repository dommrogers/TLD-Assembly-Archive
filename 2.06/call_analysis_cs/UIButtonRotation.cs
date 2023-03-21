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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(TweenRotation), Member = "get_cachedTransform")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(TweenRotation), Member = "Begin")]
	[Calls(Type = typeof(Quaternion), Member = "Euler")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UIButtonRotation), Member = "Start")]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UIButtonRotation), Member = "Start")]
	[Calls(Type = typeof(TweenRotation), Member = "Begin")]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(UIButtonRotation), Member = "OnEnable")]
	private void OnHover(bool isOver)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIButtonRotation), Member = "OnHover")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	public UIButtonRotation()
	{
	}
}
