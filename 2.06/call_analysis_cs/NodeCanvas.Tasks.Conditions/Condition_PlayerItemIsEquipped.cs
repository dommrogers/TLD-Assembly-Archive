using System;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_PlayerItemIsEquipped : ConditionTask
{
	public BBParameter<InventoryItemRequirement> requiredItem;

	public bool requireInvEvent;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition_PlayerItemIsEquipped), Member = "Test")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(Condition_PlayerItemIsEquipped), Member = "Test")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 0)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Condition_PlayerItemIsEquipped), Member = "OnCheck")]
	[CalledBy(Type = typeof(Condition_PlayerItemIsEquipped), Member = "OnCustomEvent")]
	[CallsUnknownMethods(Count = 4)]
	private bool Test()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public Condition_PlayerItemIsEquipped()
	{
	}
}
