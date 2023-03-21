using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class GearSelectCoverflow : MonoBehaviour
{
	public UITexture m_Texture;

	private GearItem m_GearItem;

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	public void SetEmptySlot(string textureName)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTexture")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallsUnknownMethods(Count = 7)]
	public void SetBareHands()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	public void SetGearItem(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateGearItemIcon()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void SetGearItemIcon(string gearPrefabName)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	private GearItem GetGearItem()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public GearSelectCoverflow()
	{
	}
}
