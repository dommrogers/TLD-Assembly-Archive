using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.StateMachines;

public class MainMissionManager : MissionManagerBase
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public MainMissionManager(string name, FSMOwner fsmOwner)
		: base(null, null)
	{
	}
}
