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

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "OnHover")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 17)]
	public void RefreshEmptyItem(int index)
	{
	}

	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeListItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(Utils), Member = "SetActive")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ClothingItem), Member = "IsWearing")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GunItem), Member = "NumRoundsInClip")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "OnHover")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 70)]
	public void Refresh(GearItem gi, int index)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItem), Member = "GetNormalizedCondition")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "UpdateConditionDisplay")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIButtonClick")]
	[Calls(Type = typeof(Panel_WeaponPicker), Member = "SelectGridItem")]
	[Calls(Type = typeof(WeaponPickerGridItem), Member = "ToggleSelection")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void OnClick()
	{
	}

	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	public void OnHover(bool isOver)
	{
	}

	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Awake")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "OnClick")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "OnSelectedIndexChanged")]
	[CalledBy(Type = typeof(Panel_WeaponPicker), Member = "InitializeSelection")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UIButtonColor), Member = "UpdateColor")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	[Calls(Type = typeof(UITweener), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UITweener), Member = "Play")]
	[Calls(Type = typeof(Transform), Member = "get_position")]
	[Calls(Type = typeof(Panel_Container), Member = "MoveSelectedSpriteAndTween")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Panel_Inventory), Member = "MoveSelectedSpriteAndTween")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 27)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Panel_Container), Member = "OnContainerToInventory")]
	[Calls(Type = typeof(Panel_Container), Member = "OnInventoryToContainer")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Panel_Inventory), Member = "OnEquip")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public void DoubleClick()
	{
	}

	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "RefreshEmptyItem")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Refresh")]
	[CalledBy(Type = typeof(WeaponPickerGridItem), Member = "Update")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	private void UpdateConditionDisplay()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
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
