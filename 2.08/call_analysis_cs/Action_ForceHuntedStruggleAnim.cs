using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

public class Action_ForceHuntedStruggleAnim : ActionTask
{
	public class Action_SetBearEncounterPlayerOutcomeAfterSpearMiss : ActionTask
	{
		public bool m_PlayerDies;

		protected override string info
		{
			[CallerCount(Count = 0)]
			get
			{
				return null;
			}
		}

		[Calls(Type = typeof(ActionTask), Member = "EndAction")]
		[CallerCount(Count = 0)]
		protected override void OnExecute()
		{
		}

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public Action_SetBearEncounterPlayerOutcomeAfterSpearMiss()
		{
		}
	}

	public BBParameter<bool> forceHuntedStruggleAnim;

	public BBParameter<bool> dropItems;

	public BBParameter<bool> shouldForceHuntedStruggleDragFacing;

	public BBParameter<float> forceHuntedStruggleDragFacingAngle;

	public BBParameter<float> forceHuntedStruggleDragRollAngle;

	public string struggleFaceTargetObjectIdentifier;

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Action_ForceHuntedStruggleAnim()
	{
	}
}
