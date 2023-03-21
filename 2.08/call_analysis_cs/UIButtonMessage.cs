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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[Calls(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnSelect")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnEnable")]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	private void OnPress(bool isPressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnDoubleClick()
	{
	}

	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnClick")]
	[CallsUnknownMethods(Count = 7)]
	private void Send()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public UIButtonMessage()
	{
	}
}
