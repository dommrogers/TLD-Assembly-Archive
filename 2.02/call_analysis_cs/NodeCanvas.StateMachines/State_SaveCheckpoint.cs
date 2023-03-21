using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Tasks.Actions;

namespace NodeCanvas.StateMachines;

public class State_SaveCheckpoint : FSMState
{
	public bool waitForSaveToFinish;

	private bool m_RestoredFromSave;

	[CallerCount(Count = 0)]
	public void SetRestoredFromSave()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = ".ctor")]
	public State_SaveCheckpoint()
	{
	}
}
