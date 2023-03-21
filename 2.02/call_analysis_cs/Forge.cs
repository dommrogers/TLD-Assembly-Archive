using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class Forge : MonoBehaviour, CraftingLocationInterface
{
	public LocalizedString m_LocalizedDisplayName;

	public float m_MinTemperatureForCrafting;

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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyForBlueprint(BlueprintItem bpi)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Forge), Member = "ForgeHotEnoughForUse")]
	public bool ReadyToCraft()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Forge), Member = "ForgeHotEnoughForUse")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetCraftingLocation")]
	[Calls(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	[CallsUnknownMethods(Count = 2)]
	public bool ProcessInteraction()
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Forge), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Forge), Member = "ReadyToCraft")]
	public bool ForgeHotEnoughForUse()
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CalledBy(Type = typeof(Forge), Member = "ShowError")]
	[CalledBy(Type = typeof(Forge), Member = "ProcessInteraction")]
	[CallsUnknownMethods(Count = 1)]
	public void DisplayNotHotEnoughMessage()
	{
	}

	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string GetForgeTemperatureRequirement()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public Forge()
	{
	}
}
