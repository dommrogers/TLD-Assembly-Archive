using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_SpawnPropAndTriggerAnim : ActionTask
{
	[Serializable]
	public class ConstrainedLimits
	{
		public Vector2 PitchLimitDegrees;

		public Vector2 YawLimitDegrees;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public ConstrainedLimits()
		{
		}
	}

	public BBParameter<string> trigger;

	public BBParameter<GameObject> prefab;

	public BBParameter<bool> propInWorldSpace;

	public BBParameter<bool> removePropOnComplete;

	public BBParameter<SpawnLocation> spawnLocation;

	public BBParameter<bool> disableCharacterController;

	public bool disableDefaultLayers;

	public float hipAndShoulderLayerWeight;

	public BBParameter<bool> loadAnimation;

	public BBParameter<FPAnimationState> fpAnimationState;

	private GameObject m_spawnedObject;

	private bool m_WasCharacterControllerEnabled;

	private bool m_HasDisabledCharacterController;

	public bool ConstrainCameraLimits;

	private ConstrainedLimits m_StartingConstainedLimits;

	public ConstrainedLimits ActionConstainedLimits;

	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[Calls(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[CallsUnknownMethods(Count = 57)]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "GetParentJoint")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 10)]
	private Transform GetParentJoint()
	{
		return null;
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[Calls(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnComplete")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void OnEnterPlaying(bool success)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[CallsUnknownMethods(Count = 8)]
	private void OnComplete()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Action_SpawnPropAndTriggerAnim()
	{
	}
}
