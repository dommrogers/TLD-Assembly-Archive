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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(PlayerMovement), Member = "AddSprintStamina")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerIsSwingingFirstPersonItem")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Update")]
	[CalledBy(Type = typeof(PlayerSwing), Member = "Swing")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerAnimation), Member = "FirstPersonHandsEnabled")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FirstPersonItem), Member = "AnimIsPlaying")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public bool SwingIsPlaying()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerSwing), Member = "SwingIsPlaying")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerAnimation), Member = "MaybeSetState")]
	[Calls(Type = typeof(PlayerAnimation), Member = "ClearOutstandingCallbacks")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 12)]
	public void Swing(FirstPersonItem fpi, PlayerAnimation.OnAnimationEvent midSwingEvent)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerSwing), Member = "WardPredatorsWithSwing")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private void OnBrandishBegin()
	{
	}

	[CalledBy(Type = typeof(PlayerSwing), Member = "OnBrandishBegin")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Vector3), Member = "Distance")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(BaseAi), Member = "MaybeFleeDueToTorchSwing")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 15)]
	private bool WardPredatorsWithSwing()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayerSwing()
	{
	}
}
