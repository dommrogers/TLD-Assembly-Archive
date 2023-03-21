using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class PowderItem : MonoBehaviour
{
	private class SaveData
	{
		public float m_WeightKG;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public SaveData()
		{
		}
	}

	public GearPowderType m_Type;

	public float m_WeightKG;

	public float m_WeightLimitKG;

	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CalledBy(Type = typeof(PlayerManager), Member = "AddPowderToInventory")]
	[CallerCount(Count = 2)]
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
	[CallsUnknownMethods(Count = 1)]
	public string Serialize()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PowderItem()
	{
	}
}
