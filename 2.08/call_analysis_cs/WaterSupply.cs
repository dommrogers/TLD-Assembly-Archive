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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void Start()
	{
	}

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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WaterSupply()
	{
	}
}
