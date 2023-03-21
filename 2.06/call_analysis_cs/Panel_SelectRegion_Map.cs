using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.AddressableAssets;
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
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003COnRegionsLoaded_003Eb__0(SelectRegionItem item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public SelectRegionItem item;

		public Panel_SelectRegion_Map _003C_003E4__this;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
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
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(AssetHelper), Member = "SafeLoadAssetsAsync")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(List<>), Member = "Find")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Action<>), Member = ".ctor")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "add_Completed")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 39)]
	private void OnRegionsLoaded(AsyncOperationHandle<IList<RegionSpecification>> loadOperation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Status")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(HashSet<>), Member = "Remove")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(EventDelegate), Member = "Add")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PatchUpReference")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 41)]
	private void OnSelectRegionItemInstantiated(AsyncOperationHandle<GameObject> selectRegionItemOperation)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "UpdateAvailableWorldMaps")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateButtonLegend")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void Enable(bool enable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	public void OnItemSelected(SelectRegionItem item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "GetNextAvailableWorldMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[CallsUnknownMethods(Count = 1)]
	public void OnSwitchMapsSelected()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	public void OnRandomSelected()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_SelectWorldMap), Member = "ShouldBePartOfFlow")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	public void OnClickBack()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "TrySetPanelEnabled")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGuiConfirm")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnSelectRegionContinue()
	{
	}

	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass27_0), Member = "<OnSelectRegionItemInstantiated>b__0")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnItemSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnRandomSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void SelectItem(SelectRegionItem item, bool showMapSmoke)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
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
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "SelectItem")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementHorizontal")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[Calls(Type = typeof(InputManager), Member = "GetRenamePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetDeletePressed")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "GetNextAvailableWorldMap")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(WorldMapChangedEvent), Member = "SetCurrentMap")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnSelectRegionContinue")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateControls()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnClickBack")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateHoveredItem")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateDisplayedRegions")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameObject), Member = "BroadcastMessage")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	private void NavigateToItem(SelectRegionItem item)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "GetHoveredItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	private void UpdateHoveredItem()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsAnimationStatePlaying")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	private bool IsAnyAnimationInProgress()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "IsAnyAnimationInProgress")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "PlayAnimation")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateAnimation()
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateAnimation")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SelectRegionItem), Member = "PlayAnimation")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsUnknownMethods(Count = 1)]
	private void PlayAnimation(SelectRegionItem region, AnimationState animation)
	{
	}

	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "OnSwitchMapsSelected")]
	[CalledBy(Type = typeof(Panel_SelectRegion_Map), Member = "UpdateControls")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RegionSpecification), Member = "IsUnlocked")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(SandboxBaseConfig), Member = "IsValidStartingRegion")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_IsDone")]
	[Calls(Type = typeof(AsyncOperationHandle<>), Member = "get_Result")]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[Calls(Type = typeof(Panel_SelectRegion_Map), Member = "NavigateToItem")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 40)]
	private void UpdateDisplayedRegions()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WorldMapSpecification), Member = "GetOrInstantiateBaseMap")]
	[CallsUnknownMethods(Count = 1)]
	private UIWorldMap GetWorldMap(WorldMapSpecification worldMap)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 42)]
	public Panel_SelectRegion_Map()
	{
	}
}
