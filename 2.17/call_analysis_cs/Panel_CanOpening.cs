using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_CanOpening : Panel_AutoReferenced
{
	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_TitleLabel;

	public ScrollList m_ScrollList;

	public GameObject m_ButtonLeft;

	public GameObject m_ButtonRight;

	public Vector3 m_InspectGearOffset;

	public TweenAlpha m_LabelTween;

	public UILabel m_UseLabel;

	public UILabel m_ToolNameLabel;

	public GameObject[] m_UsableTools;

	private PanelReference<Panel_FeedFire> m_FeedFire;

	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	public bool m_CameFromInventory;

	public bool m_CameFromFeedFire;

	public bool m_RestoreItemInHands;

	public CookingPotItem m_CookingPotInUse;

	public GearItem m_GearItemToOpen;

	private List<GearItem> m_AvailableTools;

	private List<GearItemCoverflow> m_CoverflowItems;

	private bool m_IsGoingToOpenItem;

	private Vector3 m_InspectLightOrigPos;

	private float m_InspectCamOrigDepth;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Panel_CanOpening), Member = "AddAlternateTools")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ScrollList), Member = "Prev")]
	[Calls(Type = typeof(ScrollList), Member = "Next")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[Calls(Type = typeof(Panel_CanOpening), Member = "RefreshVisuals")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_FeedFire), Member = "InspectPrevGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOff")]
	[Calls(Type = typeof(Camera), Member = "set_depth")]
	[Calls(Type = typeof(Panel_CanOpening), Member = "SetupScrollList")]
	[Calls(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Utils), Member = "ExitInspectForGearItem")]
	[Calls(Type = typeof(PlayerManager), Member = "EnterInspectGearMode")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void OnCancel()
	{
	}

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(GearItem), Member = "DegradeOnUse")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(PlayerManager), Member = "OpenAndUseFoodInventoryItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_CanOpening), Member = "OnSmash")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void OnOpen()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsGoingToOpenItem()
	{
		return false;
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

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "OnOpen")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Inventory), Member = "AddGear")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(PlayerManager), Member = "UseSmashableItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void OnSmash()
	{
	}

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Inventory), Member = "GetHighestConditionGearThatMatchesName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ScrollList), Member = "CleanUp")]
	[Calls(Type = typeof(ScrollList), Member = "CreateList")]
	[Calls(Type = typeof(Utils), Member = "GetComponentInChildren")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	private void SetupScrollList()
	{
	}

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Update")]
	[CallerCount(Count = 1)]
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

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsUnknownMethods(Count = 4)]
	private void AddAlternateTools()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private bool ToolCanOpenSelectedItem(CanOpeningItem ci)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_CanOpening()
	{
	}
}
