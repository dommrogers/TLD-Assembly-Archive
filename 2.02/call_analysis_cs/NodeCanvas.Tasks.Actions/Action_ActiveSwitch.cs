using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_ActiveSwitch : ActionTask
{
	public string missionObjectIdentifier;

	public int activeIndex;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_ActiveSwitch), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_ActiveSwitch), Member = "OnExecute")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ActiveSwitch), Member = "SetActiveStateIndex")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_ActiveSwitch()
	{
	}
}
