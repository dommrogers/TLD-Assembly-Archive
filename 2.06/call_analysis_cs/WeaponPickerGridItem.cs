using System;
using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using TLD.UI.Generics;
using UnityEngine;

public class WeaponPickerGridItem : MonoBehaviour
{
	private BodyHarvestSettings m_BodyHarvestSettings;

	private Panel_WeaponPicker m_WeaponPicker;

	private PanelReference<Panel_Container> m_Container;

	private PanelReference<Panel_Inventory> m_Inventory;

	public UIButton m_Button;

	public TweenScale m_TweenScale;

	public UITexture m_GearSprite;

	public UISprite m_EquippedSprite;

	public UISprite m_RuinedSprite;

	public UILabel m_LiquidLabel;

	public UILabel m_StackLabel;

	public UILabel m_NameLabel;

	public UISprite m_SelectedSprite;

	public Color m_BlueGreenColor;

	public Color m_WhiteColor;

	public GameObject m_ItemElements;

	public GameObject m_HoverEffect;

	private int m_SelectionIndex;

	private GearItem m_GearItem;

	private float m_previousItemNormalizedCondition;

	private bool m_previousItemIsWornOut;

	private bool m_IsInContainer;

	private bool m_IsInHoverState;

	private bool m_IsSelected;

	public UILabel m_UnitLabel;

	public UISprite m_UnitSprite;

	private bool m_EmptyItemEnabled;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "OnHover")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void RefreshEmptyItem(int index)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "OnHover")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 20)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	public void Refresh(GearItem gi, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[CallsUnknownMethods(Count = 1)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void OnClick()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	public void OnHover(bool isOver)
	{
	}

	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Awake")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSelectedSpriteAndTween")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Panel_Inventory), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(Transform), Member = "get_position")]
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
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
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
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[CallsUnknownMethods(Count = 1)]
	public void DoubleClick()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Update")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[CallerCount(Count = 3)]
	private void UpdateConditionDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 2)]
	private void DisableButton()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public WeaponPickerGridItem()
	{
	}
}
