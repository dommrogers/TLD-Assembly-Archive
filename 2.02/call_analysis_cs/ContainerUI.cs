using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ContainerUI : MonoBehaviour
{
	public UILabel m_ContainerTitle;

	public GameObject m_ContainerTableObject;

	public UISprite m_ContainerCapacityBarSprite;

	public UISprite m_ContainerCapacityBarOutline;

	public GameObject m_ContainerScrollbarObject;

	public GameObject[] m_DragDropContainers;

	public int m_MaxItemsDisplayAtOnceContainer;

	public int m_TableConNumColumns;

	public float m_TableConSpacingHorizontal;

	public float m_TableConSpacingVertical;

	public GameObject m_ContainerGridBackground;

	public UIWidget m_ContainerSideWidget;

	public UILabel m_LabelNoItemsContainer;

	public GameObject m_InventoryTableObject;

	public GameObject m_InventoryScrollbarObject;

	public UIWidget m_InventorySideWidget;

	public int m_MaxItemsDisplayAtOnceInventory;

	public GameObject m_InventoryGridBackground;

	public int m_TableInvNumColumns;

	public float m_TableInvSpacingHorizontal;

	public float m_TableInvSpacingVertical;

	public UILabel m_LabelNoItemsInventory;

	public GameObject m_ButtonMoveItem;

	public UISprite m_ArrowButtonSprite;

	public GameObject InventoryItemPrefab;

	[NonSerialized]
	public InventoryGridItem[] m_ContainerTableItems;

	[NonSerialized]
	public InventoryGridItem[] m_InventoryTableItems;

	[NonSerialized]
	public UISlider m_InventoryScrollbarSlider;

	[NonSerialized]
	public UISlider m_ContainerScrollbarSlider;

	private Action m_OnScrollbarInventoryChanged;

	private Action m_OnScrollbarContainerChanged;

	private Action m_OnMoveItemAction;

	private Action m_OnDragInventoryToContainer;

	private Action m_OnDragContainerToInventory;

	private ScrollbarThumbResizer m_InventoryScrollbarThumbResizer;

	private ScrollbarThumbResizer m_ContainerScrollbarThumbResizer;

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[Calls(Type = typeof(Utils), Member = "GetSliderForScrollbar")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	public void Initialize()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "ApplyUIConfig")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Container), Member = "ApplyUIConfig")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	public void Enable(bool enable)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	public void SetScrollbarChangeActions(Action onScrollbarInventoryChanged, Action onScrollbarContainerChanged)
	{
	}

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	public void SetDragAndDropActions(Action onDragInventoryToContainer, Action onDragContainerToInventory)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetMoveItemAction(Action onMoveAction)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnDragInventoryToContainer()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnDragContainerToInventory()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CallsUnknownMethods(Count = 10)]
	public void InstantiateContainerTableItems()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[Calls(Type = typeof(GameObject), Member = "get_transform")]
	[Calls(Type = typeof(NGUITools), Member = "AddChild")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void InstantiateInventoryTableItems()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScrollbarInventoryChange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnScrollbarContainerChange()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnMoveItem()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	public void UpdateScrollbarThumbSize(List<GearItem> filteredInventoryList, List<GearItem> filteredContainerList)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshScrollBars")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnFilterInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "set_m_ContainerFirstItemDisplayedIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "set_m_InventoryFirstItemDisplayedIndex")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[Calls(Type = typeof(UIProgressBar), Member = "set_value")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 11)]
	public void RefreshScrollBars(int inventoryFirstItemDisplayedIndexVal, int containerFirstItemDisplayedIndexVal, List<GearItem> filteredInventoryList, List<GearItem> filteredContainerList)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetTableSelected(SelectedTableEnum selectedTable)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	public void SetInventoryItemSelectedIndex(int inventorySelectedItemIndexVal, SelectedTableEnum selectedTable, int newIndex)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[CallsUnknownMethods(Count = 5)]
	public void SetContainerItemSelectedIndex(int containerSelectedItemIndexVal, SelectedTableEnum selectedTable, int newIndex)
	{
	}

	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Panel_Container), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Enable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnControllerScheme")]
	[CallsUnknownMethods(Count = 5)]
	public bool HasSelectedGridItem()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ContainerUI()
	{
	}
}
