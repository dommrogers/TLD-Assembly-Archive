using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WeaponPickerGridItem : MonoBehaviour
{
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
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	private void Awake()
	{
	}

	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "OnHover")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	public void RefreshEmptyItem(int index)
	{
	}

	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[CallsUnknownMethods(Count = 70)]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "OnHover")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 21)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Refresh(GearItem gi, int index)
	{
	}

	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	public void Update()
	{
	}

	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void OnClick()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	public void OnHover(bool isOver)
	{
	}

	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "OnClick")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Awake")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(Panel_Inventory), Member = "MoveSelectedSpriteAndTween")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 6)]
	public void ToggleSelection(bool toggleVal)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int GetSelectionIndex()
	{
		return default(int);
	}

	[CallerCount(Count = 0)]
	public void MarkAsContainerItem()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
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

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[CallerCount(Count = 0)]
	public void DoubleClick()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateConditionDisplay()
	{
	}

	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void DisableButton()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WeaponPickerGridItem()
	{
	}
}
