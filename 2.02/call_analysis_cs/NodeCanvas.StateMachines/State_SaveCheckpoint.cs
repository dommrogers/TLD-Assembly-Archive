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
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Action_SaveCheckpoint), Member = "MaybeSave")]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public State_SaveCheckpoint()
	{
	}
}
