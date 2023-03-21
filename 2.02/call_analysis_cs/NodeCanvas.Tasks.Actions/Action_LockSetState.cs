using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_LockSetState : ActionTask
{
	public string missionObjectIdentifier;

	public LockState lockState;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_LockSetState), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(Lock), Member = "UnlockCompainionLock")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "OnExecute")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_LockSetState()
	{
	}
}
