using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_AuroraFielIntensity : ActionTask
{
	public string missionObjectIdentifier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_AuroraFielIntensity), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_AuroraFielIntensity), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_AuroraFielIntensity()
	{
	}
}
