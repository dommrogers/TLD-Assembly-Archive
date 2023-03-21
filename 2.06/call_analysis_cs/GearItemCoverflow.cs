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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetBlendAmountOnly")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "SetupScrollList")]
	[Calls(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	public void SetGearItem(GearItem gi, string gearPrefabName, bool isSmash)
	{
	}

	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "RefreshVisuals")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_CanOpening), Member = "RefreshVisuals")]
	public void SetSelected(bool selected)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	public void SetEmptySlot(string textureName)
	{
	}

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	private void SetDamageTextures()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CalledBy(Type = typeof(GearItemCoverflow), Member = "Update")]
	[CallsUnknownMethods(Count = 1)]
	private void SetBlendAmountOnly()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public GearItemCoverflow()
	{
	}
}
