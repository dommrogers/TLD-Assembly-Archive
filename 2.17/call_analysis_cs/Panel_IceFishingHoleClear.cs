using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

public class Panel_IceFishingHoleClear : Panel_AutoReferenced
{
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	public List<GameObject> m_UsableToolItems;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public ScrollList m_ScrollList;

	public GameObject m_ButtonLeft;

	public GameObject m_ButtonRight;

	public TweenAlpha m_LabelTween;

	public UILabel m_UseLabel;

	public UILabel m_ToolNameLabel;

	public float m_ProgressBarSeconds;

	private float m_BuildHoleMultiplier;

	private LocalizedString m_IndoorsErrorText;

	private LocalizedString m_NoSuitableIceErrorText;

	private LocalizedString m_NoToolsErrorText;

	private GearItem m_ToolUsed;

	private IceFishingHole m_IceFishingHole;

	private bool m_IsBuildingHole;

	private List<GearItem> m_AvailableTools;

	private List<GearItemCoverflow> m_CoverflowItems;

	private bool m_IsClearingIce;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "AddAlternateTools")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "UseTool")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "UnlinkFishingHole")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void NextTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void PrevTool()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "UpdateDurationAllTweens")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	public void SelectToolByIndex(int index)
	{
	}

	[CalledBy(Type = typeof(IceFishingHole), Member = "OnBuild")]
	[CalledBy(Type = typeof(IceFishingHole), Member = "PerformInteraction")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Launch(IceFishingHole ifh, bool isBuildingHole)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "SetupScrollList")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "RefreshVisuals")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "UseTool")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public void OnBreakIce()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "UnlinkFishingHole")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnCancel()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "UseTool")]
	[CallerCount(Count = 1)]
	public void OnBreakIceComplete(bool success, bool playerCancel, float progress)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnCancel")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void UnlinkFishingHole()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsClearingIce()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIce")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "OnBreakIceComplete")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(OnExitDelegate), Member = ".ctor")]
	[Calls(Type = typeof(Panel_GenericProgressBar), Member = "Launch")]
	[Calls(Type = typeof(GameManager), Member = "GetPlayerObject")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlaySound")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UseTool(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "Update")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetSelected")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void RefreshVisuals()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "UpdateAvailableTools")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 5)]
	private void SetupScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "CanBuildFishingHole")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateAvailableTools()
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private void AddAlternateTools()
	{
	}

	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "ShowNoIceFishingHoleMessage")]
	[CalledBy(Type = typeof(Panel_ActionsRadial), Member = "GetShouldGreyOut")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_IceFishingHoleClear), Member = "UpdateAvailableTools")]
	[Calls(Type = typeof(Weather), Member = "IsIndoorEnvironment")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(FishingHolePlacementArea), Member = "GetActivePlacementSettings")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 5)]
	public bool CanBuildFishingHole(out string fishingHoleError)
	{
		fishingHoleError = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_IceFishingHoleClear()
	{
	}
}
