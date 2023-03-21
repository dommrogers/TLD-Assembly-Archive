using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI.Generics;
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

	private PanelReference<Panel_HUD> m_HUD;

	private bool m_PlayerInTrigger;

	private bool m_ShowedContactLocID;

	private float m_SecondsInTrigger;

	private int m_BrokenIceCount;

	private BreakableIce m_BreakableIce;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(vp_Layer), Member = "Set")]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(WetZoneTrigger), Member = "BreakIce")]
	[Calls(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_HUD), Member = "ClearWarningMessage")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	[Calls(Type = typeof(WetZoneTrigger), Member = "IncreaseWetness")]
	[CallsUnknownMethods(Count = 1)]
	private void OnTriggerEnter(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_HUD), Member = "ClearWarningMessage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "CompareTag")]
	private void OnTriggerExit(Collider other)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(ClothingItem), Member = "IsOutermostItemInClothingRegion")]
	[Calls(Type = typeof(ClothingItem), Member = "IncreaseWetnessPercent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Update")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "OnTriggerEnter")]
	private void IncreaseWetness(float wetnessValue)
	{
	}

	[Calls(Type = typeof(Freezing), Member = "AddFreezing")]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void ApplyFreezing()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BreakableIce), Member = "BreakIce")]
	[CalledBy(Type = typeof(WetZoneTrigger), Member = "Update")]
	[CallsUnknownMethods(Count = 5)]
	private void BreakIce()
	{
	}

	[CallerCount(Count = 0)]
	public WetZoneTrigger()
	{
	}
}
