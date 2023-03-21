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

	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(Action_AuroraFielEnable), Member = "OnExecute")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallsUnknownMethods(Count = 2)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_AuroraFielEnable()
	{
	}
}
