using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

public class Forge : MonoBehaviour, CraftingLocationInterface
{
	public float m_MinTemperatureForCrafting;

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
		return default(int);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool ReadyForBlueprint(BlueprintData bp)
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Calls(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Forge), Member = "ForgeHotEnoughForUse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Panel_Crafting), Member = "EnableCraftingAtLocation")]
	public void PerformInteraction()
	{
	}

	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Forge), Member = "ReadyToCraft")]
	[CalledBy(Type = typeof(Forge), Member = "PerformInteraction")]
	[CallsUnknownMethods(Count = 1)]
	private bool ForgeHotEnoughForUse()
	{
		return default(bool);
	}

	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Forge), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Forge), Member = "ShowError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	private void DisplayNotHotEnoughMessage()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Forge()
	{
	}
}
