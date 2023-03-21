using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
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
	[CallerCount(Count = 6)]
	public void Start()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	public LiquidItem()
	{
	}
}
