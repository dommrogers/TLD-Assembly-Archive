using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

public class Action_SetBearEncounterPostStruggleBehavior : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public BBParameter<BearEncounter.PostStruggleBehavior> postStruggleBehavior;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(BearHuntRedux), Member = "SetPostStruggleBehavior")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 9)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetBearEncounterPostStruggleBehavior()
	{
	}
}
