using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.StateMachines;

public class State_SandboxSubFSM : State_TLDBaseFSM
{
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	protected override void OnEnter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NestedFSMState), Member = ".ctor")]
	public State_SandboxSubFSM()
	{
	}
}
