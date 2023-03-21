using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WetZoneTrigger : MonoBehaviour
{
	public List<ClothingRegion> m_ClothingRegionsToMakeWet;

	public bool m_OnlyOuterLayerGetWet;

	public float m_WetnessIncreasePerHour;

	public bool m_InstantWetOnContact;

	public bool m_UnfreezeOnContact;

	public string m_LocIDToShowOnContact;

	public float m_DelaySeconds;

	public string m_LocIDToShowDuringDelay;

	public float m_ColdIncreaseOnWaterEntry;

	public float m_ColdIncreasePerHour;

	public bool m_SetLayerToTriggerIgnoreRaycast;

	private bool m_PlayerInTrigger;

	private bool m_ShowedContactLocID;

	private float m_SecondsInTrigger;

	private int m_BrokenIceCount;

	private BreakableIce m_BreakableIce;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Panel_HUD), Member = "ClearWarningMessage")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(WetZoneTrigger), Member = "ApplyFreezing")]
	[Calls(Type = typeof(WetZoneTrigger), Member = "BreakIce")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	private void Update()
	{
	}

	[Calls(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(Panel_HUD), Member = "ClearWarningMessage")]
	[CallsUnknownMethods(Count = 2)]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	private void IncreaseWetness(float wetnessValue)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Update")]
	[CallsUnknownMethods(Count = 7)]
	private void ApplyFreezing()
	{
	}

	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Update")]
	[Calls(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void BreakIce()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public WetZoneTrigger()
	{
	}
}
