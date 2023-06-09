using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_RetrieveLastItemInHands : ActionTask
{
	public string missionObjectIdentifier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AutoEquipItemInHandsAfterInteraction")]
	[Calls(Type = typeof(HeldItemInPlacementZone), Member = "MaybeProcessPickingUpPlacedItem")]
	[Calls(Type = typeof(PlayerManager), Member = "SetControlMode")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_RetrieveLastItemInHands()
	{
	}
}
