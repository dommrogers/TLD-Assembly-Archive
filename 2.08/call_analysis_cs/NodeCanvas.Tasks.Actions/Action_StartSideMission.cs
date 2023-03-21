using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_StartSideMission : ActionTask<GraphOwner>
{
	public string missionId;

	public int ifCompletionCountLessThan;

	public bool restartIfAlreadyActive;

	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetMissionManager")]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsMissionActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "ProcessRemoveMissionList")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public Action_StartSideMission()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
