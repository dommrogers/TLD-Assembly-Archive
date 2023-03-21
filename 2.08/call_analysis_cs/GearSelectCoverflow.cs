using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class GearSelectCoverflow : MonoBehaviour
{
	public UITexture m_Texture;

	private BodyHarvestSettings m_BodyHarvestSettings;

	private GearItem m_GearItem;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallerCount(Count = 1)]
	public void SetEmptySlot(string textureName)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 3)]
	public void SetBareHands()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void SetGearItem(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateGearItemIcon()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void SetGearItemIcon(string gearPrefabName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 25)]
	private GearItem GetGearItem()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GearSelectCoverflow()
	{
	}
}
