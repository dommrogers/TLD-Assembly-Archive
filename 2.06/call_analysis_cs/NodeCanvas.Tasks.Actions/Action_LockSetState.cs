using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_LockSetState : ActionTask
{
	public string missionObjectIdentifier;

	public LockState lockState;

	[Calls(Type = typeof(Action_LockSetState), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "OnExecute")]
	[Calls(Type = typeof(Lock), Member = "UnlockCompanionLock")]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_LockSetState()
	{
	}
}
