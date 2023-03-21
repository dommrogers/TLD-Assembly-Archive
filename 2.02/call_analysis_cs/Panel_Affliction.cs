using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Affliction : Panel_Base
{
	public enum AfflictionExclusions
	{
		None,
		MajorWristSprain,
		MustBeTreatable
	}

	public ScrollList m_ScrollList;

	public GameObject m_ButtonLeft;

	public GameObject m_ButtonRight;

	public GameObject m_ButtonLeftGamepad;

	public UISprite m_ButtonLeftGamepadSprite;

	public GameObject m_ButtonRightGamepad;

	public UISprite m_ButtonRightGamepadSprite;

	public GenericButtonMouseSpawner m_MouseButtonTreatWounds;

	public GameObject m_Background;

	public GameObject m_PanelContent;

	public GameObject m_AfflictionButtonColorReferencesPrefab;

	public UILabel m_Label;

	public UILabel m_LabelCause;

	public UILabel m_LabelLocation;

	public GameObject m_SelectionEffect;

	public Vector2 m_PanelOffsetInInventory;

	public Vector2 m_ButtonTreatWoundsOffsetInInventory;

	private ButtonLegendContainer m_ButtonLegendContainer;

	private List<AfflictionCoverflow> m_CoverflowAfflictions;

	private List<Affliction> m_Afflictions;

	private FirstAidItem m_FirstAidItem;

	private Vector2 m_OriginalPanelPosition;

	private Vector2 m_OriginalBUttonTreatWoundsPosition;

	private string m_TreatWoundsLocalizationId;

	private AfflictionButton m_AfflictionButtonColorReferences;

	private GameObject m_AfflictionButtonColorReferencesObject;

	private static AfflictionType[] s_TypesToCheck;

	private static List<AfflictionType> s_ShownAfflictionTypes;

	private static List<Affliction> m_TmpAfflictionList;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Affliction), Member = "InitializeColorReferences")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Affliction), Member = "EnableInventoryRightSide")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RestorePanel")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MovePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	public void Enable(bool enable, List<Affliction> listAffliction, FirstAidItem firstAidItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void SelectItemByIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void PreviousAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void NextAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "TryGetSelectedAffliction")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void TreatWound()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "AfflictionListHasChanged")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void GetAllAfflictions(ref List<Affliction> list)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	public static void GetAllBadAfflictions(AfflictionExclusions exclusions, ref List<Affliction> badAfflictions)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static AfflictionBodyArea GetAfflictionLocation(AfflictionType type, int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteAfflictionCount")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskAfflictionCount")]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(Headache), Member = "GetHeadacheActive")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 72)]
	public static bool HasAffliction(AfflictionType afflictionType)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void GetAfflictions(FirstAidItem firstAidItem, ref List<Affliction> list)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool CanBeTreated(Affliction affliction)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool CanBeTreatedWith(FirstAidItem firstAidItem, Affliction affliction)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 2)]
	public static int GetAfflictionsCount(AfflictionType afflictionType)
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 2)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool TryGetSelectedAffliction(out Affliction affliction)
	{
		affliction = default(Affliction);
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 16)]
	private void MovePanel()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
	private void RestorePanel()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateCoverFlowColor(int index, bool isSelected)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateSelectedAffliction(Affliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectedAffliction(int selectedAfflictionIndex)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateCoverFlowColor")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateButtonLegend")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	private void RefreshVisuals()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void EnableInventoryRightSide(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetAffliction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void SetupScrollList(List<Affliction> afflictionList)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTreatWoundsLocalizationId()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Instantiate")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	private void InitializeColorReferences()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static void MaybeAddOrFilter(FirstAidItem firstAidItem, List<Affliction> list, Affliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static string LocalizedNameFromAfflictionLocation(AfflictionBodyArea afflictionBodyArea)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private static bool RequiresBandage(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private static bool RequiresAntibiotic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool RequiresAntiseptic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	private static bool RequiresPainKiller(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 13)]
	private static void RefreshtListOfShownAfflictionTypes()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Affliction), Member = "TryGetSelectedAffliction")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateGamepadSelection()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(Burns), Member = "GetCauseLocID")]
	[Calls(Type = typeof(Infection), Member = "GetLocation")]
	[Calls(Type = typeof(FoodPoisoning), Member = "GetCauseString")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetLocation")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetLocation")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetLocation")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(BrokenRib), Member = "GetLocation")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[Calls(Type = typeof(SprainPain), Member = "GetCauseLocId")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 102)]
	private static Affliction GetCurrentAffliction(AfflictionType type, int localAfflictionIndex)
	{
		return default(Affliction);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 26)]
	public Panel_Affliction()
	{
	}
}
