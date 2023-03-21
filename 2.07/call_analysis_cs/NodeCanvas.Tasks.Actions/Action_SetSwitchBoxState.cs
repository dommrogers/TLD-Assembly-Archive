using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetSwitchBoxState : ActionTask
{
	public string missionObjectIdentifier;

	public SwitchToggleState switchState;

	public bool isLocked;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SetSwitchBoxState), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SetSwitchBoxState), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetSwitchBoxState()
	{
	}
}
