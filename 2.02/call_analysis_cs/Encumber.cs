using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
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

	private EncumberLevel m_EcumberLevelForPreviousVoiceOver;

	private float m_NumSecondsSinceLastVoiceOver;

	private CarryingCapacityBuff.BuffValues m_CarryingCapacityBuffValues;

	private float m_GearWeightKG;

	private bool m_EncumberedInLog;

	private bool m_StartHasBeenCalled;

	private static EncumberSaveDataProxy m_EncumberSaveDataProxy;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CalledBy(Type = typeof(Encumber), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 10)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Encumber), Member = "MaybePlayerEncumberStatusVoiceOver")]
	[Calls(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	public void Update()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Encumber), Member = "Start")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CallerCount(Count = 2)]
	public float GetEncumbranceSlowdownMultiplier()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public float GetHourlyCalorieBurnFromWeight()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsCapacityBuffed()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CallerCount(Count = 0)]
	public bool IsEncumbered()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[CalledBy(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[CalledBy(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "ComputeSprainChanceForEncumberance")]
	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	public bool IsEncumberedIgnoringPlaceMesh()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumbered")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(RopeClimbPoint), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	public float GetEffectiveCarryCapacityKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(Encumber), Member = "GetCapacityString")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallerCount(Count = 2)]
	public string GetPlayerCarryCapacityString()
	{
		return null;
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 53)]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	public string GetCapacityString(float weightKG, float effectiveCapacityKG, float capacityKG, float capacityKGBuff)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float GetGearWeightKG()
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	public float GetMaxCarryCapacityKG()
	{
		return default(float);
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public float GetMaxCarryCapacityWhenExhaustedKG()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	public float GetNoSprintCarryCapacityKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetNoWalkCarryCapacityKG()
	{
		return default(float);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	public float GetEncumberLowThresholdKG()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 2)]
	public float GetEncumberMedThresholdKG()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybePlayerEncumberStatusVoiceOver()
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CalledBy(Type = typeof(Encumber), Member = "Start")]
	[CalledBy(Type = typeof(Encumber), Member = "ShouldPlayEncumbereVoiceOver")]
	[CalledBy(Type = typeof(Encumber), Member = "MaybePlayerEncumberStatusVoiceOver")]
	[CalledBy(Type = typeof(Encumber), Member = "MaybePlayerEncumberStatusVoiceOver")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	private EncumberLevel GetEncumberLevel()
	{
		return default(EncumberLevel);
	}

	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 48)]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	private void UpdateEncumberedStatusOnHUD()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void MaybeUpdateEncumberedStatusInLog()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public Encumber()
	{
	}
}
