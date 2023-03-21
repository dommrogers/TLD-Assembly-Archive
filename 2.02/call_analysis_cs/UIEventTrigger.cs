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

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnHover(bool isOver)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnPress(bool pressed)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 0)]
	private void OnSelect(bool selected)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnClick()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnDoubleClick()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDragStart()
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDragEnd()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDragOver(GameObject go)
	{
	}

	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDragOut(GameObject go)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventDelegate), Member = "Execute")]
	private void OnDrag(Vector2 delta)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 91)]
	[CallsDeduplicatedMethods(Count = 14)]
	public UIEventTrigger()
	{
	}
}
