using Cpp2ILInjected.CallAnalysis;

namespace NodeCanvas.StateMachines;

public class State_StorySubFSM : State_TLDBaseFSM
{
	public string stageId;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(NestedFSMState), Member = ".ctor")]
	public State_StorySubFSM()
	{
	}
}
