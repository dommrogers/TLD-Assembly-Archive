using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CraftingRequirementTool : MonoBehaviour
{
	public UILabel m_DisplayName;

	public UITexture m_Icon;

	private Color m_DisplayNameTint;

	private Color m_IconTint;

	private GearItem m_SelectedTool;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void Awake()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CalledBy(Type = typeof(CraftingRequirementTool), Member = "Enable")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public void Disable()
	{
	}

	[CalledBy(Type = typeof(CraftingRequirementContainer), Member = "Enable")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(GearItem), Member = "get_m_DisplayName")]
	[Calls(Type = typeof(UILabel), Member = "set_text")]
	[Calls(Type = typeof(Utils), Member = "GetInventoryIconTexture")]
	[Calls(Type = typeof(NGUITools), Member = "SetActive")]
	[Calls(Type = typeof(BlueprintItem), Member = "GetToolsAvailableToCraft")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(GearItemObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(Utils), Member = "GetBestGearItemWithName")]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[Calls(Type = typeof(CraftingRequirementTool), Member = "Disable")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 29)]
	public void Enable(BlueprintItem bpi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	public GearItem GetSelectedTool()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 54)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public bool IsEnabled()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public CraftingRequirementTool()
	{
	}
}
