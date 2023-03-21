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
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetBlendAmountOnly")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_Inventory), Member = "UpdateGearStatsBlock")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "SetupScrollList")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(GearItemCoverflow), Member = "SetDamageTextures")]
	[Calls(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 8)]
	public void SetGearItem(GearItem gi, string gearPrefabName, bool isSmash)
	{
	}

	[CalledBy(Type = typeof(Panel_CanOpening), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_IceFishingHoleClear), Member = "RefreshVisuals")]
	[CalledBy(Type = typeof(Panel_TorchLight), Member = "RefreshVisuals")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetSelected(bool selected)
	{
	}

	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void SetEmptySlot(string textureName)
	{
	}

	[CalledBy(Type = typeof(GearItemCoverflow), Member = "SetGearItem")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetGearCoverflowTexture")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[Calls(Type = typeof(Utils), Member = "GetAddressableTexture")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private void SetDamageTextures()
	{
	}

	[CalledBy(Type = typeof(GearItemCoverflow), Member = "Update")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "GetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void SetBlendAmountOnly()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GearItemCoverflow()
	{
	}
}
