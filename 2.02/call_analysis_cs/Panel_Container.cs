using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Services;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Panel_Container : Panel_Base
{
	[Serializable]
	public class ContainerUIConfig
	{
		public MissionUI m_MissionUIComponent;

		public ContainerUI m_ContainerUIComponent;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public ContainerUIConfig()
		{
		}
	}

	private enum ContainerMode
	{
		Standard,
		Mission
	}

	private sealed class _003CUpdateObjectiveUI_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Panel_Container _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			[DeduplicatedMethod]
			[CallerCount(Count = 29)]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public _003CUpdateObjectiveUI_003Ed__111(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
		[Calls(Type = typeof(MonoManager), Member = "GetYeldReturnFrameCount")]
		[CallsUnknownMethods(Count = 9)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoManager), Member = "get_current")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotSupportedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[DebuggerHidden]
		[CallerCount(Count = 0)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(SelectedTableEnum);
		}
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
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
			return default(int);
		}
		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
		set
		{
		}
	}

	private int m_InventoryFirstItemDisplayedIndex
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryScrollbarChange")]
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
			return default(int);
		}
		[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
		[CallsUnknownMethods(Count = 8)]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 5)]
		[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
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
		[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerScrollbarChange")]
		[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
		set
		{
		}
	}

	[Calls(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[Calls(Type = typeof(ContainerUI), Member = "Enable")]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateContainerTableItems")]
	[CallsUnknownMethods(Count = 126)]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateContainerTableItems")]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateInventoryTableItems")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ContainerUI), Member = "InstantiateInventoryTableItems")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Create")]
	[Calls(Type = typeof(ContainerUI), Member = "SetDragAndDropActions")]
	[Calls(Type = typeof(ContainerUI), Member = "SetScrollbarChangeActions")]
	[Calls(Type = typeof(ContainerUI), Member = "SetDragAndDropActions")]
	[Calls(Type = typeof(ContainerUI), Member = "SetScrollbarChangeActions")]
	[Calls(Type = typeof(ContainerUI), Member = "Initialize")]
	[Calls(Type = typeof(ContainerUI), Member = "Initialize")]
	[Calls(Type = typeof(Panel_Base), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public override void Initialize()
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[Calls(Type = typeof(InputManager), Member = "GetInventorySortPressed")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void UpdateSortNavigation()
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectLeftTablePressed")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectRightTablePressed")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(ContainerUI), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[Calls(Type = typeof(ContainerUI), Member = "UpdateScrollbarThumbSize")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(ContainerUI), Member = "HasSelectedGridItem")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Panel_Container), Member = "OnDone")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(InterfaceManager), Member = "ShouldImmediatelyExitOverlay")]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "DoSectionNavUpdate")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(InputManager), Member = "GetInventoryExaminePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Navigate")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventoryFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Panel_Inventory), Member = "Navigate")]
	[Calls(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateSortNavigation")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void UpdateAlpha()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(ButtonLegend), Member = "ConfigureButtonIconSpriteName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	private void UpdateButtonLegend()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(Inventory), Member = "GetExtraWeightKG")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Encumber), Member = "GetPlayerCarryCapacityString")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Encumber), Member = "GetEffectiveCarryCapacityKG")]
	private void RefreshWeight()
	{
	}

	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryScrollbarChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshWeight")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "GetDisplayName")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Panel_Container), Member = "HoverItem")]
	public int RefreshInventoryTable()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = "SetActive")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UIBasicSprite), Member = "set_fillAmount")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Encumber), Member = "GetCapacityString")]
	[CallsUnknownMethods(Count = 51)]
	[Calls(Type = typeof(Panel_Container), Member = "HoverItem")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "GetDisplayName")]
	[Calls(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	public int RefreshContainerTable()
	{
		return default(int);
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SelectGridItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Container), Member = "OnOpenComplete")]
	[CallerCount(Count = 13)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	public void RefreshTables()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToInventory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void RefreshMoveAllButtons()
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UIWidget), Member = "set_pivot")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 11)]
	public void HoverItem(InventoryGridItem gridItem, string displayName, bool isOver, bool isContainerItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[CallsUnknownMethods(Count = 19)]
	public void EnableAfterDelay(float delaySeconds)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public override void Enable(bool enable)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_SelectedTable")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "WeaponSwitchInProgress")]
	[Calls(Type = typeof(PlayerManager), Member = "ItemInHandsDuringInteractionStart")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(CameraEffects), Member = "DepthOfFieldTurnOn")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "ExitInterface")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "ExitInterface")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateSortLabels")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Base), Member = "Enable")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(ContainerUI), Member = "HasSelectedGridItem")]
	[Calls(Type = typeof(Panel_Container), Member = "GetDefaultButtonFilter")]
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
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool IsEnablePending()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventoryFirstItemDisplayedIndex")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	private void OnInventoryScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[Calls(Type = typeof(Mathf), Member = "RoundToInt")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(UIProgressBar), Member = "get_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnContainerScrollbarChange()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[Calls(Type = typeof(Panel_Container), Member = "DoSectionNavUpdate")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ContainerUI), Member = "HasSelectedGridItem")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnControllerScheme(bool isController)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	public void OnPopupClicked()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	public void OnFilterInventoryChange(UIButton filterButtonClicked)
	{
	}

	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateSortNavigation")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButton), Member = "set_normalSprite")]
	[Calls(Type = typeof(UIButtonColor), Member = "ResetDefaultColor")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
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
	[CallsUnknownMethods(Count = 5)]
	public void DragInventoryToContainer()
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	public void DragContainerToInventory()
	{
	}

	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToContainer")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectiveUI")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragInventoryToContainer")]
	[CallsUnknownMethods(Count = 40)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToContainer")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TorchItem), Member = "Extinguish")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(KeroseneLampItem), Member = "TurnOff")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(GearItem), Member = "GetSingleItemWeightKG")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "GetSingleItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void OnInventoryToContainer(bool cameFromDrag = false)
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CallsUnknownMethods(Count = 21)]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectiveUI")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "DoubleClick")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragContainerToInventory")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Panel_PickWater), Member = "Refresh")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "SetGearForTransferToInventory")]
	[Calls(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	public void OnContainerToInventory(bool cameFromDrag = false)
	{
	}

	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshMoveAllButtons")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Container), Member = "GetTotalWeightKG")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	public bool CanMoveAllToContainer()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectiveUI")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Inventory), Member = "RemoveGear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Inventory), Member = "DestroyGear")]
	[Calls(Type = typeof(Container), Member = "AddGear")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveItemToContainerInMoveAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Container), Member = "AddToExistingStackable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnMoveAllToContainer()
	{
	}

	[Calls(Type = typeof(GearItem), Member = "IsLitFlashlight")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "CanMoveAllToContainer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "IsLitMatch")]
	private bool CanMoveItemToContainerInMoveAll(GearItem gearItem)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshMoveAllButtons")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	public bool CanMoveAllToInventory()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectiveUI")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[Calls(Type = typeof(Container), Member = "RemoveGear")]
	[Calls(Type = typeof(PlayerManager), Member = "AddItemToPlayerInventory")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Container), Member = "CanMoveAllToInventory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	public void OnMoveAllToInventory()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectiveUI")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	private void RequestObjectiveUpdate()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RequestObjectiveUpdate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[IteratorStateMachine(/*Could not decode attribute arguments.*/)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallerCount(Count = 5)]
	private IEnumerator UpdateObjectiveUI()
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterContainerToInventory")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public void ShiftFocusToInventoryItem(GearItem gi)
	{
	}

	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CalledBy(Type = typeof(Panel_PickWater), Member = "TransferWaterInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_PickUnits), Member = "TransferGearInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public void ShiftFocusToContainerItem(GearItem gi)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "OnClick")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
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

	[CalledBy(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "Sample")]
	[Calls(Type = typeof(UITweener), Member = "get_amountPerDelta")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 7)]
	public void MoveSelectedSpriteAndTween(Vector3 pos)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private bool IgnoreWaterSupplyItem(WaterSupply ws)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(Panel_Container), Member = "FilterHasNoItemsContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateFilteredContainerList")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateFilteredInventoryList")]
	[Calls(Type = typeof(Panel_Container), Member = "IgnoreWaterSupplyItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	[Calls(Type = typeof(GearItem), Member = "PassesFilterType")]
	private bool ItemPassesFilter(GearItem pi, string filterName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonBack")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(PlayerManager), Member = "MaybeRevealPolaroidDiscoveryOnClose")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Container), Member = "ShouldEnterSectionNav")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Panel_Container), Member = "FinishDragDrop")]
	public void OnDone()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateButtonLegend")]
	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private GearItem GetCurrentlySelectedGearItem()
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ShiftFocusToInventoryItem")]
	[CallsUnknownMethods(Count = 36)]
	[CalledBy(Type = typeof(Container), Member = "OnOpenComplete")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	private void UpdateFilteredInventoryList()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "SetContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnMoveAllToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "ShiftFocusToContainerItem")]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CalledBy(Type = typeof(Container), Member = "OnOpenComplete")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentNullException")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	private void UpdateFilteredContainerList()
	{
	}

	[Calls(Type = typeof(CategoryButton), Member = "SetButtonState")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Container), Member = "GetDefaultButtonFilter")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallerCount(Count = 3)]
	private void RefreshFilterIconColors()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool FilterHasNoItemsInventory(string filterName)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshNoItemsLabel")]
	[Calls(Type = typeof(Panel_Container), Member = "ItemPassesFilter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool FilterHasNoItemsContainer(string filterName)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsContainer")]
	[Calls(Type = typeof(Panel_Container), Member = "FilterHasNoItemsInventory")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	private void RefreshNoItemsLabel()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsUnknownMethods(Count = 14)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	private void UpdateSortLabels()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 12)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Container), Member = "GetCurrentlySelectedGearItem")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Panel_Container), Member = "FinishDragDrop")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallsUnknownMethods(Count = 49)]
	private void UpdateDragDrop()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "UpdateDragDrop")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	private void FinishDragDrop()
	{
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ContainerUI), Member = "RefreshScrollBars")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void RefreshScrollBars()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CallAnalysisFailed]
	[CallerCount(Count = 2)]
	private UIButton GetDefaultButtonFilter()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsUnknownMethods(Count = 12)]
	private UIButton GetFilterButtonFromFilterType(InventoryFilterType filter)
	{
		return null;
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	private void DoSectionNavUpdate()
	{
	}

	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectRightTablePressed")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateAlpha")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "Clear")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "BeginUpdate")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[CallsUnknownMethods(Count = 29)]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "EndUpdate")]
	[Calls(Type = typeof(Panel_Container), Member = "OnDone")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(InputManager), Member = "GetContainerSelectLeftTablePressed")]
	[Calls(Type = typeof(ButtonLegendContainer), Member = "UpdateButton")]
	[Calls(Type = typeof(InputManager), Member = "ResetControllerState")]
	[Calls(Type = typeof(Utils), Member = "GetMenuMovementVertical")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(InputManager), Member = "GetEscapePressed")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(InputManager), Member = "GetContinuePressed")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	private void DoSectionNavControls()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	private bool ShouldEnterSectionNav()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	private void MoveSectionNavToButton(UIButton button)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSectionNavToButton")]
	[Calls(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshFilterIconColors")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnDone")]
	[CallsUnknownMethods(Count = 9)]
	private void EnterSectionNav()
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DoSectionNavControls")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Panel_Container), Member = "EnterSectionNav")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void DeselectAllItems()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Panel_MissionsStory), Member = "GetObjective")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private bool CanEnterContainerMissionMode()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(MissionUI), Member = "UpdateObjectives")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CalledBy(Type = typeof(_003CUpdateObjectiveUI_003Ed__111), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 3)]
	private void UpdateObjectives()
	{
	}

	[Calls(Type = typeof(Panel_Container), Member = "ApplyUIConfig")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Panel_Container), Member = "UpdateObjectives")]
	[CallsUnknownMethods(Count = 5)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "ApplyStandardConfig")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerMode")]
	[Calls(Type = typeof(ContainerUI), Member = "Enable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ContainerUI), Member = "Enable")]
	private void ApplyUIConfig(ContainerUIConfig containerUI)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 28)]
	public Panel_Container()
	{
	}
}
