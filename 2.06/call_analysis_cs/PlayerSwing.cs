using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayerSwing : MonoBehaviour
{
	public string m_SwingVoiceOver;

	public string m_SwingToWardPredatorVoiceOver;

	public float m_DistanceForFleeCheckAfterSwing;

	private int m_AnimState_Swing;

	private float m_StaminaDrainPerSecond;

	private FirstPersonItem m_FirstPersonItem;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Swing")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Update")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public bool SwingIsPlaying()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 7)]
	public void Swing(FirstPersonItem fpi, PlayerAnimation.OnAnimationEvent midSwingEvent)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerSwing), Member = "WardPredatorsWithSwing")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnBrandishBegin()
	{
	}

	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerSwing), Member = "OnBrandishBegin")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeDueToTorchSwing")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool WardPredatorsWithSwing()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public PlayerSwing()
	{
	}
}
