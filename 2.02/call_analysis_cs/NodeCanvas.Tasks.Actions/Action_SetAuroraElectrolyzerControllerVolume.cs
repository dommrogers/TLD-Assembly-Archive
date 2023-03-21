using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetAuroraElectrolyzerControllerVolume : ActionTask
{
	public string controllerMissionObjectIdentifier;

	public string volumeName;

	public bool active;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(AuroraElectrolizerController), Member = "SetPowerState")]
	[CallsUnknownMethods(Count = 1)]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_SetAuroraElectrolyzerControllerVolume()
	{
	}
}
