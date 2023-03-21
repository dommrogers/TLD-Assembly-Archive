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
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Task), Member = "RegisterEvents")]
	[CallsUnknownMethods(Count = 5)]
	protected override string OnInit()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnPointerExit(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnPointerDown(PointerEventData eventData)
	{
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void OnPointerUp(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnPointerClick(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnDrag(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnDrop(BaseEventData eventData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[DeduplicatedMethod]
	private void OnScroll(PointerEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnUpdateSelected(BaseEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnSelect(BaseEventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnDeselect(BaseEventData eventData)
	{
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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
