using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.SaveState;
using TLD.UI.Generics;
using UnityEngine;

public class InventoryGridItem : MonoBehaviour
{
	private BodyHarvestSettings m_BodyHarvestSettings;

	public UIButton m_Button;

	public TweenScale m_TweenScale;

	public UITexture m_GearSprite;

	public UISprite m_EquippedSprite;

	public UISprite m_RuinedSprite;

	public UILabel m_LiquidLabel;

	public UILabel m_StackLabel;

	public UILabel m_ConditionLabel;

	public UILabel m_WeightLabel;

	public UILabel m_NameLabel;

	public UISprite m_ConditionSprite;

	public UISprite m_SelectedSprite;

	public UISprite m_FavoritedSprite;

	public Color m_BlueGreenColor;

	public Color m_WhiteColor;

	public Color m_GoodConditionSpriteColor;

	public GameObject m_ItemElements;

	public GameObject m_HoverEffect;

	public GameObject m_NotificationFlag;

	private PanelReference<Panel_Container> m_Container;

	private PanelReference<Panel_Inventory> m_Inventory;

	private int m_SelectionIndex;

	private GearItem m_GearItem;

	private float m_previousItemNormalizedCondition;

	private bool m_previousItemIsWornOut;

	private bool m_IsInContainer;

	private bool m_IsInHoverState;

	public bool m_IsSelected;

	public UILabel m_UnitLabel;

	public UISprite m_UnitSprite;

	private bool m_EmptyItemEnabled;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 7)]
	public void RefreshEmptyItem(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(PanelReference<>), Member = "IsEnabled")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 12)]
	public void Refresh(GearItem gi, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public void OnClick()
	{
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "RefreshEmptyItem")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DisableButton")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DeselectItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DeselectAllItems")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Panel_Container), Member = "HoverItem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnHover(bool isOver)
	{
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "Awake")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DeselectItem")]
	[CalledBy(Type = typeof(ContainerUI), Member = "SetInventoryItemSelectedIndex")]
	[CalledBy(Type = typeof(ContainerUI), Member = "SetContainerItemSelectedIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[CalledBy(Type = typeof(Panel_Container), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "OnSortInventoryChange")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Initialize")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "Update")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnFilterChange")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "OnSortChange")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "ScrollToBottom")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DoSectionNavControls")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DeselectAllItems")]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Panel_Inventory), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSelectedSpriteAndTween")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 8)]
	public void ToggleSelection(bool toggleVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetSelectionIndex()
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	public void MarkAsContainerItem()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsUnknownMethods(Count = 1)]
	public string GetDisplayName()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearItem GetGearItem()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void DoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsSelected()
	{
		return false;
	}

	[CalledBy(Type = typeof(InventoryGridItem), Member = "RefreshEmptyItem")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private void UpdateConditionDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void DisableButton()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InventoryGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	public void DeselectItem()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InventoryGridItem()
	{
	}
}
