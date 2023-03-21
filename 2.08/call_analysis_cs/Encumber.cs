using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.Serialization;
using TLD.UI.Generics;
using UnityEngine;

public class Encumber : MonoBehaviour
{
	public float m_MaxCarryCapacityKG;

	public float m_MaxCarryCapacityWhenExhaustedKG;

	public float m_ReduceCarryCapacityAtFatigue;

	public float m_NoSprintCarryCapacityKG;

	public float m_NoWalkCarryCapacityKG;

	public float m_HourlyCalorieBurnPerKG;

	public float m_EncumberLowThresholdKG;

	public float m_EncumberMedThresholdKG;

	public float m_EncumberHighThresholdKG;

	public string m_EncumberLowVoiceOver;

	public string m_EncumberMedVoiceOver;

	public string m_EncumberHighVoiceOver;

	public float m_MinSecondsBetweenVoiceOverVariations;

	private PanelReference<Panel_HUD> m_HUD;

	private PanelReference<Panel_Inventory> m_Inventory;

	private EncumberLevel m_EcumberLevelForPreviousVoiceOver;

	private float m_NumSecondsSinceLastVoiceOver;

	private CarryingCapacityBuff.BuffValues m_CarryingCapacityBuffValues;

	private float m_GearWeightKG;

	private bool m_EncumberedInLog;

	private bool m_StartHasBeenCalled;

	private static EncumberSaveDataProxy m_EncumberSaveDataProxy;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	public void Start()
	{
	}

	[Calls(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	public void Deserialize(string text)
	{
	}

	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	public float GetEncumbranceSlowdownMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetHourlyCalorieBurnFromWeight()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	public bool IsCapacityBuffed()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	public bool IsEncumbered()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[CalledBy(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "ComputeSprainChanceForEncumberance")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	public bool IsEncumberedIgnoringPlaceMesh()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(RopeClimbPoint), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumbered")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	public float GetEffectiveCarryCapacityKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	public string GetPlayerCarryCapacityString()
	{
		return null;
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public string GetCapacityString(float weightKG, float effectiveCapacityKG, float capacityKG, float capacityKGBuff)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetGearWeightKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	public float GetMaxCarryCapacityKG()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMaxCarryCapacityWhenExhaustedKG()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	public float GetNoSprintCarryCapacityKG()
	{
		return default(float);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNoWalkCarryCapacityKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallerCount(Count = 0)]
	public float GetEncumberLowThresholdKG()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	public float GetEncumberMedThresholdKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	public float GetEncumberHighThresholdKG()
	{
		return default(float);
	}

	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CallerCount(Count = 0)]
	private bool ShouldPlayEncumbereVoiceOver()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybePlayerEncumberStatusVoiceOver()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Encumber), Member = "MaybePlayerEncumberStatusVoiceOver")]
	[CalledBy(Type = typeof(Encumber), Member = "MaybePlayerEncumberStatusVoiceOver")]
	[CalledBy(Type = typeof(Encumber), Member = "ShouldPlayEncumbereVoiceOver")]
	[CalledBy(Type = typeof(Encumber), Member = "Deserialize")]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Encumber), Member = "Start")]
	private EncumberLevel GetEncumberLevel()
	{
		return default(EncumberLevel);
	}

	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateEncumberedStatusOnHUD()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void MaybeUpdateEncumberedStatusInLog()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Encumber()
	{
	}
}
