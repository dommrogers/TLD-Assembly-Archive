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
	[DeduplicatedMethod]
	private void Start()
	{
	}

	[Calls(Type = typeof(UICamera), Member = "IsHighlighted")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnEnable")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnSelect")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnPress(bool isPressed)
	{
	}

	[Calls(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void OnSelect(bool isSelected)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UIButtonMessage), Member = "Send")]
	[CallerCount(Count = 0)]
	private void OnClick()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnDoubleClick()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnHover")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnClick")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(UIButtonMessage), Member = "OnPress")]
	private void Send()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public UIButtonMessage()
	{
	}
}
