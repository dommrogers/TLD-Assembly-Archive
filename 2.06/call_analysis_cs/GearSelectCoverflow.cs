using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class GearSelectCoverflow : MonoBehaviour
{
	public UITexture m_Texture;

	private BodyHarvestSettings m_BodyHarvestSettings;

	private GearItem m_GearItem;

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetEmptySlot(string textureName)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public void SetBareHands()
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void SetGearItem(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateGearItemIcon()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SetGearItemIcon(string gearPrefabName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 61)]
	private GearItem GetGearItem()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GearSelectCoverflow()
	{
	}
}
