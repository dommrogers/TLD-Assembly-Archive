using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.StateMachines;

public class SideMissionManager : MissionManagerBase
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	public SideMissionManager(string name, FSMOwner fsmOwner)
		: base(null, null)
	{
	}
}
