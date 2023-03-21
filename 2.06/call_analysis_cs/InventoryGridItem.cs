using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
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

	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void RefreshEmptyItem(int index)
	{
	}

	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "RefreshTable")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 24)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	public void Refresh(GearItem gi, int index)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(InventoryGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public void Update()
	{
	}

	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIScroll")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "PlayPickUpClip")]
	[Calls(Type = typeof(Panel_Inventory), Member = "set_m_SelectedItemIndex")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_InventorySelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "set_m_ContainerSelectedItemIndex")]
	[Calls(Type = typeof(Panel_Container), Member = "RefreshTables")]
	[CallsUnknownMethods(Count = 1)]
	public void OnClick()
	{
	}

	[CalledBy(Type = typeof(Panel_Container), Member = "DragInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragContainerToInventory")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragInventoryToContainer")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "DeselectAllItems")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_Container), Member = "DeselectAllItems")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DeselectItem")]
	[CalledBy(Type = typeof(Panel_Container), Member = "DragContainerToInventory")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "RefreshEmptyItem")]
	[Calls(Type = typeof(Panel_Container), Member = "HoverItem")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "DisableButton")]
	public void OnHover(bool isOver)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(Panel_Inventory), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Utils), Member = "IsMouseActive")]
	[Calls(Type = typeof(Utils), Member = "IsGamepadActive")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	public void ToggleSelection(bool toggleVal)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int GetSelectionIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public void MarkAsContainerItem()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshContainerTable")]
	[CalledBy(Type = typeof(Panel_Container), Member = "RefreshInventoryTable")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
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

	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void DoubleClick()
	{
	}

	[CallerCount(Count = 0)]
	public bool IsSelected()
	{
		return default(bool);
	}

	[Calls(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "Update")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(InventoryGridItem), Member = "RefreshEmptyItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetWeightTwoDecimalPlacesWithUnitsString")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(GearItem), Member = "GetColorStringBasedOnCondition")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	private void UpdateConditionDisplay()
	{
	}

	[Calls(Type = typeof(InventoryGridItem), Member = "OnHover")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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
	[CallerCount(Count = 12)]
	public InventoryGridItem()
	{
	}
}
