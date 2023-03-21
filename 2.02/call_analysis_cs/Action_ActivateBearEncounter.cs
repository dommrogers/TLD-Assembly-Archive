using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

public class Action_ActivateBearEncounter : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	public BBParameter<bool> activate;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(BearHuntRedux), Member = "ActivateEncounter")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
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
