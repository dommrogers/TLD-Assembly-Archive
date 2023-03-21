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
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	private void AddFreezing(float freezingValue)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void IncreaseWetness(float wetnessValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WetZoneApplyOnlyTrigger()
	{
	}
}
