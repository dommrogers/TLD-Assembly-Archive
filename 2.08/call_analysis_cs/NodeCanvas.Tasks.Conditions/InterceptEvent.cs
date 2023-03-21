using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;
using UnityEngine.EventSystems;

namespace NodeCanvas.Tasks.Conditions;

public class InterceptEvent : ConditionTask<Transform>
{
	public EventTriggerType eventType;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Format")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Task), Member = "RegisterEvents")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	protected override string OnInit()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnPointerExit(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void OnPointerDown(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnPointerUp(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnPointerClick(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDrag(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnDrop(BaseEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnScroll(PointerEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[DeduplicatedMethod]
	private void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[DeduplicatedMethod]
	private void OnSelect(BaseEventData eventData)
	{
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnDeselect(BaseEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnMove(AxisEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnSubmit(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	public InterceptEvent()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
