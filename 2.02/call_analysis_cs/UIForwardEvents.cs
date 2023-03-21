using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIForwardEvents : MonoBehaviour
{
	public GameObject target;

	public bool onHover;

	public bool onPress;

	public bool onClick;

	public bool onDoubleClick;

	public bool onSelect;

	public bool onDrag;

	public bool onDrop;

	public bool onSubmit;

	public bool onScroll;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnPress(bool pressed)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	private void OnClick()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	private void OnSelect(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDrop(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnSubmit()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnScroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public UIForwardEvents()
	{
	}
}
