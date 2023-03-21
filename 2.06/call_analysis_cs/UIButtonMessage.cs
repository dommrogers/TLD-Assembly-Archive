using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIButtonMessage : MonoBehaviour
{
	public enum Trigger
	{
		OnClick,
		OnMouseOver,
		OnMouseOut,
		OnPress,
		OnRelease,
		OnDoubleClick
	}

	public GameObject target;

	public string functionName;

	public Trigger trigger;

	public bool includeChildren;

	private bool mStarted;

	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	private void OnHover(bool isOver)
	{
	}

	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPress(bool isPressed)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnSelect(bool isSelected)
	{
	}

	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	private void OnDoubleClick()
	{
	}

	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnClick")]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnHover")]
	private void Send()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public UIButtonMessage()
	{
	}
}
