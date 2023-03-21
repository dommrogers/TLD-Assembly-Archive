using Cpp2ILInjected.CallAnalysis;
using TLD.Gameplay;
using UnityEngine;

public class GearSelectCoverflow : MonoBehaviour
{
	public UITexture m_Texture;

	private BodyHarvestSettings m_BodyHarvestSettings;

	private GearItem m_GearItem;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 1)]
	public void SetEmptySlot(string textureName)
	{
	}

	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void SetBareHands()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 1)]
	public void SetGearItem(GearItem gearItem)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void UpdateGearItemIcon()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallsUnknownMethods(Count = 1)]
	private void SetGearItemIcon(string gearPrefabName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 58)]
	private GearItem GetGearItem()
	{
		return null;
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public GearSelectCoverflow()
	{
	}
}
