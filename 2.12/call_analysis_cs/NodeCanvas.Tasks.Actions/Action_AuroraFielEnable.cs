using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_AuroraFielEnable : ActionTask
{
	public string missionObjectIdentifier;

	public bool enabled;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_AuroraFielEnable), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_AuroraFielEnable), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetMissionServicesManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_AuroraFielEnable()
	{
	}
}
