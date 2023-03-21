using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetAuroraElectrolyzerControllerVolume : ActionTask
{
	public string controllerMissionObjectIdentifier;

	public string volumeName;

	public bool active;

	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetAuroraElectrolyzerControllerVolume()
	{
	}
}
