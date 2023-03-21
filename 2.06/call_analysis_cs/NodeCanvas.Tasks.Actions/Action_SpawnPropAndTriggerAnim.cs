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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Transform), Member = "get_rotation")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[Calls(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[CallsUnknownMethods(Count = 5)]
	private Transform GetParentJoint()
	{
		return null;
	}

	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnComplete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void OnEnterPlaying(bool success)
	{
	}

	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 2)]
	private void OnComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 11)]
	public Action_SpawnPropAndTriggerAnim()
	{
	}
}
