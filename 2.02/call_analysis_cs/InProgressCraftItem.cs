using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class InProgressCraftItem : MonoBehaviour
{
	public class InProgressCraftItemSaveDataProxy
	{
		public float m_PercentComplete;

		public float m_Weight;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public InProgressCraftItemSaveDataProxy()
		{
		}
	}

	private float m_PercentComplete;

	private float m_Weight;

	private static InProgressCraftItemSaveDataProxy m_InProgressCraftItemSaveDataProxy;

	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[Calls(Type = typeof(Mathf), Member = "CeilToInt")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	public void UpdateWeight(BlueprintItem bpi)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWeight()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void IncrementProgress(float percentagePoints)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsProgressComplete()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool ProgressHasStarted()
	{
		return false;
	}

	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForKerosene")]
	[CalledBy(Type = typeof(CraftingRequirementMaterial), Member = "EnableForGunpowder")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetAdjustedCraftingTime")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "GetFinalCraftingTimeWithAllModifiers")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetPercentRemainingNormalized()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(BlueprintItem), Member = "NumNeedsConsuming")]
	[CalledBy(Type = typeof(BlueprintItem), Member = "NumToConsumeNow")]
	[CalledBy(Type = typeof(InProgressCraftItem), Member = "UpdateWeight")]
	[CalledBy(Type = typeof(InProgressCraftItem), Member = "GetPercentRemainingNormalized")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ConsumeMaterialsUsedForCrafting")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetPercentCompleteNormalized()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public InProgressCraftItem()
	{
	}
}
