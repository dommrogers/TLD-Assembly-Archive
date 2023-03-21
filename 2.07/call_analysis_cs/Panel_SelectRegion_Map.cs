using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.Scenes;
using TLD.UI;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.ResourceManagement.AsyncOperations;

public class Panel_SelectRegion_Map : Panel_AutoReferenced
{
	private enum AnimationState
	{
		None,
		RegionSelect,
		RegionDeselect
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public RegionSpecification region;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003COnRegionsLoaded_003Eb__0(SelectRegionItem item)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public SelectRegionItem item;

		public Panel_SelectRegion_Map _003C_003E4__this;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
		[CallsUnknownMethods(Count = 1)]
		internal void _003COnSelectRegionItemInstantiated_003Eb__0()
		{
		}
	}

	public Animator m_EpisodeAnimator;

	public Transform m_ItemParent;

	public Transform m_LabelParent;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public GenericButtonMouseSpawner m_ConfirmButtonMouseSpawner;

	public GenericButtonMouseSpawner m_RandomButtonMouseSpawner;

	public GenericButtonMouseSpawner m_SwitchWorldMapButtonMouseSpawner;

	public SelectRegionItem m_RandomItem;

	public RegionSpecification m_DefaultRegion;

	public AnimationStateRef m_StartupAnimation;

	public AnimationStateRef m_RegionItemSelectAnimation;

	public AnimationStateRef m_RegionItemDeselectAnimation;

	private GameObject m_MapSmokeParent;

	private Transform m_WorldMapParent;

	private WorldMapChangedEvent m_WorldMapChangedEvent;

	private readonly List<SelectRegionItem> m_Items;

	private readonly Dictionary<RegionSpecification, AsyncOperationHandle<GameObject>> m_MapIconLabels;

	private IList<WorldMapSpecification> m_AvailableMaps;

	private readonly Dictionary<WorldMapSpecification, SelectRegionItem> m_LastHoveredRegions;

	private SelectRegionItem m_HoveredItem;

	private SelectRegionItem m_SelectedItem;

	private SelectRegionItem m_PreviousSelectedItem;

	private AnimationState m_CurrentAnimationState;

	private readonly HashSet<AsyncOperationHandle<GameObject>> m_PendingInstantiations;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[CallsUnknownMethods(Count = 3)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 26)]
	private void OnRegionsLoaded(AsyncOperationHandle<IList<RegionSpecification>> loadOperation)
	{
	}

	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "set_name")]
	private void OnSelectRegionItemInstantiated(AsyncOperationHandle<GameObject> selectRegionItemOperation)
	{
	}

	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	public void OnItemSelected(SelectRegionItem item)
	{
	}

	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "GetNextAvailableWorldMap")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void OnSwitchMapsSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	public void OnRandomSelected()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void OnClickBack()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void OnSelectRegionContinue()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnRandomSelected")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass27_0), Member = "<OnSelectRegionItemInstantiated>b__0")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnItemSelected")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	private void SelectItem(SelectRegionItem item, bool showMapSmoke)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[CallsUnknownMethods(Count = 5)]
	private SelectRegionItem GetHoveredItem()
	{
		return null;
	}

	[Calls(Type = typeof(InputManager), Member = "GetDeletePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionContinue")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[CallerCount(Count = 1)]
	private void UpdateControls()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	private void NavigateToItem(SelectRegionItem item)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	private void UpdateHoveredItem()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "get_IsCoreRegionMapSelected")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	private bool IsAnyAnimationInProgress()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	private void UpdateAnimation()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	private void PlayAnimation(SelectRegionItem region, AnimationState animation)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "IsValidStartingRegion")]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	private void UpdateDisplayedRegions()
	{
	}

	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private UIWorldMap GetWorldMap(WorldMapSpecification worldMap)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Panel_SelectRegion_Map()
	{
	}
}
