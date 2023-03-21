using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WetZoneApplyOnlyTrigger : MonoBehaviour
{
	public List<ClothingRegion> m_ClothingRegionsToMakeWet;

	public bool m_OnlyOuterLayerGetWet;

	public float m_WetnessIncreasePerHour;

	public bool m_InstantWetOnContact;

	public bool m_UnfreezeOnContact;

	public float m_ColdIncreasePerHour;

	public float m_ColdIncreaseOnEntry;

	public bool m_EnableWaterEffect;

	public bool m_ExtingquishHeldItem;

	private bool m_PlayerInTrigger;

	public string m_PlayerVoiceOver;

	public bool m_VoiceOverIsCritical;

	[Calls(Type = typeof(CameraEffects), Member = "WaterPulse")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	private void Update()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 1)]
	private void AddFreezing(float freezingValue)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallerCount(Count = 2)]
	private void IncreaseWetness(float wetnessValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WetZoneApplyOnlyTrigger()
	{
	}
}
