using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.StateMachines;

public class MainMissionManager : MissionManagerBase
{
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionManagerBase), Member = ".ctor")]
	public MainMissionManager(string name, FSMOwner fsmOwner)
		: base(null, null)
	{
	}
}
