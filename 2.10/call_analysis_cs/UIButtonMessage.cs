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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnSelect")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnPress(bool isPressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnDoubleClick()
	{
	}

	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnPress")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnClick")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsDeduplicatedMethods(Count = 6)]
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
