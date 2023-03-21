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

		[CallerCount(Count = 0)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionServicesManager), Member = "FindMissionObject")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerTransform")]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation")]
	[Calls(Type = typeof(Quaternion), Member = "get_eulerAngles")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "op_Implicit")]
	public Action_ForceHuntedStruggleAnim()
	{
	}
}
