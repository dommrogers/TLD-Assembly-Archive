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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallsUnknownMethods(Count = 6)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 4)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[CalledBy(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "ComputeSprainChanceForEncumberance")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public bool IsEncumberedIgnoringPlaceMesh()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(RopeClimbPoint), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumbered")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[CalledBy(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	public float GetEffectiveCarryCapacityKG()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[Calls(Type = typeof(Encumber), Member = "GetCapacityString")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	public string GetPlayerCarryCapacityString()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 45)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
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

	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
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

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNoSprintCarryCapacityKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallerCount(Count = 2)]
	public float GetNoWalkCarryCapacityKG()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
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
	[CalledBy(Type = typeof(Encumber), Member = "Start")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	private EncumberLevel GetEncumberLevel()
	{
		return default(EncumberLevel);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateEncumberedStatusOnHUD()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void MaybeUpdateEncumberedStatusInLog()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public Encumber()
	{
	}
}
