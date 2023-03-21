using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_InsideMissionTrigger : ConditionTask
{
	public bool checkForPlayer;

	public BBParameter<string> checkForMissionObjectId;

	public BBParameter<string> checkForTriggerId;

	public MissionTriggerType triggerType;

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsPlayerInMissionTrigger")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsMissionObjectInMissionTrigger")]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public Condition_InsideMissionTrigger()
	{
	}
}
