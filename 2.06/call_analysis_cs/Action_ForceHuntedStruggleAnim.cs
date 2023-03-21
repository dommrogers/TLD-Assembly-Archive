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

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Action_ForceHuntedStruggleAnim()
	{
	}
}
