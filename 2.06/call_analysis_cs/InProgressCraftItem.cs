using Cpp2ILInjected.CallAnalysis;
using TLD.Gear;
using TLD.Serialization;
using UnityEngine;

public class InProgressCraftItem : MonoBehaviour
{
	public class InProgressCraftItemSaveDataProxy
	{
		public float m_PercentComplete;

		public float m_Weight;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public InProgressCraftItemSaveDataProxy()
		{
		}
	}

	private float m_PercentComplete;

	private float m_Weight;

	private static InProgressCraftItemSaveDataProxy m_InProgressCraftItemSaveDataProxy;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InProgressCraftItem), Member = "GetPercentCompleteNormalized")]
	[CallsUnknownMethods(Count = 3)]
	public void UpdateWeight(BlueprintData bp)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public float GetWeight()
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	public void IncrementProgress(float percentagePoints)
	{
	}

	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
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

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	public float GetPercentRemainingNormalized()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(InProgressCraftItem), Member = "UpdateWeight")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallerCount(Count = 2)]
	public float GetPercentCompleteNormalized()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public InProgressCraftItem()
	{
	}
}
