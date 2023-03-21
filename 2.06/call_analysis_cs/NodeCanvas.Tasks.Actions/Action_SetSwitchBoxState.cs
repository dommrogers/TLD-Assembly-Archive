using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetSwitchBoxState : ActionTask
{
	public string missionObjectIdentifier;

	public SwitchToggleState switchState;

	public bool isLocked;

	[Calls(Type = typeof(Action_SetSwitchBoxState), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Action_SetSwitchBoxState), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetSwitchBoxState()
	{
	}
}
