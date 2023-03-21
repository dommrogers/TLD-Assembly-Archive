using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.SaveState;
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
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectPrevFAKItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "SelectNextFAKItem")]
	[CalledBy(Type = typeof(Panel_Diagnosis), Member = "RefreshKit")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "FirstAidItemCallback")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshAll")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectPrevFAKItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "SelectNextFAKItem")]
	[CalledBy(Type = typeof(Panel_FirstAid), Member = "RefreshKit")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Inventory), Member = "GearInInventory")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "NumGearInList")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(BaseStateSingleton<>), Member = "get_Instance")]
	[Calls(Type = typeof(PlayerManager), Member = "GetTotalLiters")]
	[Calls(Type = typeof(Utils), Member = "GetLiquidQuantityStringWithUnitsNoOunces")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Inventory), Member = "GetPotableWaterSupply")]
	[CallsUnknownMethods(Count = 7)]
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
	[CallsDeduplicatedMethods(Count = 1)]
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
	public FirstAidKitButton()
	{
	}
}
