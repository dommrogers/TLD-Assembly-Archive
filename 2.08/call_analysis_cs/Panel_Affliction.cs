using System;
using System.Collections.Generic;
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
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Panel_Affliction), Member = "EnableInventoryRightSide")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RestorePanel")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "SetupScrollList")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshVisuals")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MovePanel")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 3)]
	public void Enable(bool enable, List<Affliction> listAffliction, FirstAidItem firstAidItem)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
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
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PreviousAffliction()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void NextAffliction()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateGamepadSelection")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerManager), Member = "TreatAfflictionWithFirstAid")]
	[Calls(Type = typeof(Panel_Affliction), Member = "Enable")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public void TreatWound()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	public static void GetAllAfflictions(ref List<Affliction> list)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "UseInventoryItem")]
	[CalledBy(Type = typeof(PlayerManager), Member = "UseFirstAidItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[Calls(Type = typeof(Affliction), Member = "IsBeneficial")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	public static void GetAllBadAfflictions(AfflictionExclusions exclusions, ref List<Affliction> badAfflictions)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	public static AfflictionBodyArea GetAfflictionLocation(AfflictionType type, int localAfflictionIndex)
	{
		return default(AfflictionBodyArea);
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CallerCount(Count = 6)]
	public static bool HasAffliction(AfflictionType afflictionType)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllAfflictions")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshPaperDoll")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshScrollList")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasBadAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "HasRiskAffliction")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "AfflictionListHasChanged")]
	[CalledBy(Type = typeof(PlayerManager), Member = "EatingComplete_Internal")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RefreshtListOfShownAfflictionTypes")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetAfflictionsCount")]
	[Calls(Type = typeof(Panel_Affliction), Member = "GetCurrentAffliction")]
	[Calls(Type = typeof(Panel_Affliction), Member = "MaybeAddOrFilter")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CallsUnknownMethods(Count = 7)]
	public static void GetAfflictions(FirstAidItem firstAidItem, ref List<Affliction> list)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAllBadAfflictions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresBandage")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntiseptic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresAntibiotic")]
	[Calls(Type = typeof(Panel_Affliction), Member = "RequiresPainKiller")]
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

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private bool TryGetSelectedAffliction(out Affliction affliction)
	{
		affliction = default(Affliction);
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 9)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateCoverFlowColor(int index, bool isSelected)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Affliction), Member = "LocalizedNameFromAfflictionType")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AfflictionButton), Member = "GetColorBasedOnAffliction")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateSelectedAffliction(Affliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Affliction), Member = "UpdateSelectedAffliction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSelectedAffliction(int selectedAfflictionIndex)
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 2)]
	private void RefreshVisuals()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void EnableInventoryRightSide(bool enabled)
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetEmptySlot")]
	[Calls(Type = typeof(AfflictionCoverflow), Member = "SetAffliction")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void SetupScrollList(List<Affliction> afflictionList)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(ItemDescriptionPage), Member = "GetEquipButtonLocalizationId")]
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
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void InitializeColorReferences()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallsUnknownMethods(Count = 2)]
	private static void MaybeAddOrFilter(FirstAidItem firstAidItem, List<Affliction> list, Affliction affliction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private static string LocalizedNameFromAfflictionLocation(AfflictionBodyArea afflictionBodyArea)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresBandage")]
	[CallsUnknownMethods(Count = 7)]
	private static bool RequiresBandage(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Infection), Member = "HasTakenAntibiotics")]
	[CallsUnknownMethods(Count = 5)]
	private static bool RequiresAntibiotic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InfectionRisk), Member = "RequiresAntiseptic")]
	[CallsUnknownMethods(Count = 2)]
	private static bool RequiresAntiseptic(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreated")]
	[CalledBy(Type = typeof(Panel_Affliction), Member = "CanBeTreatedWith")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BrokenRib), Member = "RequiresPainKiller")]
	[CallsUnknownMethods(Count = 5)]
	private static bool RequiresPainKiller(AfflictionType afflictionType, AfflictionBodyArea area, int localIndex)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "GetAfflictions")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Affliction), Member = "HasAffliction")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private static void RefreshtListOfShownAfflictionTypes()
	{
	}

	[CalledBy(Type = typeof(Panel_Affliction), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Affliction), Member = "TreatWound")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
	[Calls(Type = typeof(PlayerManager), Member = "FreezingBuffActive")]
	[Calls(Type = typeof(Frostbite), Member = "GetFrostbiteRiskValue")]
	[Calls(Type = typeof(BrokenRib), Member = "GetLocation")]
	[Calls(Type = typeof(Sprains), Member = "GetSprainRiskAfflictionReason")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostActive")]
	[Calls(Type = typeof(EnergyBoost), Member = "GetEnergyBoostTimeRemainingHours")]
	[Calls(Type = typeof(Headache), Member = "GetCause")]
	[Calls(Type = typeof(SprainPain), Member = "GetCauseLocId")]
	[Calls(Type = typeof(SprainPain), Member = "GetLocation")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(DamageProtection), Member = "GetAfflictionGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(InsomniaManager), Member = "GetInsomniaCause")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 42)]
	private static Affliction GetCurrentAffliction(AfflictionType type, int localAfflictionIndex)
	{
		return default(Affliction);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public Panel_Affliction()
	{
	}
}
