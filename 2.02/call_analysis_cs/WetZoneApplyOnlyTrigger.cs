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

	[Calls(Type = typeof(CameraStatusEffects), Member = "WaterPulse")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "ExtinguishLitItem")]
	[CallsUnknownMethods(Count = 7)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CallsUnknownMethods(Count = 2)]
	private void AddFreezing(float freezingValue)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void IncreaseWetness(float wetnessValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WetZoneApplyOnlyTrigger()
	{
	}
}
