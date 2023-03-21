using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[Calls(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 7)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 3)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(IceCrackingManager), Member = "OverlapsFallTrigger")]
	[Calls(Type = typeof(Utils), Member = "OrientedBoundingBoxesOverlap")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Collider), Member = "get_bounds")]
	public bool Overlaps(Collider testedCollider)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "Update")]
	[CalledBy(Type = typeof(BreakableIce), Member = "Update")]
	[Calls(Type = typeof(IceCrackingManager), Member = "GetRespawnLocation")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(Condition), Member = "AddHealth")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "BreakIce")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	public void FallInWater()
	{
	}

	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(GameManager), Member = "HandlePlayerDeath")]
	[Calls(Type = typeof(CameraFade), Member = "StartAlphaFade")]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "MakeClothesWet")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(IceCrackingTrigger), Member = "ExtinguishLitItemInHands")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(AnimatedInteraction), Member = "InterruptAnyInProgressAnimations")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DidFallThroughIceFadeOut()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Hypothermia), Member = "HypothermiaStart")]
	[CallsUnknownMethods(Count = 6)]
	private void DidFallThroughIceFadeIn()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PlayerStruggle), Member = "InStruggle")]
	[Calls(Type = typeof(PlayerStruggle), Member = "MakePartnerFlee")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ExitStruggleIfActive()
	{
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 44)]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[Calls(Type = typeof(NoiseMakerItem), Member = "OnDroppedInWater")]
	[Calls(Type = typeof(GearItem), Member = "IsLitNoiseMaker")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "IsLitLamp")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(MatchesItem), Member = "PutOut")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	[Calls(Type = typeof(GearItem), Member = "IsLitTorch")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlare")]
	[Calls(Type = typeof(FlareItem), Member = "BurnOut")]
	private void ExtinguishLitItemInHands()
	{
	}

	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "FallInWater")]
	[CallsUnknownMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void BreakIce()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(IceCrackingTrigger), Member = "DidFallThroughIceFadeOut")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void MakeClothesWet()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public IceCrackingTrigger()
	{
	}
}
