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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryGridIconTextureNonNull")]
	[Calls(Type = typeof(UIWidget), Member = "set_color")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public void SetBareHands()
	{
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "SetupScrollList")]
	[CallerCount(Count = 1)]
	public void SetGearItem(GearItem gearItem)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearSelectCoverflow), Member = "SetGearItemIcon")]
	public void UpdateGearItemIcon()
	{
	}

	[CalledBy(Type = typeof(GearSelectCoverflow), Member = "UpdateGearItemIcon")]
	[CalledBy(Type = typeof(Panel_GearSelect), Member = "RefreshGearItemIcons")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTextureFromPrefabName")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetGearItemIcon(GearItem gearItem)
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
	[CallerCount(Count = 0)]
	public GearSelectCoverflow()
	{
	}
}
