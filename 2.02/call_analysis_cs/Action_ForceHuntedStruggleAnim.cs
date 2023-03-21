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
			[CallsDeduplicatedMethods(Count = 1)]
			get
			{
				return null;
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(ActionTask), Member = "EndAction")]
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

	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Action_ForceHuntedStruggleAnim()
	{
	}
}
