using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_OverrideOwnership : ActionTask
{
	public BBParameter<string> missionObjectIdentifierString;

	public BBParameter<string> trustId;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_OverrideOwnership), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(Action_OverrideOwnership), Member = "OnExecute")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(OwnershipOverride), Member = "SetTrustId")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "OverrideOwnership")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_OverrideOwnership()
	{
	}
}
