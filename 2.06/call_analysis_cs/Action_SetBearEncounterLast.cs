using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

public class Action_SetBearEncounterLast : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public BBParameter<bool> isLast;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BearHuntRedux), Member = "SetLastEncounter")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetBearEncounterLast()
	{
	}
}
