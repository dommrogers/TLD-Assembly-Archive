using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_SelectRegion_Map : Panel_Base
{
	private enum AnimationState
	{
		None,
		RegionSelect,
		RegionDeselect
	}

	public Animator m_EpisodeAnimator;

	public List<SelectRegionItem> m_Items;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GenericButtonMouseSpawner m_ConfirmButtonMouseSpawner;

	public GenericButtonMouseSpawner m_RandomButtonMouseSpawner;

	public SelectRegionItem m_RandomItem;

	public SelectRegionItem m_LastHoveredRegionItem;

	public AnimationStateRef m_StartupAnimation;

	public MapIcon m_BlackrockRegionIcon;

	public SelectRegionItem m_BlackrockRegionItem;

	private SelectRegionItem m_HoveredItem;

	private SelectRegionItem m_SelectedItem;

	private SelectRegionItem m_PreviousSelectedItem;

	private AnimationState m_CurrentAnimationState;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "ResetItem")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 16)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private void ResetItem(SelectRegionItem item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	public void OnItemSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnRandomSelected()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	public void OnClickBack()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSelectRegionContinue()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnItemSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SelectItem(SelectRegionItem item)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnItemSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private SelectRegionItem GetHoveredItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionContinue")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void UpdateControls()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void NavigateToItem(SelectRegionItem item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateHoveredItem()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsPlayingAnimation")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private bool IsAnyAnimationInProgress()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool IsPlayingAnimation(int stateHash)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAnimation()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private void PlayAnimation(SelectRegionItem region, AnimationState animation)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private void UpdateDisplayedRegions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public Panel_SelectRegion_Map()
	{
	}
}
