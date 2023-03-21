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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
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
		return 0f;
	}

	[CallerCount(Count = 0)]
	public void IncrementProgress(float percentagePoints)
	{
	}

	[CalledBy(Type = typeof(ClothingSlot), Member = "HasOptionsAvailable")]
	[CalledBy(Type = typeof(Panel_Clothing), Member = "SetupScrollList")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "HandleCraftingInterrupt")]
	[CallerCount(Count = 4)]
	public bool IsProgressComplete()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	public bool ProgressHasStarted()
	{
		return false;
	}

	[CalledBy(Type = typeof(BlueprintData), Member = "HasRequiredMaterials")]
	[CallerCount(Count = 2)]
	public float GetPercentRemainingNormalized()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(InProgressCraftItem), Member = "UpdateWeight")]
	[CalledBy(Type = typeof(Panel_Crafting), Member = "ApplyCraftingProgress")]
	[CallerCount(Count = 2)]
	public float GetPercentCompleteNormalized()
	{
		return 0f;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public InProgressCraftItem()
	{
	}
}
