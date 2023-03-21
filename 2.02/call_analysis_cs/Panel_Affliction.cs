using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

	[Calls(Type = typeof(Panel_Affliction), Member = "InitializeColorReferences")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[Calls(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	private void Update()
	{
	}

	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 3)]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "OnCancel")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MovePanel")]
	[Calls(Type = typeof(Panel_Affliction), Member = "EnableInventoryRightSide")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RestorePanel")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[Calls(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Affliction), Member = "EnableInventoryRightSide")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RestorePanel")]
	public void Enable(bool enable, List<Affliction> listAffliction, FirstAidItem firstAidItem)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	public void OnCancel()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void SelectItemByIndex(int index)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsUnknownMethods(Count = 3)]
	public void PreviousAffliction()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void NextAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "TryGetSelectedAffliction")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsUnknownMethods(Count = 2)]
	public void TreatWound()
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "AfflictionListHasChanged")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	public static void GetAllAfflictions(ref List<Affliction> list)
	{
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 19)]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	public static AfflictionBodyArea GetAfflictionLocation(AfflictionType type, int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[Calls(Type = typeof(Headache), Member = "GetHeadacheActive")]
	[Calls(Type = typeof(SprainPain), Member = "HasSprainPain")]
	[Calls(Type = typeof(DamageProtection), Member = "HasDamageProtection")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[CallsUnknownMethods(Count = 72)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[Calls(Type = typeof(Sprains), Member = "HasSprainsRiskAffliction")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskAfflictionCount")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteAfflictionCount")]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[Calls(Type = typeof(InfectionRisk), Member = "HasInfectionRisk")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[Calls(Type = typeof(Infection), Member = "HasInfection")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BrokenRib), Member = "GetBrokenRibCount")]
	public static bool HasAffliction(AfflictionType afflictionType)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionsCount")]
	[CallerCount(Count = 2)]
	public static void GetAfflictions(FirstAidItem firstAidItem, ref List<Affliction> list)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[CallerCount(Count = 1)]
	public static bool CanBeTreated(Affliction affliction)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(PlayerManager), Member = "OnFirstAidComplete")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
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

	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private bool TryGetSelectedAffliction(out Affliction affliction)
	{
		System.Runtime.CompilerServices.Unsafe.As<Affliction, @null>(ref affliction) = null;
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsUnknownMethods(Count = 16)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	private void UpdateCoverFlowColor(int index, bool isSelected)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	private void UpdateSelectedAffliction(Affliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectedAffliction(int selectedAfflictionIndex)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(GenericButtonMouseSpawner), Member = "SetLocID")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateCoverFlowColor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void RefreshVisuals()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void EnableInventoryRightSide(bool enabled)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetAffliction")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private void SetupScrollList(List<Affliction> afflictionList)
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateTreatWoundsLocalizationId()
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Initialize")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	private void InitializeColorReferences()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	private static void MaybeAddOrFilter(FirstAidItem firstAidItem, List<Affliction> list, Affliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 1)]
	private static string LocalizedNameFromAfflictionLocation(AfflictionBodyArea afflictionBodyArea)
	{
		return null;
	}

	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[Calls(Type = typeof(BloodLoss), Member = "HasBloodLoss")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(SprainedWrist), Member = "HasSprainedWrist")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	private static bool RequiresBandage(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallsUnknownMethods(Count = 8)]
	private static bool RequiresAntibiotic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	private static bool RequiresAntiseptic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallsUnknownMethods(Count = 9)]
	private static bool RequiresPainKiller(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	private static void RefreshtListOfShownAfflictionTypes()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Panel_Affliction), Member = "TryGetSelectedAffliction")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void UpdateGamepadSelection()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(SprainPain), Member = "GetCauseLocId")]
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictionLocation")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[CallsUnknownMethods(Count = 102)]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
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
	[Calls(Type = typeof(Affliction), Member = ".ctor")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetEmergencyStimActive")]
	[Calls(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[Calls(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[Calls(Type = typeof(EmergencyStim), Member = "GetActiveHoursRemaining")]
	[Calls(Type = typeof(BrokenRib), Member = "GetLocation")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(PlayerManager), Member = "IsPumpkinPieBuffActive")]
	[Calls(Type = typeof(SprainedAnkle), Member = "HasSprainedAnkle")]
	private static Affliction GetCurrentAffliction(AfflictionType type, int localAfflictionIndex)
	{
		return default(Affliction);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 26)]
	public Panel_Affliction()
	{
	}
}
