using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

public class Action_ActivateBearEncounter : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public BBParameter<bool> activate;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ActivateBearEncounter()
	{
	}
}
