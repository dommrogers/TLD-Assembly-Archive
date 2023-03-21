using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_RestrictFirePlacementToVolume : ActionTask
{
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_RestrictFirePlacementToVolume), Member = "DoWork")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Action_RestrictFirePlacementToVolume), Member = "OnExecute")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_RestrictFirePlacementToVolume()
	{
	}
}
