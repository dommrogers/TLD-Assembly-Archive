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

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallerCount(Count = 0)]
	protected virtual void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnBindingPress(bool pressed)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "Notify")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected virtual void OnBindingClick()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIKeyBinding()
	{
	}
}
