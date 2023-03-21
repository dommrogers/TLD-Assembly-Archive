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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Condition_PlayerItemIsEquipped), Member = "Test")]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CalledBy(Type = typeof(Condition_PlayerItemIsEquipped), Member = "OnCustomEvent")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Condition_PlayerItemIsEquipped), Member = "OnCheck")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 2)]
	private bool Test()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Condition_PlayerItemIsEquipped()
	{
	}
}
