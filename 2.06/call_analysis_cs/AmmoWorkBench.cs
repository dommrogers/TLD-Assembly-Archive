using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;

public class AmmoWorkBench : MonoBehaviour, CraftingLocationInterface
{
	public Fire m_Fire;

	public PanelReference<Panel_Crafting> m_CraftingPanel;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public CraftingLocation GetLocation()
	{
		return default(CraftingLocation);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int ModifyCraftingTime(int minutes)
	{
		return default(int);
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool ReadyForBlueprint(BlueprintData bp)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyToCraft()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "EnableCraftingAtLocation")]
	[CallsUnknownMethods(Count = 1)]
	public void InteractWithWorkbench()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public AmmoWorkBench()
	{
	}
}
