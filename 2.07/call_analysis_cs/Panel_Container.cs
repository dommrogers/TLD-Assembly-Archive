using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Services;
using TLD.Gear;
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

	private sealed class _003CUpdateObjectiveUI_003Ed__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Panel_Container _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 28)]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CUpdateObjectiveUI_003Ed__115(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(MonoManager), Member = "get_current")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoManager), Member = "StaggeredUpdatedEnabled")]
		private bool MoveNext()
		{
			return default(bool);
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

	private PanelReference<Panel_MissionsStory> m_MissionsStory;

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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
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
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryScrollbarChange")]
		[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
		[CallerCount(Count = 2)]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		set
		{
		}
	}

	private int m_ContainerSelectedItemIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CallerCount(Count = 7)]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		set
		{
		}
	}

	private int m_ContainerFirstItemDisplayedIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerScrollbarChange")]
		set
		{
		}
	}

	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateContainerTableItems")]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateInventoryTableItems")]
	[Calls(Type = typeof(ContainerUI), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateInventoryTableItems")]
	[Calls(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateContainerTableItems")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 18)]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[Calls(Type = typeof(ContainerUI), Member = "Initialize")]
	[Calls(Type = typeof(ContainerUI), Member = "Initialize")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ContainerUI), Member = "SetDragAndDropActions")]
	[Calls(Type = typeof(ContainerUI), Member = "SetScrollbarChangeActions")]
	[Calls(Type = typeof(ContainerUI), Member = "SetScrollbarChangeActions")]
	[Calls(Type = typeof(ContainerUI), Member = "SetDragAndDropActions")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	public override void Initialize()
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void UpdateSortNavigation()
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectLeftTablePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectRightTablePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ContainerUI), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(ContainerUI), Member = "HasSelectedGridItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(ContainerUI), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "DoSectionNavUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Navigate")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Navigate")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	private void UpdateAlpha()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	private void UpdateButtonLegend()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	[CallsDeduplicatedMethods(Count = 3)]
	private void RefreshWeight()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "GetDisplayName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Container), Member = "HoverItem")]
	public int RefreshInventoryTable()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(Panel_Container), Member = "HoverItem")]
	[Calls(Type = typeof(InventoryGridItem), Member = "GetDisplayName")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	public int RefreshContainerTable()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventoryFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	public void RefreshTables()
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void RefreshMoveAllButtons()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CallsUnknownMethods(Count = 11)]
	public void HoverItem(InventoryGridItem gridItem, string displayName, bool isOver, bool isContainerItem)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsUnknownMethods(Count = 11)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	public void EnableAfterDelay(float delaySeconds)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(ContainerUI), Member = "HasSelectedGridItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InputSystemRewired), Member = "ResetControllerState")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "GetDefaultButtonFilter")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(PostProcessManager), Member = "MarkSettingsChanged")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_SelectedTable")]
	public void Enable(bool enable, bool resetFilter)
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	public void SetContainer(Container c, string displayName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsEnablePending()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventoryFirstItemDisplayedIndex")]
	private void OnInventoryScrollbarChange()
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
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

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallerCount(Count = 0)]
	public void OnPopupClicked()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	public void OnFilterInventoryChange(UIButton filterButtonClicked)
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateSortNavigation")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
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
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallsUnknownMethods(Count = 2)]
	public void DragInventoryToContainer()
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	public void DragContainerToInventory()
	{
	}

	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragInventoryToContainer")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToContainer")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlayerManager), Member = "ClearLastUnequippedItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	public void OnInventoryToContainer(bool cameFromDrag = false)
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToInventory")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToInventory")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnContainerToInventory(bool cameFromDrag = false)
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshMoveAllButtons")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetTotalWeightKG")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	public bool CanMoveAllToContainer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	public void OnMoveAllToContainer()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[CallerCount(Count = 2)]
	private bool CanMoveItemToContainerInMoveAll(GearItem gearItem)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshMoveAllButtons")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CallsUnknownMethods(Count = 3)]
	public bool CanMoveAllToInventory()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToInventory")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnMoveAllToInventory()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	private void RequestObjectiveUpdate()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateObjectiveUI_003Ed__115))]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IEnumerator UpdateObjectiveUI()
	{
		return null;
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public void ShiftFocusToInventoryItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public void ShiftFocusToContainerItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
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
		return default(int);
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	private bool IgnoreWaterSupplyItem(WaterSupply ws)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "FilterHasNoItemsContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "IgnoreWaterSupplyItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(GearItem), Member = "IsGearType")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "IsGearType")]
	private bool ItemPassesFilter(GearItem pi, string filterName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Panel_Container), Member = "FinishDragDrop")]
	[Calls(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Container), Member = "BeginContainerClose")]
	public void OnDone()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	private GearItem GetCurrentlySelectedGearItem()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	private void UpdateFilteredInventoryList()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Container), Member = "ShowContainerContents")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	private void UpdateFilteredContainerList()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[Calls(Type = typeof(Panel_Container), Member = "GetDefaultButtonFilter")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	private void RefreshFilterIconColors()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private bool FilterHasNoItemsInventory(string filterName)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[CallsUnknownMethods(Count = 2)]
	private bool FilterHasNoItemsContainer(string filterName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsContainer")]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Contains")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	private void RefreshNoItemsLabel()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateSortLabels()
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Panel_Container), Member = "FinishDragDrop")]
	private void UpdateDragDrop()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[CallsUnknownMethods(Count = 4)]
	private void FinishDragDrop()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	private void RefreshScrollBars()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
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

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CallsUnknownMethods(Count = 2)]
	private void DoSectionNavUpdate()
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectRightTablePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectLeftTablePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Container), Member = "OnDone")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSectionNavToButton")]
	private void DoSectionNavControls()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	private bool ShouldEnterSectionNav()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	private void MoveSectionNavToButton(UIButton button)
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSectionNavToButton")]
	private void EnterSectionNav()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	private void DeselectAllItems()
	{
	}

	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool CanEnterContainerMissionMode()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CalledBy(Type = typeof(_003CUpdateObjectiveUI_003Ed__115), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	private void UpdateObjectives()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
	[Calls(Type = typeof(Panel_Container), Member = "ApplyUIConfig")]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Container), Member = "ApplyUIConfig")]
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

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ApplyStandardConfig")]
	[Calls(Type = typeof(ContainerUI), Member = "Enable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContainerUI), Member = "Enable")]
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
