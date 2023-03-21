using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AmmoWorkBench : MonoBehaviour, CraftingLocationInterface
{
	public LocalizedString m_LocalizedDisplayName;

	public Fire m_Fire;

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
		return default(int);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	public bool ReadyForBlueprint(BlueprintItem bpi)
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string GetHoverText()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetCraftingLocation")]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AmmoWorkBench()
	{
	}
}
