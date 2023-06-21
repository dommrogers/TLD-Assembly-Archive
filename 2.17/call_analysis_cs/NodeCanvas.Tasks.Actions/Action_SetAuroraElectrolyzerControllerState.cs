using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetAuroraElectrolyzerControllerState : ActionTask
{
	public string controllerMissionObjectIdentifier;

	public bool active;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetAuroraElectrolyzerControllerState()
	{
	}
}
