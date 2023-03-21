using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_AuroraFielEnable : ActionTask
{
	public string missionObjectIdentifier;

	public bool enabled;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_AuroraFielEnable), Member = "DoWork")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraField), Member = "SetFieldActive")]
	[CalledBy(Type = typeof(Action_AuroraFielEnable), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 6)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_AuroraFielEnable()
	{
	}
}
