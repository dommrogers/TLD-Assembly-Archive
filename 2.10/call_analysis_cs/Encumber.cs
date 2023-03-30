using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas;
using TLD.SaveState;
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[Calls(Type = typeof(Encumber), Member = "UpdateEncumberedStatusOnHUD")]
	[Calls(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
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
	[CallsUnknownMethods(Count = 1)]
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
	[CallsUnknownMethods(Count = 1)]
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
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 1)]
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
	[CalledBy(Type = typeof(RopeClimbPoint), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(PlayerMovement), Member = "MovedDistance")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetGameState")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 3)]
	public float GetEffectiveCarryCapacityKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "InitLabelsForGear")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(Encumber), Member = "GetMaxCarryCapacityKG")]
	[Calls(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CallsUnknownMethods(Count = 1)]
	public string GetPlayerCarryCapacityString()
	{
		return null;
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Utils), Member = "GetStringFromColor")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsUnknownMethods(Count = 45)]
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
	[CallsUnknownMethods(Count = 1)]
	public float GetMaxCarryCapacityKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	public float GetMaxCarryCapacityWhenExhaustedKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CalledBy(Type = typeof(PlayerManager), Member = "PlayerCantSprintBecauseOfInjury")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNoSprintCarryCapacityKG()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(Encumber), Member = "GetEncumbranceSlowdownMultiplier")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	public float GetNoWalkCarryCapacityKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	public float GetEncumberLowThresholdKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	public float GetEncumberMedThresholdKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encumber), Member = "GetEncumberLevel")]
	[Calls(Type = typeof(PlayerVoice), Member = "Play")]
	[CallsUnknownMethods(Count = 4)]
	private void MaybePlayerEncumberStatusVoiceOver()
	{
	}

	[CalledBy(Type = typeof(Encumber), Member = "Start")]
	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[CalledBy(Type = typeof(Encumber), Member = "Deserialize")]
	[CalledBy(Type = typeof(Encumber), Member = "ShouldPlayEncumbereVoiceOver")]
	[CalledBy(Type = typeof(Encumber), Member = "MaybePlayerEncumberStatusVoiceOver")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[CallsUnknownMethods(Count = 1)]
	private EncumberLevel GetEncumberLevel()
	{
		return default(EncumberLevel);
	}

	[CalledBy(Type = typeof(Encumber), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(PlayerManager), Member = "GetControlMode")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(PlayerManager), Member = "GetCarryCapacityKGBuff")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 4)]
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
