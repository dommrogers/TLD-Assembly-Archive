using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay.Condition;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Affliction : Panel_AutoReferenced
{
	public enum AfflictionExclusions
	{
		None,
		MajorWristSprain,
		MustBeTreatable
	}

	private PanelReference<Panel_Inventory> m_Inventory;

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
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Affliction), Member = "InitializeColorReferences")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 6)]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "EnableInventoryRightSide")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MovePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RestorePanel")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RestorePanel")]
	[Calls(Type = typeof(Panel_Affliction), Member = "EnableInventoryRightSide")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[Calls(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 3)]
	public void Enable(bool enable, List<Affliction> listAffliction, FirstAidItem firstAidItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	public void OnCancel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectItemByIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 2)]
	public void PreviousAffliction()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void NextAffliction()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	public void TreatWound()
	{
	}

	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 0)]
	public static void GetAllAfflictions(ref List<Affliction> list)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	public static void GetAllBadAfflictions(AfflictionExclusions exclusions, ref List<Affliction> badAfflictions)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public static AfflictionBodyArea GetAfflictionLocation(AfflictionType type, int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CallerCount(Count = 6)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	public static bool HasAffliction(AfflictionType afflictionType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "AfflictionListHasChanged")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	public static void GetAfflictions(FirstAidItem firstAidItem, ref List<Affliction> list)
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	public static bool CanBeTreated(Affliction affliction)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static bool CanBeTreatedWith(FirstAidItem firstAidItem, Affliction affliction)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	public static int GetAfflictionsCount(AfflictionType afflictionType)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private bool TryGetSelectedAffliction(out Affliction affliction)
	{
		System.Runtime.CompilerServices.Unsafe.As<Affliction, @null>(ref affliction) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsUnknownMethods(Count = 9)]
	private void MovePanel()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	private void RestorePanel()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCoverFlowColor(int index, bool isSelected)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[CallerCount(Count = 1)]
	private void UpdateSelectedAffliction(Affliction affliction)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	private void UpdateSelectedAffliction(int selectedAfflictionIndex)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	private void RefreshVisuals()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	private void EnableInventoryRightSide(bool enabled)
	{
	}

	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetEmptySlot")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	private void SetupScrollList(List<Affliction> afflictionList)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void UpdateTreatWoundsLocalizationId()
	{
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void InitializeColorReferences()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallsUnknownMethods(Count = 2)]
	private static void MaybeAddOrFilter(FirstAidItem firstAidItem, List<Affliction> list, Affliction affliction)
	{
	}

	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private static string LocalizedNameFromAfflictionLocation(AfflictionBodyArea afflictionBodyArea)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[CallerCount(Count = 2)]
	private static bool RequiresBandage(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	private static bool RequiresAntibiotic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallsUnknownMethods(Count = 2)]
	private static bool RequiresAntiseptic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	private static bool RequiresPainKiller(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	private static void RefreshtListOfShownAfflictionTypes()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[Calls(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	private void UpdateGamepadSelection()
	{
	}

	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(SprainPain), Member = "GetCauseLocId")]
	[Calls(Type = typeof(Headache), Member = "GetCause")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaCause")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaCause")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallsUnknownMethods(Count = 42)]
	[Calls(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BrokenRib), Member = "GetLocation")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BloodLoss), Member = "GetLocation")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(Burns), Member = "GetCauseLocID")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(Infection), Member = "GetLocation")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(FoodPoisoning), Member = "GetCauseString")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(SprainedAnkle), Member = "GetLocation")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(InfectionRisk), Member = "GetLocation")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(SprainedWrist), Member = "GetLocation")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(Frostbite), Member = "NumInstancesFrostbiteAtLocation")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	private static Affliction GetCurrentAffliction(AfflictionType type, int localAfflictionIndex)
	{
		return default(Affliction);
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public Panel_Affliction()
	{
	}
}
