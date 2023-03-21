using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using UnityEngine;

public class CraftingRequirementTool : MonoBehaviour
{
	public UILabel m_DisplayName;

	public UITexture m_Icon;

	private Color m_DisplayNameTint;

	private Color m_IconTint;

	private GearItem m_SelectedTool;

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Awake()
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[CallsUnknownMethods(Count = 1)]
	public void Disable()
	{
	}

	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Disable")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BlueprintData), Member = "GetToolsAvailableToCraft")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public void Enable(Panel_Crafting panel, BlueprintData bp)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 9)]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CraftingRequirementTool()
	{
	}
}
