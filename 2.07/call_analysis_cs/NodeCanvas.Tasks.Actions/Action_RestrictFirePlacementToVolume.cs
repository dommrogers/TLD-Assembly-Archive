using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_RestrictFirePlacementToVolume : ActionTask
{
	public BBParameter<string> collisionVolumeMissionObjectIdentifier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action_RestrictFirePlacementToVolume), Member = "DoWork")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CalledBy(Type = typeof(Action_RestrictFirePlacementToVolume), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 7)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	private void DoWork()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_RestrictFirePlacementToVolume()
	{
	}
}
