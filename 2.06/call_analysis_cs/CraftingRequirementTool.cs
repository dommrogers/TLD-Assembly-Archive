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
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
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

	[Calls(Type = typeof(GearItemObjectExtensions), Member = "GetBestGearItemWithName")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Disable")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(GearItem), Member = "get_DisplayName")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(BlueprintData), Member = "GetToolsAvailableToCraft")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	public void Enable(Panel_Crafting panel, BlueprintData bp)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 15)]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 55)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public CraftingRequirementTool()
	{
	}
}
