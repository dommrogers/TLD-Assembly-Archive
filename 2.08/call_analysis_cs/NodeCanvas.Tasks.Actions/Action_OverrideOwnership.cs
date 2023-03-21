using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_OverrideOwnership : ActionTask
{
	public BBParameter<string> missionObjectIdentifierString;

	public BBParameter<string> trustId;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_OverrideOwnership), Member = "DoWork")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(OwnershipOverride), Member = "SetTrustId")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Action_OverrideOwnership), Member = "OnExecute")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_OverrideOwnership()
	{
	}
}
