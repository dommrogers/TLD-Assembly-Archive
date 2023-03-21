using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class PowderItem : MonoBehaviour
{
	private class SaveData
	{
		public float m_WeightKG;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public SaveData()
		{
		}
	}

	public GearPowderType m_Type;

	public float m_WeightKG;

	public float m_WeightLimitKG;

	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	public float Add(float amount)
	{
		return default(float);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void Deserialize(string serialized)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 6)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public PowderItem()
	{
	}
}
