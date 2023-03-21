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

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 0)]
	private void OnHover(bool isOver)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void OnPress(bool pressed)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void OnSelect(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnClick()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDoubleClick()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 0)]
	private void OnDragStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDragEnd()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDragOver(GameObject go)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnDragOut(GameObject go)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallsUnknownMethods(Count = 66)]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	public UIEventTrigger()
	{
	}
}
