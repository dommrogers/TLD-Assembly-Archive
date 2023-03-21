using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InProgressCraftItem : MonoBehaviour
{
	public class InProgressCraftItemSaveDataProxy
	{
		public float m_PercentComplete;

		public float m_Weight;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public InProgressCraftItemSaveDataProxy()
		{
		}
	}

	private float m_PercentComplete;

	private float m_Weight;

	private static InProgressCraftItemSaveDataProxy m_InProgressCraftItemSaveDataProxy;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateWeight(BlueprintItem bpi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWeight()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void IncrementProgress(float percentagePoints)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	public bool IsProgressComplete()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	public bool ProgressHasStarted()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetAdjustedCraftingTime")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	public float GetPercentRemainingNormalized()
	{
		return default(float);
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(BlueprintItem), Member = "NumToConsumeNow")]
	[CalledBy(Type = typeof(InProgressCraftItem), Member = "UpdateWeight")]
	[CalledBy(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "NumNeedsConsuming")]
	public float GetPercentCompleteNormalized()
	{
		return default(float);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InProgressCraftItem()
	{
	}
}
