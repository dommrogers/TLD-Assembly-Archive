using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GearItemCoverflow : MonoBehaviour
{
	public UILabel m_UseLabel;

	public UILabel m_Label;

	public UITexture m_Texture;

	public UITexture m_TextureWithDamage;

	public Material m_MaterialSource;

	public bool m_ShowUseLabel;

	public string m_ItemName;

	private GearItem m_GearItem;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 8)]
	private void Awake()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetBlendAmountOnly")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "SetupScrollList")]
	[Calls(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void SetGearItem(GearItem gi, string gearPrefabName, bool isSmash)
	{
	}

	[CalledBy(Type = typeof(Panel_TorchLight), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "RefreshVisuals")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	public void SetEmptySlot(string textureName)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Utils), Member = "GetClothingUnfoldedTexture")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(Utils), Member = "GetClothingUnfoldedTexture")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	private void SetDamageTextures()
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(GearItem), Member = "GetDamageBlendValue")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "Update")]
	private void SetBlendAmountOnly()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public GearItemCoverflow()
	{
	}
}
