using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_RemainingFireBurnTime : ConditionTask
{
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	public BBParameter<float> burnTimeHoursRemaining;

	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Fire), Member = "GetRemainingLifeTimeHours")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
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
