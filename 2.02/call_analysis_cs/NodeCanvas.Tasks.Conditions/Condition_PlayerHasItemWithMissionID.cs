using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_PlayerHasItemWithMissionID : ConditionTask
{
	public BBParameter<string> missionObjectId;

	public bool requireInvEvent;

	protected override string info
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Condition_PlayerHasItemWithMissionID), Member = "Test")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Condition_PlayerHasItemWithMissionID), Member = "Test")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[CalledBy(Type = typeof(Condition_PlayerHasItemWithMissionID), Member = "OnCheck")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Condition_PlayerHasItemWithMissionID), Member = "OnCustomEvent")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private bool Test()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public Condition_PlayerHasItemWithMissionID()
	{
	}
}
