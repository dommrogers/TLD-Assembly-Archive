using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_ItemCookingState : ConditionTask
{
	public BBParameter<GearItem> targetGearItem;

	public CookingPotItem.CookingState targetState;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 3)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Condition_ItemCookingState()
	{
	}
}
