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
	[CallsDeduplicatedMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Swing")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Update")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimIsPlaying")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool SwingIsPlaying()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsUnknownMethods(Count = 12)]
	public void Swing(FirstPersonItem fpi, PlayerAnimation.OnAnimationEvent midSwingEvent)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(PlayerSwing), Member = "WardPredatorsWithSwing")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void OnBrandishBegin()
	{
	}

	[Calls(Type = typeof(Transform), Member = "get_position")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "OnBrandishBegin")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeDueToTorchSwing")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	private bool WardPredatorsWithSwing()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerSwing()
	{
	}
}
