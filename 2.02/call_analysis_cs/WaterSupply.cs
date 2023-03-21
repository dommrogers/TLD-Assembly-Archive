using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WaterSupply : MonoBehaviour
{
	public LiquidQuality m_WaterQuality;

	public float m_VolumeInLiters;

	public float m_TimeToDrinkSeconds;

	public string m_DrinkingAudio;

	private static WaterSupplySaveDataProxy m_WaterSupplySaveDataProxy;

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void Start()
	{
	}

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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WaterSupply()
	{
	}
}
