using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;

public class WorkBench : MonoBehaviour, CraftingLocationInterface
{
	public float m_CraftingAndRepairSkillModifier;

	public float m_CraftingAndRepairTimeModifier;

	public PanelReference<Panel_Crafting> m_CraftingPanel;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public int ModifyCraftingTime(int minutes)
	{
		return default(int);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyForBlueprint(BlueprintData _)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyToCraft()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public void ShowError(CraftingLocationError error)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "EnableCraftingAtLocation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void InteractWithWorkbench()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WorkBench()
	{
	}
}
