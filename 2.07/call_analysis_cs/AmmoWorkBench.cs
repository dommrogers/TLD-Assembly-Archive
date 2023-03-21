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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public int ModifyCraftingTime(int minutes)
	{
		return 0;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	public bool ReadyForBlueprint(BlueprintData bp)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyToCraft()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Crafting), Member = "EnableCraftingAtLocation")]
	[CallsUnknownMethods(Count = 1)]
	public void InteractWithWorkbench()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AmmoWorkBench()
	{
	}
}
