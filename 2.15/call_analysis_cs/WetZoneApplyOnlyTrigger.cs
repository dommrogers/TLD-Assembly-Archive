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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[Calls(Type = typeof(CameraEffects), Member = "WaterPulse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(GearItem), Member = "ExtinguishLitItem")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "IncreaseWetness")]
	[Calls(Type = typeof(WetZoneApplyOnlyTrigger), Member = "AddFreezing")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 1)]
	private void AddFreezing(float freezingValue)
	{
	}

	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneApplyOnlyTrigger), Member = "OnTriggerEnter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private void IncreaseWetness(float wetnessValue)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WetZoneApplyOnlyTrigger()
	{
	}
}
