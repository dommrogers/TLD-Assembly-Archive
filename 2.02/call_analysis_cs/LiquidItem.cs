using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LiquidItem : MonoBehaviour
{
	public float m_LiquidLiters;

	public float m_LiquidCapacityLiters;

	public GearLiquidTypeEnum m_LiquidType;

	public LiquidQuality m_LiquidQuality;

	public float m_TimeToDrinkSeconds;

	public string m_DrinkingAudio;

	public float m_AmountPerUse;

	public bool m_RandomizeQuantity;

	private static LiquidItemSaveDataProxy m_LiquidItemSaveDataProxy;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Random), Member = "Range")]
	public void Awake()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public void Start()
	{
	}

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

	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(GearItem), Member = "GetSingleItemWeightKG")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public float GetLiquidWeightKG()
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LiquidItem()
	{
	}
}
