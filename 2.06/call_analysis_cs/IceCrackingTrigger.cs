using System;
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

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerExit(Collider other)
	{
	}

	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "OverlapsFallTrigger")]
	[CallsUnknownMethods(Count = 2)]
	public bool Overlaps(Collider testedCollider)
	{
		return default(bool);
	}

	[Calls(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "Update")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "BreakIce")]
	public void FallInWater()
	{
	}

	[CallsUnknownMethods(Count = 32)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "MakeClothesWet")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	private void DidFallThroughIceFadeOut()
	{
	}

	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
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

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	private void ExtinguishLitItemInHands()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void BreakIce()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[CallsUnknownMethods(Count = 2)]
	private void MakeClothesWet()
	{
	}

	[CallerCount(Count = 0)]
	public IceCrackingTrigger()
	{
	}
}
