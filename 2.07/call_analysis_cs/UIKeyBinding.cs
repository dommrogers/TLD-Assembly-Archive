using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIKeyBinding : MonoBehaviour
{
	public enum Action
	{
		PressAndClick,
		Select,
		All
	}

	public enum Modifier
	{
		Any,
		Shift,
		Control,
		Alt,
		None
	}

	public KeyCode keyCode;

	public Modifier modifier;

	public Action action;

	private bool mIgnoreUp;

	private bool mIsInput;

	private bool mPress;

	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnSubmit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	protected virtual bool IsModifierActive()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	protected virtual void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void OnBindingPress(bool pressed)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void OnBindingClick()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIKeyBinding()
	{
	}
}
