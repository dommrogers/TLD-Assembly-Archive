using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_IsInMissionTrigger : ActionTask<GraphOwner>
{
	public bool checkForPlayer;

	public BBParameter<string> checkForMissionObjectId;

	public BBParameter<string> checkForTriggerId;

	public MissionTriggerType triggerType;

	public string storeAssociatedDataVar;

	public string successEvent;

	public string failureEvent;

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(MissionTrigger), Member = "ParseAssociatedData")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsPlayerInMissionTrigger")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsMissionObjectInMissionTrigger")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 13)]
	public Action_IsInMissionTrigger()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
