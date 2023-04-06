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
		return 0;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public bool ReadyForBlueprint(BlueprintData bp)
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Fire), Member = "GetHeatIncreaseText")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Forge), Member = "ForgeHotEnoughForUse")]
	[Calls(Type = typeof(PanelReference<>), Member = "TryGetPanel")]
	[Calls(Type = typeof(Panel_Crafting), Member = "EnableCraftingAtLocation")]
	[Calls(Type = typeof(Forge), Member = "DisplayNotHotEnoughMessage")]
	[CallsUnknownMethods(Count = 1)]
	public void PerformInteraction()
	{
	}

	[CalledBy(Type = typeof(Forge), Member = "ReadyToCraft")]
	[CalledBy(Type = typeof(Forge), Member = "PerformInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private bool ForgeHotEnoughForUse()
	{
		return false;
	}

	[CalledBy(Type = typeof(Forge), Member = "ShowError")]
	[CalledBy(Type = typeof(Forge), Member = "PerformInteraction")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Localization), Member = "Get")]
	[Calls(Type = typeof(Utils), Member = "GetTemperatureString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(HUDMessage), Member = "AddMessage")]
	[Calls(Type = typeof(GameAudioManager), Member = "PlayGUIError")]
	[CallsUnknownMethods(Count = 1)]
	private void DisplayNotHotEnoughMessage()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Forge()
	{
	}
}
