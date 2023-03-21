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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Swing")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(FirstPersonItem), Member = "TryGetFPSWeapon")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorStateInfo")]
	public bool SwingIsPlaying()
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Swing(FirstPersonItem fpi, PlayerAnimation.OnAnimationEvent midSwingEvent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerSwing), Member = "WardPredatorsWithSwing")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 3)]
	private void OnBrandishBegin()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerSwing), Member = "OnBrandishBegin")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeDueToTorchSwing")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	private bool WardPredatorsWithSwing()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PlayerSwing()
	{
	}
}
