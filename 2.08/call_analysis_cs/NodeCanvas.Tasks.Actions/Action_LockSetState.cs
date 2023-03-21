using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Lock), Member = "SetLockState")]
	[Calls(Type = typeof(Lock), Member = "UnlockCompanionLock")]
	[CalledBy(Type = typeof(Action_LockSetState), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_LockSetState()
	{
	}
}
