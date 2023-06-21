using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_RescueZoneFireFlareGun : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_RescueZoneFireFlareGun()
	{
	}
}
