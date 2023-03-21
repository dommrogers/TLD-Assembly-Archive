using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetAuroraElectrolyzerControllerState : ActionTask
{
	public string controllerMissionObjectIdentifier;

	public bool active;

	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerStateAll")]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_SetAuroraElectrolyzerControllerState()
	{
	}
}
