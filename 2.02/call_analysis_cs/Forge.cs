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
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyForBlueprint(BlueprintItem bpi)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Forge), Member = "ForgeHotEnoughForUse")]
	public bool ReadyToCraft()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	public void ShowError(CraftingLocationError error)
	{
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "GetInteractiveObjectDisplayText")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(LocalizedString), Member = "Text")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public string GetHoverText()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlayerManager), Member = "InteractiveObjectsProcessInteraction")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Forge), Member = "ForgeHotEnoughForUse")]
	[Calls(Type = typeof(Panel_Crafting), Member = "SetCraftingLocation")]
	[Calls(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public bool ProcessInteraction()
	{
		return false;
	}

	[CalledBy(Type = typeof(Forge), Member = "ReadyToCraft")]
	[CalledBy(Type = typeof(Forge), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool ForgeHotEnoughForUse()
	{
		return false;
	}

	[CalledBy(Type = typeof(Forge), Member = "ShowError")]
	[CalledBy(Type = typeof(Forge), Member = "ProcessInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DisplayNotHotEnoughMessage()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
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
