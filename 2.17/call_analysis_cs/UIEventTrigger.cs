using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIEventTrigger : MonoBehaviour
{
	public static UIEventTrigger current;

	public List<EventDelegate> onHoverOver;

	public List<EventDelegate> onHoverOut;

	public List<EventDelegate> onPress;

	public List<EventDelegate> onRelease;

	public List<EventDelegate> onSelect;

	public List<EventDelegate> onDeselect;

	public List<EventDelegate> onClick;

	public List<EventDelegate> onDoubleClick;

	public List<EventDelegate> onDragStart;

	public List<EventDelegate> onDragEnd;

	public List<EventDelegate> onDragOver;

	public List<EventDelegate> onDragOut;

	public List<EventDelegate> onDrag;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnPress(bool pressed)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnSelect(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDragStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDragEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDragOver(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDragOut(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 1)]
	public UIEventTrigger()
	{
	}
}
