using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class State_GameplaySubFSM : State_TLDBaseFSM
{
	public string gameplayDescription;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(State_TLDBaseFSM), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnEnter()
	{
	}

	[Calls(Type = typeof(NestedFSMState), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public State_GameplaySubFSM()
	{
	}
}
