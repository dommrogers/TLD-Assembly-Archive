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

	[CalledBy(Type = typeof(Encumber), Member = "Deserialize")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "MaybePlayerEncumberStatusVoiceOver")]
	[Calls(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "Start")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(vp_FPSController), Member = "UpdateMoves")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "PlayerIsSprinting")]
	[Calls(Type = typeof(Encumber), Member = "GetNoWalkCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetNoSprintCarryCapacityKG")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetEncumbranceSlowdownMultiplier()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	public float GetHourlyCalorieBurnFromWeight()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool IsCapacityBuffed()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	public bool IsEncumbered()
	{
		return false;
	}

	[CalledBy(Type = typeof(Sprains), Member = "MaybeSprainWhileMoving")]
	[CalledBy(Type = typeof(Sprains), Member = "ComputeSprainChanceForEncumberance")]
	[CalledBy(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[CalledBy(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(PlayerManager), Member = "IsInMeshPlacementMode")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "ObjectToPlaceInInventory")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsEncumberedIgnoringPlaceMesh()
	{
		return false;
	}

	[CalledBy(Type = typeof(Condition), Member = "IsPlayerVulnerable")]
	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumbered")]
	[CalledBy(Type = typeof(Encumber), Member = "IsEncumberedIgnoringPlaceMesh")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[CalledBy(Type = typeof(RopeClimbPoint), Member = "ProcessInteraction")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public float GetEffectiveCarryCapacityKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public string GetPlayerCarryCapacityString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 53)]
	public string GetCapacityString(float weightKG, float effectiveCapacityKG, float capacityKG, float capacityKGBuff)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetGearWeightKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Fatigue), Member = "CalculateFatigueIncrease")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetMaxCarryCapacityKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetMaxCarryCapacityWhenExhaustedKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetNoSprintCarryCapacityKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetNoWalkCarryCapacityKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetEncumberLowThresholdKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetEncumberMedThresholdKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public float GetEncumberHighThresholdKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	private bool ShouldPlayEncumbereVoiceOver()
	{
		return false;
	}

	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void MaybePlayerEncumberStatusVoiceOver()
	{
	}

	[CalledBy(Type = typeof(Encumber), Member = "Start")]
	[CalledBy(Type = typeof(Encumber), Member = "ShouldPlayEncumbereVoiceOver")]
	[CalledBy(Type = typeof(Encumber), Member = "MaybePlayerEncumberStatusVoiceOver")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private EncumberLevel GetEncumberLevel()
	{
		return default(EncumberLevel);
	}

	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 20)]
	[CallsUnknownMethods(Count = 48)]
	private void UpdateEncumberedStatusOnHUD()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeUpdateEncumberedStatusInLog()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Encumber()
	{
	}
}
