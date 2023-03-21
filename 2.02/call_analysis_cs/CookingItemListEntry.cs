using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CookingItemListEntry : MonoBehaviour
{
	public UILabel m_NameLabel;

	public UISprite m_ConditionSprite;

	public UILabel m_ConditionLabel;

	public UILabel m_ItemCountLabel;

	public UITexture m_GearIconTexture;

	public UISprite m_SelectedSprite;

	private GearItem m_GearItem;

	public bool m_DisplayItemCount;

	public bool m_DisplayCondition;

	public bool m_UpdateLabels;

	public bool m_UpdateColorsOnly;

	private bool m_IsSelected;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Awake()
	{
	}

	[CalledBy(Type = typeof(CookingItemListEntry), Member = "SetGearItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CookingItemListEntry), Member = "UpdateColors")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 26)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetSelected(bool isSelected)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(CookingItemListEntry), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetGearItem(GearItem gi)
	{
	}

	[CalledBy(Type = typeof(Panel_Cooking), Member = "RefreshFoodList")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void SetGearIconTexture(string textureName)
	{
	}

	[CalledBy(Type = typeof(CookingItemListEntry), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GearItem), Member = "GetColorBasedOnCondition")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(GearItem), Member = "GetRoundedCondition")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateColors()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CookingItemListEntry()
	{
	}
}
