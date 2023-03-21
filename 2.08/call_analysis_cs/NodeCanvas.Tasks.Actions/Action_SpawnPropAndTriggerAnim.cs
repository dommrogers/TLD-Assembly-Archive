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

		[CallerCount(Count = 6)]
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

	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[Calls(Type = typeof(CinematicManager), Member = "StartMasterFP")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "SetYawLimit")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Utils), Member = "SetObjectAndChildrenLayer")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(PlayerManager), Member = "DisableCharacterController")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	private Transform GetParentJoint()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnComplete")]
	[Calls(Type = typeof(PlayerAnimation), Member = "UpdateHipAndShoulderOffsetLayerWeigth")]
	[Calls(Type = typeof(PlayerAnimation), Member = "Trigger_AnimatedInteraction")]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnterPlaying(bool success)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Action_SpawnPropAndTriggerAnim), Member = "OnEnterPlaying")]
	[Calls(Type = typeof(PlayerManager), Member = "EnableCharacterController")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	private void OnComplete()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public Action_SpawnPropAndTriggerAnim()
	{
	}
}
