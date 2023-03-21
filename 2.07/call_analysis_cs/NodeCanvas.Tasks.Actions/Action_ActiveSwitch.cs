using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_ActiveSwitch : ActionTask
{
	public string missionObjectIdentifier;

	public int activeIndex;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Action_ActiveSwitch), Member = "DoWork")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(ActiveSwitch), Member = "SetActiveStateIndex")]
	[CalledBy(Type = typeof(Action_ActiveSwitch), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_ActiveSwitch()
	{
	}
}
