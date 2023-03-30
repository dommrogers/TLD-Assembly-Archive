using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Services;
using TLD.Gear;
using TLD.Missions;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Container : Panel_AutoReferenced
{
	[Serializable]
	public class ContainerUIConfig
	{
		public MissionUI m_MissionUIComponent;

		public ContainerUI m_ContainerUIComponent;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public ContainerUIConfig()
		{
		}
	}

	private enum ContainerMode
	{
		Standard,
		Mission
	}

	private sealed class _003CUpdateObjectiveUI_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Panel_Container _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 32)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CUpdateObjectiveUI_003Ed__114(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoManager), Member = "get_current")]
		[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
		[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
		[CallsUnknownMethods(Count = 1)]
		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 4)]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public ContainerUIConfig m_StandardConfig;

	public ContainerUIConfig m_MissionConfig;

	public ButtonLegendContainer m_ButtonLegendContainer;

	public UILabel m_Label_CarryCapacity;

	public UISprite m_CapacityBarSprite;

	public UISprite m_CapacityBarOutline;

	public UILabel m_Label_ContainerCapacity;

	public UIButton m_DefaultFilterButton;

	public UIButton m_DefaultSortButton;

	public UIButton[] m_SortButtons;

	public UIButton[] m_FilterButtons;

	public UILabel m_CategoryLabel;

	public ItemDescriptionPage m_ItemDescriptionPage;

	public UILabel m_NameplateLabel;

	public float m_AlphaUnselectedSide;

	public UISprite m_FilterLeftGamepadButtonSprite;

	public UISprite m_FilterRightGamepadButtonSprite;

	public bool m_EnablePauseMenuOnExit;

	public Container m_Container;

	public List<GearItem> m_FilteredInventoryList;

	public List<GearItem> m_FilteredContainerList;

	public GameObject m_SortLabel;

	public GameObject m_SortButtonsObject;

	public GameObject m_SelectedSpriteObj;

	public TweenScale m_SelectedSpriteTweenScale;

	public UIButton[] m_MoveAllToContainerButtons;

	public UIButton[] m_MoveAllToInventoryButtons;

	private PanelReference<Panel_Inventory> m_Inventory;

	private PanelReference<Panel_PickUnits> m_PickUnits;

	private PanelReference<Panel_PickWater> m_PickWater;

	private List<CategoryButton> m_CategoryButtons;

	private UIButton m_SelectedFilterButton;

	private UIButton m_SelectedSortButton;

	private string m_SelectedSortOldSprite;

	private Dictionary<string, bool> m_SortFlipDictionary;

	private ContainerMode m_ContainerMode;

	private string m_ContainerDisplayName;

	private SelectedTableEnum m_SelectedTableVal;

	private string m_InventoryFilterName;

	private string m_InventorySortName;

	private int m_SelectedSortIndex;

	private MissionUI m_MissionUIComponent;

	private ContainerUI m_ContainerUIComponent;

	private int m_InventorySelectedItemIndexVal;

	private int m_InventoryNumItemsDisplayed;

	private int m_InventoryFirstItemDisplayedIndexVal;

	private int m_ContainerSelectedItemIndexVal;

	private int m_ContainerNumItemsDisplayed;

	private int m_ContainerFirstItemDisplayedIndexVal;

	private bool m_EnablePending;

	private float m_EnableDelaySeconds;

	private float m_EnableDelayElapsed;

	private bool m_ShouldResetSelectedItem;

	private int m_NumFramesPanelActive;

	private bool m_ForceRefreshRequested;

	private DragDropItem m_DraggedItem;

	public Transform m_SectionNavSelectedSprite;

	public GameObject m_SectionNavArrowPrompts;

	private int m_SectionNavIndex;

	private bool m_IsInSectionNav;

	private StoryMissionObjective m_ObjectiveToShow;

	private bool m_UpdateObjectiveUI;

	private SelectedTableEnum m_SelectedTable
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(SelectedTableEnum);
		}
		[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private int m_InventorySelectedItemIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	private int m_InventoryFirstItemDisplayedIndex
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryScrollbarChange")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	private int m_ContainerSelectedItemIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CallsUnknownMethods(Count = 2)]
		set
		{
		}
	}

	private int m_ContainerFirstItemDisplayedIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0;
		}
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerScrollbarChange")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ContainerUI), Member = "Initialize")]
	[Calls(Type = typeof(ContainerUI), Member = "SetScrollbarChangeActions")]
	[Calls(Type = typeof(ContainerUI), Member = "SetDragAndDropActions")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateInventoryTableItems")]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateContainerTableItems")]
	[Calls(Type = typeof(ContainerUI), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 4)]
	public override void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void UpdateSortNavigation()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "DoSectionNavUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Navigate")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectLeftTablePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectRightTablePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[Calls(Type = typeof(ContainerUI), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(ContainerUI), Member = "HasSelectedGridItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateAlpha()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshWeight()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "GetDisplayName")]
	[Calls(Type = typeof(Panel_Container), Member = "HoverItem")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	public int RefreshInventoryTable()
	{
		return 0;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "GetDisplayName")]
	[Calls(Type = typeof(Panel_Container), Member = "HoverItem")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Encumber), Member = "GetCapacityString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CallsUnknownMethods(Count = 4)]
	public int RefreshContainerTable()
	{
		return 0;
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventoryFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToInventory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void RefreshTables()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshMoveAllButtons()
	{
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	public void HoverItem(InventoryGridItem gridItem, string displayName, bool isOver, bool isContainerItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 11)]
	public void EnableAfterDelay(float delaySeconds)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjective")]
	[Calls(Type = typeof(Panel_Container), Member = "ApplyUIConfig")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "GetDefaultButtonFilter")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_SelectedTable")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(ContainerUI), Member = "HasSelectedGridItem")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetControllerState")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 12)]
	public void Enable(bool enable, bool resetFilter)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	public void SetContainer(Container c, string displayName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool IsEnabled()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEnablePending()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventoryFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnInventoryScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnContainerScrollbarChange()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(ContainerUI), Member = "HasSelectedGridItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "DoSectionNavUpdate")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CallsUnknownMethods(Count = 2)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPopupClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CallsUnknownMethods(Count = 1)]
	public void OnFilterInventoryChange(UIButton filterButtonClicked)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateSortNavigation")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public void OnSortInventoryChange(UIButton sortButtonClicked)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnMoveItem()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void OnMoveAllItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallsUnknownMethods(Count = 2)]
	public void DragInventoryToContainer()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CallsUnknownMethods(Count = 2)]
	public void DragContainerToInventory()
	{
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragInventoryToContainer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(PlayerManager), Member = "ClearLastUnequippedItem")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToContainer")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	public void OnInventoryToContainer(bool cameFromDrag = false)
	{
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragContainerToInventory")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToInventory")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public void OnContainerToInventory(bool cameFromDrag = false)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshMoveAllButtons")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanMoveAllToContainer()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public void OnMoveAllToContainer()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanMoveItemToContainerInMoveAll(GearItem gearItem)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshMoveAllButtons")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 2)]
	public bool CanMoveAllToInventory()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToInventory")]
	[Calls(Type = typeof(PanelReference<>), Member = "GetPanel")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void OnMoveAllToInventory()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	private void RequestObjectiveUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateObjectiveUI_003Ed__114))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator UpdateObjectiveUI()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ShiftFocusToInventoryItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public void ShiftFocusToContainerItem(GearItem gi)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SelectGridItem(InventoryGridItem gridItem, bool isInContainer)
	{
	}

	[CallerCount(Count = 0)]
	public void ForceRefresh()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetNumFramesInPanel()
	{
		return 0;
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "ToString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 1)]
	private bool IgnoreWaterSupplyItem(WaterSupply ws)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CalledBy(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "FilterHasNoItemsContainer")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "IsGearType")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Container), Member = "IgnoreWaterSupplyItem")]
	[CallsUnknownMethods(Count = 1)]
	private bool ItemPassesFilter(GearItem pi, string filterName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Container), Member = "FinishDragDrop")]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void OnDone()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private GearItem GetCurrentlySelectedGearItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateFilteredInventoryList()
	{
	}

	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void UpdateFilteredContainerList()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Container), Member = "GetDefaultButtonFilter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void RefreshFilterIconColors()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 3)]
	private bool FilterHasNoItemsInventory(string filterName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	private bool FilterHasNoItemsContainer(string filterName)
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsContainer")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void RefreshNoItemsLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateSortLabels()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Container), Member = "FinishDragDrop")]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 11)]
	private void UpdateDragDrop()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void FinishDragDrop()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshScrollBars()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CallerCount(Count = 2)]
	private UIButton GetDefaultButtonFilter()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private UIButton GetFilterButtonFromFilterType(InventoryFilterType filter)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoSectionNavUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectLeftTablePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectRightTablePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DoSectionNavControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private bool ShouldEnterSectionNav()
	{
		return false;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void MoveSectionNavToButton(UIButton button)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void EnterSectionNav()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private void DeselectAllItems()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjective")]
	[CallsUnknownMethods(Count = 2)]
	private bool CanEnterContainerMissionMode()
	{
		return false;
	}

	[CalledBy(Type = typeof(_003CUpdateObjectiveUI_003Ed__114), Member = "MoveNext")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CallsUnknownMethods(Count = 1)]
	private void UpdateObjectives()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ActiveMissionManager), Member = "GetObjective")]
	[Calls(Type = typeof(Panel_Container), Member = "ApplyUIConfig")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 2)]
	private void RefreshContainerMode()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Container), Member = "ApplyUIConfig")]
	private void ApplyStandardConfig()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void ApplyMissionConfig()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ApplyStandardConfig")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ContainerUI), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	private void ApplyUIConfig(ContainerUIConfig containerUI)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public Panel_Container()
	{
	}
}
