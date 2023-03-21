using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;

namespace NodeCanvas.Tasks.Actions;

public class Action_StartSideMission : ActionTask<GraphOwner>
{
	public string missionId;

	public int ifCompletionCountLessThan;

	public bool restartIfAlreadyActive;

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopMission")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsMissionActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_StartSideMission()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
