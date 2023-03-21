using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.StateMachines;

public class SideMissionManager : MissionManagerBase
{
	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public SideMissionManager(string name, FSMOwner fsmOwner)
		: base(null, null)
	{
	}
}
