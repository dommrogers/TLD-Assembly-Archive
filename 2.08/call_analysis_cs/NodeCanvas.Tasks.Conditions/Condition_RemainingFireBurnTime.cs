using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_RemainingFireBurnTime : ConditionTask
{
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	public BBParameter<float> burnTimeHoursRemaining;

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeHours")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_RemainingFireBurnTime()
	{
	}
}
