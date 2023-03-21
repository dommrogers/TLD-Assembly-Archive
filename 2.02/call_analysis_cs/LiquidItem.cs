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
	[CallerCount(Count = 2)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GearItem), Member = "Serialize")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(GearItem), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightIgnoreClothingWornBonusKG")]
	[CalledBy(Type = typeof(GearItem), Member = "GetItemWeightKG")]
	[CalledBy(Type = typeof(GearItem), Member = "GetSingleItemWeightKG")]
	public float GetLiquidWeightKG()
	{
		return default(float);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public LiquidItem()
	{
	}
}
