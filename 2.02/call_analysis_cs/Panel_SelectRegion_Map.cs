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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "ResetItem")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Animator), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[CallsUnknownMethods(Count = 10)]
	private void ResetItem(SelectRegionItem item)
	{
	}

	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	[CallerCount(Count = 0)]
	public void OnItemSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnRandomSelected()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallsUnknownMethods(Count = 8)]
	public void OnClickBack()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void OnSelectRegionContinue()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnItemSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallsUnknownMethods(Count = 3)]
	private void SelectItem(SelectRegionItem item)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnItemSelected")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	private SelectRegionItem GetHoveredItem()
	{
		return null;
	}

	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionContinue")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	private void UpdateControls()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private void NavigateToItem(SelectRegionItem item)
	{
	}

	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UpdateHoveredItem()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void UpdateButtonLegend()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsPlayingAnimation")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsPlayingAnimation")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 7)]
	private bool IsAnyAnimationInProgress()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private bool IsPlayingAnimation(int stateHash)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAnimation()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	private void PlayAnimation(SelectRegionItem region, AnimationState animation)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	private void UpdateDisplayedRegions()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public Panel_SelectRegion_Map()
	{
	}
}
