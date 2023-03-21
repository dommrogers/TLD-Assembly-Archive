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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyForBlueprint(BlueprintData bp)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Forge), Member = "ForgeHotEnoughForUse")]
	[CallerCount(Count = 0)]
	public bool ReadyToCraft()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	[CallerCount(Count = 0)]
	public void ShowError(CraftingLocationError error)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Calls(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Panel_Crafting), Member = "EnableCraftingAtLocation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Forge), Member = "ForgeHotEnoughForUse")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Forge), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(Forge), Member = "ShowError")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[CallerCount(Count = 2)]
	private void DisplayNotHotEnoughMessage()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Forge()
	{
	}
}
