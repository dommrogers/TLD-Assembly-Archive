using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

public class Action_ActivateBearEncounter : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public BBParameter<bool> activate;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ActivateBearEncounter()
	{
	}
}
