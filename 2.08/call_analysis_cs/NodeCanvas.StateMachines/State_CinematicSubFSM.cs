using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class State_CinematicSubFSM : NestedFSMState
{
	public string cinematicFile;

	public string cinematicDescription;

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NestedFSMState), Member = "OnEnter")]
	protected override void OnEnter()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NestedFSMState), Member = ".ctor")]
	[DeduplicatedMethod]
	public State_CinematicSubFSM()
	{
	}
}
