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
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnPress(bool pressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	private void OnClick()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	private void OnDoubleClick()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	private void OnSelect(bool selected)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDrop(GameObject go)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	private void OnSubmit()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SendMessage")]
	[CallerCount(Count = 0)]
	private void OnScroll(float delta)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public UIForwardEvents()
	{
	}
}
