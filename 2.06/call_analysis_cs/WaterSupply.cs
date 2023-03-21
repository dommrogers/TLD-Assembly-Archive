using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class WaterSupply : MonoBehaviour
{
	public LiquidQuality m_WaterQuality;

	public float m_VolumeInLiters;

	public float m_TimeToDrinkSeconds;

	public string m_DrinkingAudio;

	private static WaterSupplySaveDataProxy m_WaterSupplySaveDataProxy;

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void Start()
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

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WaterSupply()
	{
	}
}
