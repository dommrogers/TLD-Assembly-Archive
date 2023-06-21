using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.StateMachines;

public class State_CinematicSubFSM : NestedFSMState
{
	public string cinematicFile;

	public string cinematicDescription;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Node), Member = "get_graphBlackboard")]
	[Calls(Type = typeof(NCUtils), Member = "GetOrAddVar")]
	[Calls(Type = typeof(Variable<>), Member = "set_value")]
	[Calls(Type = typeof(NestedFSMState), Member = "OnEnter")]
	[CallsUnknownMethods(Count = 1)]
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
