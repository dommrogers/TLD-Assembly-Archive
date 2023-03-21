using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;

namespace NodeCanvas.Tasks.Actions;

public class Action_StartSideMission : ActionTask<GraphOwner>
{
	public string missionId;

	public int ifCompletionCountLessThan;

	public bool restartIfAlreadyActive;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "IsMissionActive")]
	[Calls(Type = typeof(MissionServicesManager), Member = "StopMission")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(uConsole), Member = "RunCommandSilent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Action_StartSideMission()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
