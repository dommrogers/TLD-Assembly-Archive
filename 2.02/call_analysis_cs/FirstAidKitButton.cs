using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FirstAidKitButton : MonoBehaviour
{
	public string m_ClickAudio;

	public GearItem m_GearItem;

	public UILabel m_LabelAmount;

	public Color m_GlowColorHasItem;

	public Color m_GlowColorNotHaveItem;

	public Color m_SpriteColorHasItem;

	public Color m_SpriteColorNotHaveItem;

	public FirstAidKitButton[] m_ShareHasItemStatusButtons;

	public bool m_IsWater;

	public UISprite m_GlowSprite;

	public UITexture m_ItemTexture;

	private bool m_Enabled;

	[CalledBy(Type = typeof(FirstAidKitButton), Member = "SetSelected")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectPrevFAKItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNextFAKItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshKit")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectPrevFAKItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshKit")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Inventory), Member = "NumGearInInventory")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 33)]
	public void Refresh()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FirstAidKitButton), Member = "Refresh")]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshRightPage")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SetItemsNeeded")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void SetNeeded(bool needed)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool IsEnabled()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public FirstAidKitButton()
	{
	}
}
