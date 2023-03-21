using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class State_SaveCheckpoint : FSMState
{
	private bool m_RestoredFromSave;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetRestoredFromSave()
	{
	}

	[CallerCount(Count = 0)]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnUpdate()
	{
	}

	[Calls(Type = typeof(Node), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public State_SaveCheckpoint()
	{
	}
}
