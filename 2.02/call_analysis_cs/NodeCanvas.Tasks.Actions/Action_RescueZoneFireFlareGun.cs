using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_RescueZoneFireFlareGun : ActionTask
{
	public BBParameter<string> missionObjectIdentifier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_RescueZoneFireFlareGun), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(RescueZone), Member = "FireFlareGun")]
	[CalledBy(Type = typeof(Action_RescueZoneFireFlareGun), Member = "OnExecute")]
	private void DoWork()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_RescueZoneFireFlareGun()
	{
	}
}
