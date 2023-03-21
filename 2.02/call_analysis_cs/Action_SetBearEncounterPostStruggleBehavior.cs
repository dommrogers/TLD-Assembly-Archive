using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

public class Action_SetBearEncounterPostStruggleBehavior : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public BBParameter<BearEncounter.PostStruggleBehavior> postStruggleBehavior;

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetBearEncounterPostStruggleBehavior()
	{
	}
}
