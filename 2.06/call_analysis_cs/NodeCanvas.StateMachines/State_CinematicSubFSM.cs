using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class State_CinematicSubFSM : NestedFSMState
{
	public string cinematicFile;

	public string cinematicDescription;

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	protected override void OnEnter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NestedFSMState), Member = ".ctor")]
	public State_CinematicSubFSM()
	{
	}
}
