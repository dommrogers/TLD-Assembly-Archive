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

	[Calls(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MovePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RestorePanel")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Affliction), Member = "EnableInventoryRightSide")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RestorePanel")]
	[Calls(Type = typeof(Panel_Affliction), Member = "EnableInventoryRightSide")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	public void Enable(bool enable, List<Affliction> listAffliction, FirstAidItem firstAidItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
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
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void NextAffliction()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[CallerCount(Count = 1)]
	public void TreatWound()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	public static void GetAllAfflictions(ref List<Affliction> list)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
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

	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetRisksCount")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[Calls(Type = typeof(Headache), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(BrokenRib), Member = "HasBrokenRib")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskAfflictionCount")]
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteAfflictionCount")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	public static bool HasAffliction(AfflictionType afflictionType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "AfflictionListHasChanged")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	public static void GetAfflictions(FirstAidItem firstAidItem, ref List<Affliction> list)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	public static bool CanBeTreated(Affliction affliction)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	public static bool CanBeTreatedWith(FirstAidItem firstAidItem, Affliction affliction)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	public static int GetAfflictionsCount(AfflictionType afflictionType)
	{
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
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

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsUnknownMethods(Count = 9)]
	private void RestorePanel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	private void UpdateCoverFlowColor(int index, bool isSelected)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void UpdateSelectedAffliction(Affliction affliction)
	{
	}

	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectedAffliction(int selectedAfflictionIndex)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateCoverFlowColor")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateButtonLegend")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void RefreshVisuals()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	private void EnableInventoryRightSide(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	private void SetupScrollList(List<Affliction> afflictionList)
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTreatWoundsLocalizationId()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Initialize")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void InitializeColorReferences()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	private static void MaybeAddOrFilter(FirstAidItem firstAidItem, List<Affliction> list, Affliction affliction)
	{
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	private static string LocalizedNameFromAfflictionLocation(AfflictionBodyArea afflictionBodyArea)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	private static bool RequiresBandage(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallsUnknownMethods(Count = 5)]
	private static bool RequiresAntibiotic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	private static bool RequiresAntiseptic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallsUnknownMethods(Count = 5)]
	private static bool RequiresPainKiller(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	private static void RefreshtListOfShownAfflictionTypes()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[Calls(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	private void UpdateGamepadSelection()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	private static Affliction GetCurrentAffliction(AfflictionType type, int localAfflictionIndex)
	{
		return default(Affliction);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public Panel_Affliction()
	{
	}
}
