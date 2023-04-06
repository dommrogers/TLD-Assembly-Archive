using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public class IceCrackingTrigger : MonoBehaviour
{
	public float m_SecondsBeforeIceCracks;

	public string m_FallThroughIceAudio;

	public bool m_KillPlayer;

	public string m_KillPlayerDeathCauseLocId;

	public List<ClothingRegion> m_ClothingRegionsToMakeWet;

	public bool m_SetLayerToTriggerIgnoreRaycast;

	private bool m_PlayerInTrigger;

	private float m_IceCrackingTimer;

	private Vector3 m_RespawnLocation;

	private static bool m_FallingIntoWater;

	private Collider[] m_Colliders;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool TryUpdateTimer()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool IsTimerFinished()
	{
		return false;
	}

	[CalledBy(Type = typeof(IceCrackingManager), Member = "OverlapsFallTrigger")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	public bool Overlaps(Collider testedCollider)
	{
		return false;
	}

	[CalledBy(Type = typeof(IceCrackingManager), Member = "Update")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "BreakIce")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public void FallInWater()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "MakeClothesWet")]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void DidFallThroughIceFadeOut()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[CallsUnknownMethods(Count = 1)]
	private void DidFallThroughIceFadeIn()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CallsUnknownMethods(Count = 2)]
	private void ExitStruggleIfActive()
	{
	}

	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[CallsUnknownMethods(Count = 13)]
	private void ExtinguishLitItemInHands()
	{
	}

	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private void BreakIce()
	{
	}

	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void MakeClothesWet()
	{
	}

	[CallerCount(Count = 0)]
	public IceCrackingTrigger()
	{
	}
}
