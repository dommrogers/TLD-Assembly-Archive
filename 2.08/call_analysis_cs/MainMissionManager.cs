using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.StateMachines;

public class MainMissionManager : MissionManagerBase
{
	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public MainMissionManager(string name, FSMOwner fsmOwner)
		: base(null, null)
	{
	}
}
